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
using System.IO;
using System.Net;
#endregion

namespace modbrowser
{
    public partial class Main : Form
    {
        // modbrowser's path
        public string mbpath;

        // minecraft's path
        public string minecraftpath;

        // api url
        public string api_url = "http://modbrowser.olympe.in/api/";

        public Main()
        {
            InitializeComponent();

            // Native modbrowser files
            if (!File.Exists("config.txt"))
            {
                File.WriteAllText("config.txt", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft");
            }
            if (!Directory.Exists(@"mods"))
            {
                Directory.CreateDirectory(@"mods");
            }

            // Set useful variables
            mbpath = Directory.GetCurrentDirectory();
            minecraftpath = File.ReadAllText("config.txt");

            // Load stats menu informations
            mbVersion.Text = "v1.0-beta.3";
            updateModNumber();

            // Load mods
            ListMods();
        }

        #region Events
        /**
         * Fully uninstalls a mod.
         */
        private void uninstallModStripMenuItem(object sender, EventArgs e)
        {
            if (File.Exists(mbpath + "/mods/" + modlist.SelectedItem + ".xml"))
                modUninstall(modlist.SelectedItem.ToString());
            else
                MessageBox.Show("Merci de cliquer sur le nom d'un mod puis ensuite d'essayer de le désinstaller.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * Fully uninstalls a mod.
         */
        private void uninstall(object sender, EventArgs e)
        {
            modUninstall(modlist.SelectedItem.ToString());
        }

        /**
         * TODO : Puts a +1 to the specified mod.
         */
        private void plusoneButton(object sender, EventArgs e)
        {
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * TODO : Updates the selected mod if necessary.
         */
        private void updateButton(object sender, EventArgs e)
        {
            updateModVersion();
        }

        /**
         * When a mod is selected, puts mod info in the info panel.
         */
        private void modSelected(object sender, EventArgs e)
        {
            if (File.Exists(mbpath + "/mods/" + modlist.SelectedItem + ".xml"))
            {
                updateModInfo(mbpath + "/mods/" + modlist.SelectedItem + ".xml");
                mainPagePanel.Visible = false;
                modInfo.Visible = true;
                mainPageButton.Enabled = true;
            }
            else
            {
                gotoMenu();
            }
        }

        /**
         * Go to menu
         */
        private void menuButton(object sender, EventArgs e)
        {
            gotoMenu();
        }

        /**
         * Update mod number stat
         */
        private void modNumberButton(object sender, EventArgs e)
        {
            updateModNumber();
        }

        /**
         * Verify platform status
         */
        private void platformStatusButton(object sender, EventArgs e)
        {
            pingTest(api_url.Replace("http://", "").Replace("/api/", ""));
        }

        /**
         * Open modbrowser's GitHub repository
         */
        private void GitHubLink(object sender, EventArgs e)
        {
            // Views modbrowser's GitHub page in the default web browser
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client");
        }

        /**
         * Shows the settings form
         */
        private void installModMenuButton(object sender, EventArgs e)
        {
            Form SettingsForm = new modbrowser_Settings();
            SettingsForm.Show();
        }

        /**
         * Show the about form
         */
        private void aboutFormStart(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.Show();
        }

        /**
         * Update modbrowser
         */
        private void updatesButton(object sender, EventArgs e)
        {
            MessageBox.Show("Pour télécharger la dernière version de modbrowser, sélectionnez la dernière version depuis la page qui va s'ouvrir.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client/releases");
        }

        /**
         * Reload the mod list.
         * Occurs when the reloadModList button is clicked.
         */
        private void reloadModsList(object sender, EventArgs e)
        {
            modlist.Items.Clear();
            ListMods();
            MessageBox.Show("La liste des mods a été rechargée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gotoMenu();
        }

        /**
         * What to do when the updateStripMenuItem is clicked
         */
        private void updateByStripMenuItem(object sender, EventArgs e)
        {
            updateModVersion();
        }

        #endregion

        #region Functions
        /**
         * Lists modbrowser-known mods.
         * @return null
         */
        public void ListMods()
        {
            try
            {
                nomod.Visible = true;
                // For each file in instances path...
                foreach (string file in System.IO.Directory.EnumerateFiles(mbpath + "\\mods"))
                {
                    string[] modmeta = DecodeXML(file);
                    modlist.Items.Add(modmeta[0]);
                    nomod.Visible = false;
                }
            }
            catch (Exception) { }
            gotoMenu();
        }

        /**
         * Pings an URL
         */
        private void pingTest(string url)
        {
            // Ping the platform
            System.Net.NetworkInformation.Ping pingClass = new System.Net.NetworkInformation.Ping();
            try
            {
                System.Net.NetworkInformation.PingReply pingReply = pingClass.Send(url, 5000);

                // Show the results
                platformStatusLabel.Text = (pingReply.RoundtripTime.ToString() + "ms");
                if (pingReply.RoundtripTime <= 100)
                {
                    platformStatusPanel.BackColor = Color.FromArgb(139, 195, 74);
                }
                else if (pingReply.RoundtripTime > 100 && pingReply.RoundtripTime <= 300)
                {
                    platformStatusPanel.BackColor = Color.FromArgb(255, 193, 7);
                }
                else
                {
                    platformStatusPanel.BackColor = Color.FromArgb(244, 67, 54);
                }
            }
            catch (Exception)
            {
                platformStatusLabel.Text = ("erreur");
                platformStatusPanel.BackColor = Color.FromArgb(244, 67, 54);
            }
        }

        /**
         * What to do when the mod installation button is clicked
         */
        private void installMod(object sender, EventArgs e)
        {
            // Shows mod installation form
            Form installModForm = new InstallMod();
            installModForm.Show();
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

        /**
         * Updates mod number stat
         */
        public void updateModNumber()
        {
            int modnumber = 0;
            foreach (string file in System.IO.Directory.EnumerateFiles(mbpath + "\\mods"))
            {
                modnumber++;
            }
            modNumberLabel.Text = modnumber.ToString();
        }

        /**
         * Fully uninstalls a mod
         */
        public void modUninstall(String modName)
        {
            string[] modmeta = DecodeXML(mbpath + "\\mods\\" + modName + ".xml");
            if (File.Exists(modmeta[5]))
                File.Delete(modmeta[5]);
            else
                MessageBox.Show("Ce mod est introuvable et va être supprimé de la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            File.Delete(mbpath + "\\mods\\" + modlist.SelectedItem.ToString() + ".xml");
            modlist.Items.Clear();
            ListMods();
            MessageBox.Show("Le mod '" + modmeta[0] + "' a été supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * Hide the modInfo panel and shows the mainPage panel
         */
        public void gotoMenu()
        {
            mainPagePanel.Visible = true;
            modInfo.Visible = false;
            mainPageButton.Enabled = false;
        }

        /**
         * Updates mod version
         */
        private void updateModVersion()
        {
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
