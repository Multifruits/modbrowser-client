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
        public int lastLang = Properties.Settings.Default.language;
        public int lastColor = Properties.Settings.Default.theme;
        
        public Settings()
        {
            InitializeComponent();
            color_comboBox.SelectedIndex = lastColor;
            language_comboBox.SelectedIndex = lastLang;
            saveSettings.Enabled = false;
            cacheSize.Text = Math.Truncate(GetDirectorySize(System.IO.Path.GetTempPath() + "mb_cache\\")/1000).ToString() + "KB";
        }

        /// <summary>
        /// Save settings when saveSettings button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveSettingsAction(object sender, EventArgs e)
        {
            Properties.Settings.Default.theme = color_comboBox.SelectedIndex;
            Properties.Settings.Default.language = language_comboBox.SelectedIndex;
            Properties.Settings.Default.Save();
            MessageBox.Show("Paramètres de modbrowser sauvegardés avec succès. Merci de redémarrer le logiciel pour que les modifications soient prises en compte.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            if (!language_comboBox.SelectedIndex.Equals(lastLang) || !color_comboBox.SelectedIndex.Equals(lastColor))
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
