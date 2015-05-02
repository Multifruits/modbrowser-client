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
        public string api_url = "http://modbrowser.olympe.in/api/";
        public bool wasHashBoxClicked = false;
        public bool installing = false;

        public InstallMod()
        {
            InitializeComponent();
        }

        /**
         * What to do when the hash box is clicked.
         */
        private void hashBoxClicked(object sender, EventArgs e)
        {
            if (!wasHashBoxClicked)
            {
                wasHashBoxClicked = true;
                hashTextBox.Text = "";
            }
        }

        /**
         * What to do when the hash box text is changed.
         */
        private void hashBoxChanged(object sender, EventArgs e)
        {
            wasHashBoxClicked = true;
            installButton.Enabled = hashTextBox.Text.Length.Equals(40);
            invalidHash.Visible = !hashTextBox.Text.Length.Equals(40);
        }

        /**
         * Get mod's install url from the HASH
         * Download the mod from the mod's install url
         * Put the mod in Minecraft's mod folder
         * Occurs when installButton is clicked
         */
        private void installMod(object sender, EventArgs e)
        {
            // Verify mod install conditions
            if (Directory.Exists(File.ReadAllText("config.txt") + "\\mods\\"))
            {
                modInstall();
            }
            else if (!Directory.Exists(File.ReadAllText("config.txt")))
            {
                MessageBox.Show("Le répertoire de Minecraft spécifié dans les paramètres n'existe pas. Merci de le régler avant de pouvoir installer un mod.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form settingsForm = new modbrowser_Settings();
                settingsForm.Show();
                this.Close();
            }
            else if (!Directory.Exists(File.ReadAllText("config.txt") + "\\mods\\"))
            {
                Directory.CreateDirectory(File.ReadAllText("config.txt") + "\\mods\\");
                MessageBox.Show("Il n'y avait pas de dossier \"mods\" dans le répertoire de Minecraft alors modbrowser en a créé un.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        /**
         * Install the mod
         */
        public void modInstall()
        {
            installStatusLabel.Text = "Vérification du HASH";

            // Get mod's install url from the HASH
            WebClient client = new WebClient();
            string modName = client.DownloadString(api_url + "name.php?sha1=" + hashTextBox.Text);

            // Install the mod
            if (!File.Exists(File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar"))
            {
                try
                {
                    string modUrl = client.DownloadString(api_url + "version.php?hash=" + hashTextBox.Text);

                    // Download the mod from the mod's install url
                    if (modUrl.Contains("unknown"))
                    {
                        MessageBox.Show("Le HASH spécifié ne correspond à aucune version de mod.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        installStatusLabel.Text = "En attente";
                        statusBar.Visible = false;
                    }
                    else
                    {
                        installButton.Enabled = false;
                        installing = true;
                        installStatusLabel.Text = "Installation des informations du mod";
                        File.WriteAllText(Directory.GetCurrentDirectory() + "\\mods\\" + modName + ".xml", client.DownloadString(api_url + "xml.php?sha1=" + hashTextBox.Text).Replace("modpathgoeshere", File.ReadAllText("config.txt") + "\\mods\\mb_" + modName + ".jar"));
                        updateModInfo(Directory.GetCurrentDirectory() + "\\mods\\" + modName + ".xml");
                        modInfo.Visible = true;

                        statusBar.Visible = true;
                        installStatusLabel.Text = "Installation du JAR";
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                        client.DownloadFileAsync(new Uri(modUrl), File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vous devez être connecté pour installer des mods.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    installStatusLabel.Text = "En attente";
                    installing = false;
                    statusBar.Visible = false;
                    installButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vous avez déjà ce mod installé. Pour le réinstaller, désinstallez le d'abord.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult result = MessageBox.Show("Voulez-vous désinstaller ce mod et procéder à sa réinstallation ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    modUninstall(modName);
                    modInstall();
                }
                else
                {
                    MessageBox.Show("Installation annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    installStatusLabel.Text = "En attente";
                    statusBar.Visible = false;
                    this.Close();
                }
            }
        }

        /**
         * Fully uninstalls a mod
         */
        public void modUninstall(String modName)
        {
            string[] modmeta = DecodeXML(Directory.GetCurrentDirectory() + "\\mods\\" + modName + ".xml");
            if (File.Exists(modmeta[5]))
                File.Delete(modmeta[5]);
            else
                MessageBox.Show("Ce mod est introuvable et va être supprimé de la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            File.Delete(Directory.GetCurrentDirectory() + "\\mods\\" + modName + ".xml");
            MessageBox.Show("Le mod '" + modmeta[0] + "' a été supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * Finish the download
         */
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Finish the download
            MessageBox.Show("Mod installé avec succès. N'oubliez pas de recharger la liste des mods.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            installStatusLabel.Text = "En attente";
            installing = false;
            statusBar.Visible = false;
            installButton.Enabled = true;
            this.Close();
        }

        /**
         * Update the progress bar.
         * Occurs when DownloadProgress changes.
         */
        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            installStatusLabel.Text = "Installation du JAR (" + Math.Truncate(bytesIn/1000) + "kb/" + Math.Truncate(totalBytes/1000) + "kb)";
            try
            {
                statusBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }
            catch (Exception) { }
        }

        private void InstallMod_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (installing)
            {
                DialogResult result = MessageBox.Show("Annuler l'installation pourrait corrompre ce mod et faire bugger le logiciel. Êtes-vous sûr ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
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

        /**
         * Decodes a *.xml file.
         * @return the decoded array
         */
        public string[] DecodeXML(string filepath)
        {
            try
            {
                // Prepares the DataSet and the DataTable
                DataSet ds = new DataSet("smartsaveformat");
                ds.ReadXml(filepath);
                DataTable dt = ds.Tables["datas"];

                // Prepares the array to return
                string[] decoded = new string[dt.Columns.Count];

                // Puts saved variables on the array to return
                decoded[0] = dt.Rows[0]["col_name"].ToString();
                decoded[1] = dt.Rows[0]["col_author"].ToString();
                decoded[2] = dt.Rows[0]["col_version"].ToString();
                decoded[3] = dt.Rows[0]["col_description"].ToString();
                decoded[4] = dt.Rows[0]["col_image-url"].ToString();
                decoded[5] = dt.Rows[0]["col_jar-path"].ToString();

                // Returns the array
                return decoded;
            }
            catch (Exception)
            {
                MessageBox.Show("Le fichier de ce mod était corrompu et a été supprimé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete(filepath);
                return new string[25565];
            }
        }

        /**
         * Updates the mod info
         */
        public void updateModInfo(string path)
        {
            // Get mod info
            string[] modmeta = DecodeXML(path);

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

    }
}
