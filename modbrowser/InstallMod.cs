#region Using statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
#endregion

namespace modbrowser
{
    public partial class InstallMod : Form
    {
        Main mainForm = new Main();

        public string api_url;

        // Last mod and last version selected.
        public string lastMod;
        public string lastVersion;
        
        public bool installing = false;

        // Define temporary path
        public string tempPath = System.IO.Path.GetTempPath() + "mb_cache\\";

        public InstallMod()
        {
            InitializeComponent();

            api_url = mainForm.currentPlugin.api.url;

            #region Apply Material Design colors
            int selectedTheme = Convert.ToInt32(File.ReadAllText("color.txt"));
            this.BackColor = mainForm.themeColors[0, selectedTheme];
            installBox.ForeColor = mainForm.themeColors[2, selectedTheme];
            modDescription.BackColor = mainForm.themeColors[0, selectedTheme];
            modDescription.ForeColor = mainForm.themeColors[2, selectedTheme];
            modTitle.ForeColor = mainForm.themeColors[2, selectedTheme];
            installModLabel.ForeColor = mainForm.themeColors[2, selectedTheme];
            correspondingVersionsLabel.ForeColor = mainForm.themeColors[2, selectedTheme];
            #endregion

            // Update mods list
            updateListFromUrl(installModList, api_url + "?mode=list", "modList.txt");
        }

        #region Functions
        /// <summary>
        /// Install the specified mod
        /// </summary>
        /// <param name="name">Mod name</param>
        /// <param name="version">Mod version</param>
        private void modInstall(string name, string version)
        {
            // Get mod's install url from the HASH
            WebClient client = new WebClient();

            string modPath = File.ReadAllText("config.txt") + "\\" + mainForm.currentPlugin.name + "\\" + "mb_" + lastMod + mainForm.currentPlugin.game.modsPrefix;
            string modInfoPath = Directory.GetCurrentDirectory() + "\\" + mainForm.currentPlugin.name + "\\" + lastMod + ".json";

            // Install the mod
            if (!File.Exists(modPath))
            {
                // Download the mod from the mod's install url
                installButton.Enabled = false;
                installing = true;

                installStatusLabel.Text = "Installation des informations du mod";
                client.DownloadFile((api_url + "?n=" + lastMod + "&v=" + lastVersion).Replace("modpathgoeshere", File.ReadAllText("config.txt") + "\\" + mainForm.currentPlugin.name + "\\mb_" + lastMod + mainForm.currentPlugin.game.modsPrefix), modInfoPath);
                updateModInfo(modInfoPath);
                modInfo.Visible = true;
                statusBar.Visible = true;

                string modUrl = mainForm.DecodeJSON(modInfoPath)[6];

                installStatusLabel.Text = "Installation du mod";
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadInProgress);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadCompleted);
                client.DownloadFileAsync(new Uri(modUrl), modPath);
            }
            else if(!File.Exists(modPath) && File.Exists(modInfoPath))
            {
                File.Delete(modInfoPath);
                modInstall(lastMod, installVersionList.SelectedItems[0].Text);
            }
            else
            {
                MessageBox.Show("Vous avez déjà ce mod installé. Pour le réinstaller, désinstallez le d'abord.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult result = MessageBox.Show("Voulez-vous désinstaller ce mod et procéder à sa réinstallation ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    mainForm.modUninstall(lastMod);
                    modInstall(lastMod, installVersionList.SelectedItems[0].Text);
                }
                else
                {
                    MessageBox.Show("Installation annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    installationFinished();
                }
            }
        }

        /// <summary>
        /// Retrieves mods from the API and puts them in the specified
        /// ListView.
        /// </summary>
        /// <param name="listView">ListView to complete</param>
        /// <param name="url">API url</param>
        /// <param name="fileName">Temporary file name</param>
        private void updateListFromUrl(ListView listView, string url, string fileName)
        {
            listView.Items.Clear();
            WebClient client = new WebClient();

            if (File.Exists(tempPath + fileName))
                File.Delete(tempPath + fileName);

            client.DownloadFile(url, tempPath + fileName);

            foreach (var line in File.ReadAllLines(tempPath + fileName))
                listView.Items.Add(line);
        }

        /// <summary>
        /// Updates mod info
        /// </summary>
        /// <param name="path">Mod info path</param>
        public void updateModInfo(string path)
        {
            // Get mod info
            string[] modmeta = mainForm.DecodeJSON(path);

            // Show mod info
            modTitle.Text = modmeta[0];
            modAuthor.Text = modmeta[1] + " / " + modmeta[2];
            modDescription.Text = modmeta[3];
            
            // Show the image
            if (!File.Exists(Path.GetTempPath() + modmeta[0] + "_modbrowser.jpg"))
            {
                WebClient webClient = new WebClient();
                try
                {
                    webClient.DownloadFile(modmeta[4], Path.GetTempPath() + modmeta[0] + "_modbrowser.jpg");
                }
                catch (Exception)
                {
                    MessageBox.Show("Vous devez être connecté à Internet pour récupérer les icônes des mods", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            modIcon.ImageLocation = Path.GetTempPath() + modmeta[0] + "_modbrowser.jpg";
        }

        /// <summary>
        /// Last operations to do after installation completion.
        /// </summary>
        public void installationFinished()
        {
            installStatusLabel.Text = "En attente";
            statusBar.Visible = false;
            installing = false;
            this.Close();
        }

        #endregion

        #region Events
        /// <summary>
        /// Finishes the download.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void downloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Finish the download
            MessageBox.Show("Mod installé avec succès. N'oubliez pas de recharger la liste des mods.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            installationFinished();
        }

        /// <summary>
        /// Updates the progress bar and the label according to download
        /// progress.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void downloadInProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            installStatusLabel.Text = "Installation du mod (" + Math.Truncate(bytesIn/1000) + "kb/" + Math.Truncate(totalBytes/1000) + "kb)";
            try
            {
                statusBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Asks a confirmation from the user if we must cancel the download,
        /// or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void installationClosing(object sender, FormClosingEventArgs e)
        {
            if (installing)
            {
                DialogResult result = MessageBox.Show("Annuler l'installation pourrait corrompre ce mod ou/et faire bugger le logiciel. Êtes-vous sûr ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("L'installation a été annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    installButton.Enabled = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void installModList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (installModList.SelectedItems.Count > 0)
            {
                updateListFromUrl(installVersionList, api_url + "?mode=version&n=" + installModList.SelectedItems[0].Text, "modVersionList.txt");
                lastMod = installModList.SelectedItems[0].Text;
                lastVersion = null;
                installButton.Enabled = false;
            }
        }

        private void installVersionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (installVersionList.SelectedItems.Count > 0)
            {
                installButton.Enabled = true;
                lastVersion = installVersionList.SelectedItems[0].Text;
            }
            else
                installButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.TextLength >= 3)
                updateListFromUrl(installModList, api_url + "?mode=list&s=" + searchBox.Text, "modList.txt");
            else if (searchBox.TextLength > 0)
                MessageBox.Show("Votre recherche ne comprend pas assez de caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Merci d'ajouter des mots-clés à votre recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            updateListFromUrl(installModList, api_url + "?mode=list", "modList.txt");
        }

        /**
 * Get mod's install url from the HASH
 * Download the mod from the mod's install url
 * Put the mod in Minecraft's mod folder
 * Occurs when installButton is clicked
 */
        private void installButton_Clicked(object sender, EventArgs e)
        {
            // Verify mod install conditions
            if (Directory.Exists(mainForm.currentPlugin.game.realRes))
            {
                modInstall(lastMod, installVersionList.SelectedItems[0].Text);
            }
            else if (!Directory.Exists(File.ReadAllText("config.txt")))
            {
                MessageBox.Show("Le répertoire du jeu spécifié dans le plugin n'existe pas. Merci de le régler avant de pouvoir installer un mod.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form settingsForm = new Plugins();
                settingsForm.Show();
                this.Close();
            }

        }
        #endregion

    }
}
