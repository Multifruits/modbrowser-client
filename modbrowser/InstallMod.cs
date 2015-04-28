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
#endregion

namespace modbrowser
{
    public partial class InstallMod : Form
    {
        public string api_url = "http://modbrowser.olympe.in/api/";
        public bool wasHashBoxClicked = false;

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
            // Get mod's install url from the HASH
            WebClient client = new WebClient();
            string modName = client.DownloadString(api_url + "name.php?sha1=" + hashTextBox.Text);
            if(!System.IO.File.Exists(System.IO.File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar")) {
                try
                {
                    string modUrl = client.DownloadString(api_url + "version.php?hash=" + hashTextBox.Text);

                    // Download the mod from the mod's install url
                    if (modUrl.Contains("unknown"))
                    {
                        MessageBox.Show("Le HASH spécifié ne correspond à aucune version de mod.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Form mainForm = new Main();
                    
                        try { System.IO.File.Delete(System.IO.File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar"); }
                        catch (Exception) { }
                        
                        client.DownloadFile(modUrl, System.IO.File.ReadAllText("config.txt") + "\\mods\\" + "mb_" + modName + ".jar");
                        System.IO.File.WriteAllText(System.IO.Directory.GetCurrentDirectory() + "\\mods\\" + modName + ".xml", client.DownloadString(api_url + "xml.php?sha1=" + hashTextBox.Text).Replace("modpathgoeshere", System.IO.File.ReadAllText("config.txt") + "\\mods\\mb_" + modName + ".jar"));
                        MessageBox.Show("Mod installé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vous devez être connecté pour installer des mods.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous avez déjà ce mod installé. Pour le mettre à jour ou le réinstaller, désinstallez le d'abord.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
