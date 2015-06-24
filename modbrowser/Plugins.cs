using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace modbrowser
{
    public partial class Plugins : Form
    {
        Plugin p;
        public Plugins()
        {
            InitializeComponent();
            ListPlugins();
        }

        private void pluginsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pluginsList.SelectedIndex >= 0)
            {
                p = JsonConvert.DeserializeObject<Plugin>(File.ReadAllText(@"plugins\\" + pluginsList.SelectedItem + ".json"));
                pluginName.Text = p.name;
                pluginVersion.Text = p.version;
                pluginAuthor.Text = p.author;

                APIversion.Text = p.api.version;
                APIurl.Text = p.api.url;

                gameName.Text = p.game.name;
                gamePath.Text = p.game.realPath;

                resourcePath.Text = p.game.resourcesPath;
                name.Visible = true;
            }
        }

        private void APIurl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(APIurl.Text);
        }

        private void ListPlugins()
        {
            pluginsList.Items.Clear();
            int i = 0;

            // For each file in plugins path...
            foreach (string file in System.IO.Directory.EnumerateFiles(@"plugins"))
            {
                i++;
                try
                {
                    Plugin p = JsonConvert.DeserializeObject<Plugin>(File.ReadAllText(file));
                    pluginsList.Items.Add(file.Replace("plugins\\", "").Replace(".json", ""));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement du plugin suivant : " + file.Replace(@"\\plugins\\", "").Replace(".json", ""), "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clipboard.SetText(ex.Message);
                    MessageBox.Show("Texte d'erreur copié dans le presse-papiers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void Plugins_Load(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            int selectedTheme = Convert.ToInt32(Properties.Settings.Default.theme);
            pluginsList.BackColor = mainForm.themeColors[0, selectedTheme];
            pluginsList.ForeColor = mainForm.themeColors[2, selectedTheme];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@"plugins\\" + pluginsList.SelectedItem + ".json");
            ListPlugins();
        }

        private void mainPageButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("\"path\": \"" + p.game.path + '"');
            System.IO.File.WriteAllText(@"plugins\\" + pluginsList.SelectedItem + ".json", System.IO.File.ReadAllText(@"plugins\\" + pluginsList.SelectedItem + ".json").Replace(("\"path\": \"" + p.game.path + '"').Replace("\\","\\\\"), ("\"path\": \"" + gamePath.Text + '"').Replace("\\","\\\\")));
            MessageBox.Show("Adresse du jeu mise à jour.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}