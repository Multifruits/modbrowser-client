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
            mbVersion.Text = "version " + ProductVersion;
            updateModNumber();

            // Load mods
            ListMods();
        }

        /**
         * TODO : Fully uninstalls a mod.
         */
        private void uninstall(object sender, EventArgs e)
        {
            string[] modmeta = DecodeXML(mbpath + "\\mods\\" + modlist.SelectedItem.ToString() + ".xml");
            if(File.Exists(modmeta[5]))
            {
                File.Delete(modmeta[5]);
                File.Delete(mbpath + "\\mods\\" + modlist.SelectedItem.ToString() + ".xml");
                modlist.Items.Clear();
                ListMods();
                MessageBox.Show("Le mod '" + modmeta[0] + "' a été supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                File.Delete(modmeta[5]);
                MessageBox.Show("Ce mod est introuvable et va être supprimé de la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete(mbpath + "\\mods\\" + modlist.SelectedItem.ToString() + ".xml");
                modlist.Items.Clear();
                ListMods();
                MessageBox.Show("Le mod '" + modmeta[0] + "' a été supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * When a mod is selected, puts mod info in the info panel.
         */
        private void modSelected(object sender, EventArgs e)
        {
            updateModInfo(mbpath + "/mods/" + modlist.SelectedItem + ".xml");
            statsPanel.Visible = false;
            modInfo.Visible = true;
            statsButton.Enabled = true;
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            statsPanel.Visible = true;
            modInfo.Visible = false;
            statsButton.Enabled = false;
        }

        private void modNumberButton(object sender, EventArgs e)
        {
            updateModNumber();
        }

        private void platformStatusButton(object sender, EventArgs e)
        {
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GitHubLink(object sender, EventArgs e)
        {
            // Views modbrowser's GitHub page in the default web browser
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client");
        }

        private void installModMenuButton(object sender, EventArgs e)
        {
            Form SettingsForm = new modbrowser_Settings();
            SettingsForm.Show();
        }

        private void aboutFormStart(object sender, EventArgs e)
        {
            Form aboutForm = new About();
            aboutForm.Show();
        }

        private void updatesButton(object sender, EventArgs e)
        {
            MessageBox.Show("Pour télécharger la dernière version de modbrowser, sélectionnez la dernière version depuis la page qui va s'ouvrir.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client");
        }

        #region Functions
        /**
         * Lists modbrowser-known mods.
         * @return null
         */
        public void ListMods()
        {
            // For each file in instances path...
            foreach (string file in System.IO.Directory.EnumerateFiles(mbpath + "\\mods"))
            {
                string[] modmeta = DecodeXML(file);
                modlist.Items.Add(modmeta[0]);
                nomod.Visible = false;
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
                catch (Exception ex)
                {
                    MessageBox.Show("Vous devez être connecté à Internet pour récupérer les icônes des mods", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            modIcon.ImageLocation = Path.GetTempPath() + modmeta[0] + "_modbrowser.jpg";
        }

        public void updateModNumber()
        {
            int modnumber = 0;
            foreach (string file in System.IO.Directory.EnumerateFiles(mbpath + "\\mods"))
            {
                modnumber++;
            }
            modNumberLabel.Text = modnumber.ToString();
        }
        #endregion

        /**
         * Reload the mod list.
         * Occurs when the reloadModList button is clicked.
         */
        private void reloadModsList(object sender, EventArgs e)
        {
            modlist.Items.Clear();
            ListMods();
            MessageBox.Show("La liste des mods a été rechargée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
