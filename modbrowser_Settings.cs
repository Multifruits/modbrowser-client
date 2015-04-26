using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modbrowser
{
    public partial class modbrowser_Settings : Form
    {
        public string lastConfig = System.IO.File.ReadAllText("config.txt");
        public modbrowser_Settings()
        {
            InitializeComponent();
            minecraftPathBox.Text = lastConfig;
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
    }
}
