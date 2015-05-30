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
    public partial class Settings : Form
    {
        public string lastConfig = System.IO.File.ReadAllText("config.txt");
        public int lastColor = Convert.ToInt32(System.IO.File.ReadAllText("color.txt"));

        public Settings()
        {
            InitializeComponent();
            minecraftPathBox.Text = lastConfig;
            colorComboBox.SelectedIndex = lastColor;
            if (!System.IO.Directory.Exists(lastConfig))
            {
                minecraftPathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft";
                MessageBox.Show("Le chemin de Minecraft entré était invalide et a été réinitialisé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
            }

            cacheSize.Text = Math.Truncate(GetDirectorySize(System.IO.Path.GetTempPath() + "mb_cache\\")/1000).ToString() + "KB";
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
                    System.IO.File.WriteAllText("color.txt", colorComboBox.SelectedIndex.ToString());
                    MessageBox.Show("Paramètres de modbrowser sauvegardés avec succès. Merci de relancer le logiciel pour que les modifications soient prises en compte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    System.IO.File.WriteAllText("config.txt", minecraftPathBox.Text);
                    MessageBox.Show("Le dossier entré n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minecraftPathBox.Text = lastConfig;
                }
            }
            catch (Exception)
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
        private void pathChanged(object sender, EventArgs e)
        {
            buttonOnOff();
        }

        public void buttonOnOff()
        {
            if (!minecraftPathBox.Text.Equals(lastConfig) || !colorComboBox.SelectedIndex.Equals(lastColor))
                saveSettings.Enabled = true;
            else
                saveSettings.Enabled = false;
        }

        private void eraseCache(object sender, EventArgs e)
        {
            // For each file in instances path...
            try
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.GetTempPath() + "mb_cache");
                System.IO.Directory.Delete(System.IO.Path.GetTempPath().Replace("\\", "\\\\") + "mb_cache", true);
                System.IO.Directory.CreateDirectory(System.IO.Path.GetTempPath() + "mb_cache");
            }
            catch (Exception) {}

            cacheSize.Text = Math.Truncate(GetDirectorySize(System.IO.Path.GetTempPath() + "mb_cache\\")/1000).ToString() + "KB";
        }

        private static double GetDirectorySize(string folderPath)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(folderPath);
            return di.EnumerateFiles("*.*", System.IO.SearchOption.AllDirectories).Sum(fi => fi.Length);
        }

        private void selectedColorChanged(object sender, EventArgs e)
        {
            buttonOnOff();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOnOff();
        }

    }
}
