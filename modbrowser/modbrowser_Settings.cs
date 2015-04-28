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
#endregion

namespace modbrowser
{
    public partial class modbrowser_Settings : Form
    {
        public string lastConfig = System.IO.File.ReadAllText("config.txt");

        public modbrowser_Settings()
        {
            InitializeComponent();
            minecraftPathBox.Text = lastConfig;
            if (!System.IO.Directory.Exists(lastConfig))
            {
                minecraftPathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft";
                MessageBox.Show("Le chemin de Minecraft entré était invalide et a été réinitialisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
            }
        }

        /**
         * Folder browser dialog
         * Occurs when folderBrowserBtn is clicked.
         */
        private void selectFolder(object sender, EventArgs e)
        {
            DialogResult minecraftPath = minecraftFolderBrowser.ShowDialog();
            if (minecraftPath == DialogResult.OK) {
                minecraftPathBox.Text = minecraftFolderBrowser.SelectedPath;
            }
            
        }

        /**
         * Save settings.
         * Occurs when saveSettings button is clicked.
         */
        private void saveSettingsAction(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(minecraftPathBox.Text))
                {
                    System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
                    MessageBox.Show("Paramètres de modbrowser sauvegardés avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
                    MessageBox.Show("Le dossier entré n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minecraftPathBox.Text = lastConfig;
                }
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
                MessageBox.Show("Le chemin du dossier entré est invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                minecraftPathBox.Text = lastConfig;
            }
        }

        /**
         * Enable/disable button.
         * Occurs when minecraftPathBox.Text changes.
         */
        private void buttonOnOff(object sender, EventArgs e)
        {
            saveSettings.Enabled = !minecraftPathBox.Text.Equals(lastConfig);
        }

        private void eraseCache(object sender, EventArgs e)
        {
            // For each file in instances path...
            foreach (string file in System.IO.Directory.EnumerateFiles(System.IO.Directory.GetCurrentDirectory() + "\\mods"))
            {
                try
                {
                    System.IO.File.Delete(System.IO.Path.GetTempPath() + file.Replace(".xml", "").Replace(System.IO.Directory.GetCurrentDirectory() + "\\mods", "") + "_modbrowser.jpg");
                }
                catch (Exception ex) {}
                MessageBox.Show("Le cache a été vidé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
