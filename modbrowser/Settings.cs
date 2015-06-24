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
using System.Globalization;
#endregion

namespace modbrowser
{
    public partial class Settings : Form
    {
        // localization
        private System.Resources.ResourceManager RM = null;
        private CultureInfo EnglishCulture = new CultureInfo("en");
        private CultureInfo FrenchCulture = new CultureInfo("fr");

        public int lastLang = Properties.Settings.Default.language;
        public int lastColor = Properties.Settings.Default.theme;
        
        public Settings()
        {
            // Localization
            RM = new System.Resources.ResourceManager("modbrowser.Settings", System.Reflection.Assembly.GetExecutingAssembly());
            if (Properties.Settings.Default.language == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = FrenchCulture;
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = EnglishCulture;
            }

            InitializeComponent();
            color_comboBox.SelectedIndex = lastColor;
            language_comboBox.SelectedIndex = lastLang;
            saveSettings.Enabled = false;
            cacheSize.Text = Math.Truncate(GetDirectorySize(System.IO.Path.GetTempPath() + "mb_cache\\") / 1000).ToString() + "KB";
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
            MessageBox.Show(RM.GetString("saveSuccess"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Enable/disable save button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonOnOff(object sender, EventArgs e)
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

        /// <summary>
        /// Gets specified directory file.
        /// </summary>
        /// <param name="folderPath">Directory Path</param>
        /// <returns>Directory Size</returns>
        private static double GetDirectorySize(string folderPath)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(folderPath);
            return di.EnumerateFiles("*.*", System.IO.SearchOption.AllDirectories).Sum(fi => fi.Length);
        }
    }
}
