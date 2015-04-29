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
            installStatusLabel.Text = "Vérification du HASH";

            // Get mod's install url from the HASH
            WebClient client = new WebClient();
            string modName = client.DownloadString(api_url + "name.php?sha1=" + hashTextBox.Text);
            if(!File.Exists(File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar")) {
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
                MessageBox.Show("Vous avez déjà ce mod installé. Pour le mettre à jour ou le réinstaller, désinstallez le d'abord.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                installStatusLabel.Text = "En attente";
                statusBar.Visible = false;
            }
        }

        /**
         * Finish the download
         */
        public void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Finish the download
            MessageBox.Show("Mod installé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            installStatusLabel.Text = "En attente";
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

    }
}
