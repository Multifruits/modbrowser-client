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

                Color.Black, // Amber (#ffa000)         
                Color.White, // Blue (#1976d2)
                Color.Black, // Light Blue (#0288d1)
                Color.Black, // Lime (#afb42b)
                Color.Black, // Cyan (#0097a7)
                Color.Black, // Grey (#616161)
                Color.White, // Blue Grey (#455a64)
                Color.White, // Indigo (#303f9f)
                Color.Black, // Yellow (#fbc02d)
                Color.White, // Brown (#5d4037)
                Color.Black, // Orange (#f57c00)
                Color.White, // Deep Orange (#e64a19)
                Color.White, // Pink (#c2185b)
                Color.White, // Red (#d32f2f)
                Color.Black, // Green (#388e3c)
                Color.Black, // Light Green (#689f38)
                Color.White, // Purple (#7b1fa2)
                Color.White, // Deep Purple (#512da8)
            }
        };
        #endregion

        public Main()
        {
            InitializeComponent();

            // Native modbrowser files
            if (!File.Exists("config.txt"))
            {
                File.WriteAllText("config.txt", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft");
            }
            if (!File.Exists("color.txt"))
            {
                File.WriteAllText("color.txt", "14");
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

            // Apply Material Design colors
            int selectedTheme = Convert.ToInt32(File.ReadAllText("color.txt"));
            modlistPanel.BackColor = themeColors[0, selectedTheme];
            modlist.BackColor = themeColors[0, selectedTheme];
            listButtonsPanel.BackColor = themeColors[1, selectedTheme];
            nomod.ForeColor = themeColors[2, selectedTheme];
            modlist.ForeColor = themeColors[2, selectedTheme];
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
            Form SettingsForm = new Settings();
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
                    MessageBox.Show("Vous devez être connecté à Internet pour récupérer les icônes des mods", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            modIcon.ImageLocation = Path.GetTempPath() + "mb_cache\\" + modmeta[0];
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

        /**
         * Open Forge website
         */
        private void menuItem_other_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dans le site qui va s'ouvrir, sélectionnez la version de Minecraft que vous voulez modder, puis cliquez sur l\'Installer-win qui correspond à votre version.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://files.minecraftforge.net/#Downloads");
        }

        /**
         * Download Forge 1.8
         */
        private void menuItem_18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Téléchargez le fichier qui va apparaître et ouvrez le.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.8-11.14.1.1398/forge-1.8-11.14.1.1398-installer-win.exe");
        }

        /**
         * Download Forge 1.7.10
         */
        private void menuItem_1710_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Téléchargez le fichier qui va apparaître et ouvrez le.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.7.10-10.13.3.1399-1.7.10/forge-1.7.10-10.13.3.1399-1.7.10-installer-win.exe");
        }

        /**
         * Download Forge 1.6.4
         */
        private void menuItem_164_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Téléchargez le fichier qui va apparaître et ouvrez le.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://files.minecraftforge.net/maven/net/minecraftforge/forge/1.6.4-9.11.1.1345/forge-1.6.4-9.11.1.1345-installer-win.exe");
        }

    }
}
