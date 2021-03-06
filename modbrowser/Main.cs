﻿#region Using statements
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
using System.Globalization;
using Newtonsoft.Json;
#endregion

namespace modbrowser
{
    public partial class Main : Form
    {
        // localization
        private System.Resources.ResourceManager RM = null;
        private CultureInfo EnglishCulture = new CultureInfo("en");
        private CultureInfo FrenchCulture = new CultureInfo("fr");
        private CultureInfo GermanCulture = new CultureInfo("de");
        private CultureInfo SpanishCulture = new CultureInfo("es");

        // modbrowser's paths
        public string mbpath;
        public string tempPath = Path.GetTempPath() + "mb_cache\\";

        List<string> pluginPathes = new List<string>();
        public Plugin currentPlugin;

        // minecraft's path
        public string minecraftpath;

        // api url
        public string api_url = "http://modbrowser.shost.ca/api/";

        // material color palette
        #region Material Design colors
        public Color[,] themeColors = new Color[,]
        {
            {
                // =====================
                //      BASE COLORS
                // =====================

                ColorTranslator.FromHtml("#ffc107"), // Amber (#ffc107)
                ColorTranslator.FromHtml("#2196f3"), // Blue (#2196f3)
                ColorTranslator.FromHtml("#03a9f4"), // Light Blue (#03a9f4)
                ColorTranslator.FromHtml("#cddc39"), // Lime (#cddc39)
                ColorTranslator.FromHtml("#00bcd4"), // Cyan (#00bcd4)
                ColorTranslator.FromHtml("#9e9e9e"), // Grey (#9e9e9e)
                ColorTranslator.FromHtml("#607d8b"), // Blue Grey (#607d8b)
                ColorTranslator.FromHtml("#3f51b5"), // Indigo (#3f51b5)
                ColorTranslator.FromHtml("#ffeb3b"), // Yellow (#ffeb3b)
                ColorTranslator.FromHtml("#795548"), // Brown (#795548)
                ColorTranslator.FromHtml("#ff9800"), // Orange (#ff9800)
                ColorTranslator.FromHtml("#ff5722"), // Deep Orange (#ff5722)
                ColorTranslator.FromHtml("#e91e63"), // Pink (#e91e63)
                ColorTranslator.FromHtml("#f44336"), // Red (#f44336)
                ColorTranslator.FromHtml("#4caf50"), // Green (#4caf50)
                ColorTranslator.FromHtml("#8bc34a"), // Light Green (#8bc34a)
                ColorTranslator.FromHtml("#9c27b0"), // Purple (#9c27b0)
                ColorTranslator.FromHtml("#673ab7") // Deep Purple (#673ab7)
            },
            {
                // =====================
                //     ACCENT COLORS
                // =====================

                ColorTranslator.FromHtml("#ffa000"), // Amber (#ffa000)
                ColorTranslator.FromHtml("#1976d2"), // Blue (#1976d2)
                ColorTranslator.FromHtml("#0288d1"), // Light Blue (#0288d1)
                ColorTranslator.FromHtml("#afb42b"), // Lime (#afb42b)
                ColorTranslator.FromHtml("#0097a7"), // Cyan (#0097a7)
                ColorTranslator.FromHtml("#616161"), // Grey (#616161)
                ColorTranslator.FromHtml("#455a64"), // Blue Grey (#455a64)
                ColorTranslator.FromHtml("#303f9f"), // Indigo (#303f9f)
                ColorTranslator.FromHtml("#fbc02d"), // Yellow (#fbc02d)
                ColorTranslator.FromHtml("#5d4037"), // Brown (#5d4037)
                ColorTranslator.FromHtml("#f57c00"), // Orange (#f57c00)
                ColorTranslator.FromHtml("#e64a19"), // Deep Orange (#e64a19)
                ColorTranslator.FromHtml("#c2185b"), // Pink (#c2185b)
                ColorTranslator.FromHtml("#d32f2f"), // Red (#d32f2f)
                ColorTranslator.FromHtml("#388e3c"), // Green (#388e3c)
                ColorTranslator.FromHtml("#689f38"), // Light Green (#689f38)
                ColorTranslator.FromHtml("#7b1fa2"), // Purple (#7b1fa2)
                ColorTranslator.FromHtml("#512da8") // Deep Purple (#512da8)
            },
            {
                // =====================
                //     FORE COLOR
                // =====================

                ColorTranslator.FromHtml("#212121"),      
                Color.White,
                ColorTranslator.FromHtml("#212121"),
                ColorTranslator.FromHtml("#212121"),
                ColorTranslator.FromHtml("#212121"),
                ColorTranslator.FromHtml("#212121"),
                Color.White,
                Color.White,
                ColorTranslator.FromHtml("#212121"),
                Color.White,
                ColorTranslator.FromHtml("#212121"),
                Color.White,
                Color.White,
                Color.White,
                ColorTranslator.FromHtml("#212121"),
                ColorTranslator.FromHtml("#212121"),
                Color.White,
                Color.White,
            }
        };
        #endregion

        public Main()
        {
            // Localization
            RM = new System.Resources.ResourceManager("modbrowser.Main", System.Reflection.Assembly.GetExecutingAssembly());
            if (Properties.Settings.Default.language == 0)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = GermanCulture;
            }
            else if (Properties.Settings.Default.language == 2)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = FrenchCulture;
            }
            else if (Properties.Settings.Default.language == 3)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = SpanishCulture;
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = EnglishCulture;
            }

            // Initialize component
            InitializeComponent();

            // Create modbrowser-necessary files and folders
            if (!Directory.Exists(Path.GetTempPath() + "mb_cache"))
                Directory.CreateDirectory(Path.GetTempPath() + "mb_cache");

            if (!Directory.Exists(@"plugins"))
            {
                Directory.CreateDirectory(@"plugins");
                System.Diagnostics.Process.Start("http://modbrowser.shost.ca/installsuccess/");
            }

            // Set useful variables
            mbpath = Directory.GetCurrentDirectory();

            // Load stats menu informations
            mbVersion.Text = "v2.0-beta.1";

            #region Apply Material Design colors
            int selectedTheme = Convert.ToInt32(Properties.Settings.Default.theme);
            modlistPanel.BackColor = themeColors[0, selectedTheme];
            modbrowserIconColorPanel.BackColor = themeColors[0, selectedTheme];
            modlist.BackColor = themeColors[0, selectedTheme];
            listButtonsPanel.BackColor = themeColors[1, selectedTheme];
            nomod.ForeColor = themeColors[2, selectedTheme];
            modlist.ForeColor = themeColors[2, selectedTheme];

            if (themeColors[2, selectedTheme] == ColorTranslator.FromHtml("#212121"))
                modbrowserIcon.Image = Properties.Resources.modbrowser_dark;
            else
                modbrowserIcon.Image = Properties.Resources.modbrowser_light;
            #endregion

            // Load mods and plugins
            ListMods();
            ListPlugins();
        }


        #region Events
        /// <summary>
        /// Uninstalls a mod when context menu "uninstall" button
        /// is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uninstallModStripMenuItem(object sender, EventArgs e)
        {
            if (modlist.SelectedItems.Count > 0)
                modUninstall(modlist.SelectedItems[0].Text.ToString());
            else
                MessageBox.Show(RM.GetString("uninstall_modnonselected"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Uninstalls a mod when "uninstall" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uninstall(object sender, EventArgs e)
        {
            modUninstall(modlist.SelectedItems[0].Text.ToString());
        }

        /// <summary>
        /// TODO : Puts a +1 to the specified mod.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void plusoneButton(object sender, EventArgs e)
        {
            // Shows TODO message
            MessageBox.Show(RM.GetString("indev"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// TODO : Updates the specified mod if necessary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton(object sender, EventArgs e)
        {
            updateModVersion();
        }

        /// <summary>
        /// Updates mod info when a modList item is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modSelected(object sender, EventArgs e)
        {
            if (modlist.SelectedItems.Count > 0)
            {
                if (File.Exists(@"" + currentPlugin.name + "/" + modlist.SelectedItems[0].Text + ".json"))
                {
                    updateModInfo(@"" + currentPlugin.name + "/" + modlist.SelectedItems[0].Text + ".json");
                    mainPagePanel.Visible = false;
                    modInfo.Visible = true;
                    mainPageButton.Enabled = true;
                }
                else
                {
                    gotoMenu();
                }
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
         * Open modbrowser's GitHub repository
         */
        private void GitHubLink(object sender, EventArgs e)
        {
            // Views modbrowser's GitHub page in the default web browser
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client");
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
            MessageBox.Show(RM.GetString("mb_update"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("https://github.com/Multifruits/modbrowser-client/releases");
        }

        /**
         * Reload the mod list.
         * Occurs when the reloadModList button is clicked.
         */
        public void reloadModsList(object sender, EventArgs e)
        {
            reloadModsListView();
            MessageBox.Show(RM.GetString("reloadModsList"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void reloadModsListView()
        {
            modlist.Items.Clear();
            ListMods();
            gotoMenu();
        }

        /**
         * What to do when the updateStripMenuItem is clicked
         */
        private void updateByStripMenuItem(object sender, EventArgs e)
        {
            updateModVersion();
        }

        /// <summary>
        /// Adapts mod list width when form resized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resizeModList(Object sender, EventArgs e)
        {
            modlist.Size = new Size(160, this.Size.Height - 200);
        }

        private void modbrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form SettingsForm = new Settings();
            SettingsForm.Show();
        }

        private void pluginsList_Click(object sender, EventArgs e)
        {
            installMenuItem.Enabled = (pluginsList.SelectedIndex >= 0);
            installMenuItem.Enabled = (pluginsList.SelectedIndex >= 0);
            modlistPanel.Enabled = (pluginsList.SelectedIndex >= 0);

            if (pluginsList.SelectedIndex >= 0)
            {
                Properties.Settings.Default.lastPlugin = pluginPathes[pluginsList.SelectedIndex];
                Properties.Settings.Default.Save();
                currentPlugin = JsonConvert.DeserializeObject<Plugin>(File.ReadAllText(pluginPathes[pluginsList.SelectedIndex]));
                this.reloadModsListView();
            }
        }

        private void gestionnaireDePluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plugins pluginForm = new Plugins();
            pluginForm.Show();
        }

        #endregion

        #region Functions
        /// <summary>
        /// Lists modbrowser-known mods.
        /// </summary>
        public void ListMods()
        {
            modlist.Items.Clear();
            modIconsList.Images.Clear();
            try
            {
                nomod.Text = RM.GetString("nomod");
                int i = 0;
                // For each file in instances path...
                foreach (string file in Directory.EnumerateFiles(@"" + currentPlugin.name))
                {
                    i++;
                    string[] modmeta = DecodeJSON(file);
                    if (File.Exists(modmeta[5]))
                    {
                        modlist.Items.Add(modmeta[0], i - 1);
                        nomod.Text = RM.GetString("installedMods");
                        buildImageList(modmeta);
                    }
                    else
                    {
                        buildImageList(modmeta);
                        File.Delete(mbpath + "\\" + currentPlugin.name + "\\" + modmeta[0] + ".json");
                    }
                }
            }
            catch (Exception) { }
            gotoMenu();
        }

        /// <summary>
        /// Builds modIconsList.
        /// </summary>
        /// <param name="modmeta"></param>
        private void buildImageList(string[] modmeta)
        {
            // Show the image
            if (!File.Exists(Path.GetTempPath() + "mb_cache\\" + modmeta[0]))
            {
                if (!Directory.Exists(Path.GetTempPath() + "mb_cache")) { Directory.CreateDirectory(Path.GetTempPath() + "mb_cache"); }
                WebClient webClient = new WebClient();
                try
                {
                    webClient.DownloadFile(modmeta[4], Path.GetTempPath() + "mb_cache\\" + modmeta[0]);
                    modIconsList.Images.Add(Image.FromFile(Path.GetTempPath() + "mb_cache\\" + modmeta[0]));
                }
                catch (Exception) { }
            }
            else
                modIconsList.Images.Add(Image.FromFile(Path.GetTempPath() + "mb_cache\\" + modmeta[0]));
        }

        /// <summary>
        /// Pings an URL.
        /// </summary>
        /// <param name="url">The URL to ping.</param>
        public void ListPlugins()
        {
            pluginPathes.Clear();
            pluginsList.Items.Clear();
            int i = 0;
            int index = 0;

            // For each file in instances path...
            foreach (string file in Directory.EnumerateFiles(mbpath + "\\plugins"))
            {
                i++;
                try
                {
                    Plugin p = JsonConvert.DeserializeObject<Plugin>(File.ReadAllText(file));
                    pluginsList.Items.Add(p.name);
                    pluginPathes.Add(file);

                    if (Properties.Settings.Default.lastPlugin == file)
                        index = i;

                    if (!Directory.Exists(@"" + p.name))
                        Directory.CreateDirectory(@"" + p.name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(RM.GetString("pluginLoadError") + file.Replace(mbpath + "\\plugins\\", "").Replace(".json", ""), RM.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clipboard.SetText(ex.Message);
                    MessageBox.Show(RM.GetString("errorCopiedInClipboard"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            pluginsList.SelectedIndex = index - 1;
            gotoMenu();
        }

        /// <summary>
        /// Shows install mod form when the menuItem is clicked.
        /// </summary>
        private void installMod(object sender, EventArgs e)
        {
            // Shows mod installation form
            Form installModForm = new InstallMod();
            installModForm.Show();
        }

        /// <summary>
        /// Decodes a *.json file.
        /// </summary>
        /// <param name="filepath">File to decode.</param>
        /// <returns>The decoded array</returns>
        public string[] DecodeJSON(string filepath)
        {
            try
            {
                // Prepares the DataSet and the DataTable
                Mod modToDecode = JsonConvert.DeserializeObject<Mod>(File.ReadAllText(filepath));

                // Prepares the array to return
                string[] decoded = new string[8];

                // Puts saved variables on the array to return
                decoded[0] = modToDecode.name;
                decoded[1] = modToDecode.author;
                decoded[2] = modToDecode.version;
                decoded[3] = modToDecode.description;
                decoded[4] = modToDecode.image_url;
                decoded[5] = modToDecode.jar.path;
                decoded[6] = modToDecode.jar.url;
                decoded[7] = modToDecode.category;

                // Returns the array
                return decoded;
            }
            catch (Exception ex)
            {
                MessageBox.Show(RM.GetString("corruptedJSON"), RM.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.Delete(filepath);
                Clipboard.SetText(ex.Message);
                MessageBox.Show(RM.GetString("errorCopiedInClipboard"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Question);
                return new string[25565];
            }
        }

        /// <summary>
        /// Updates mod info
        /// </summary>
        /// <param name="path">Mod info path</param>
        public void updateModInfo(string path)
        {
            // Get mod info
            string[] modmeta = DecodeJSON(path);

            // Show mod info
            modTitle.Text = modmeta[0];
            modAuthor.Text = modmeta[1] + " / " + modmeta[2];
            modDescription.Text = modmeta[3];
            modCategory.Text = modmeta[7];

            // Show the image
            if (!File.Exists(Path.GetTempPath() + "mb_cache\\" + modmeta[0]))
            {
                if (!Directory.Exists(Path.GetTempPath() + "mb_cache")) { Directory.CreateDirectory(Path.GetTempPath() + "mb_cache"); }
                WebClient webClient = new WebClient();
                try
                {
                    webClient.DownloadFile(modmeta[4], Path.GetTempPath() + "mb_cache\\" + modmeta[0]);
                }
                catch (Exception)
                {
                    MessageBox.Show(RM.GetString("icons_internetrequired"), RM.GetString("error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            modIcon.ImageLocation = Path.GetTempPath() + "mb_cache\\" + modmeta[0];
        }

        /// <summary>
        /// Fully uninstalls a mod
        /// </summary>
        /// <param name="modName">The mod to uninstall.</param>
        public void modUninstall(String modName)
        {
            string[] modmeta = DecodeJSON(mbpath + "\\" + currentPlugin.name + "\\" + modName + ".json");
            if (File.Exists(modmeta[5]))
                File.Delete(modmeta[5]);

            File.Delete(mbpath + "\\" + currentPlugin.name + "\\" + modName + ".json");
            ListMods();
            MessageBox.Show(modmeta[0] + RM.GetString("deleteSuccess"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hides the modInfo panel and shows the mainPage panel
        /// </summary>
        public void gotoMenu()
        {
            mainPagePanel.Visible = true;
            modInfo.Visible = false;
            mainPageButton.Enabled = false;
        }

        /// <summary>
        /// Updates mod version
        /// </summary>
        private void updateModVersion()
        {
            // Shows TODO message
            MessageBox.Show(RM.GetString("indev"), RM.GetString("info"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void modActionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
