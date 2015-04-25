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
#endregion

namespace modbrowser
{
    public partial class Main : Form
    {
        // modbrowser's path
        public string mbpath;

        public Main()
        {
            InitializeComponent();

            // Load mods
            ListMods();
        }

        /**
         * TODO : Fully uninstalls a mod.
         */
        private void uninstall(object sender, EventArgs e)
        {
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            // Shows TODO message
            MessageBox.Show("Fonctionnalité en cours de développement.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
         * When a mod is selected, puts mod info in the info panel.
         */
        private void modSelected(object sender, EventArgs e)
        {
            updateModInfo(mbpath + "/mods/" + modlist.SelectedItem + ".ssf");
        }

        #region Functions
        /**
         * Lists modbrowser-known mods.
         * @return null
         */
        public void ListMods()
        {
            // For each file in instances path...
            foreach (string file in System.IO.Directory.EnumerateFiles(mbpath + "/mods/"))
            {
                string[] modmeta = DecodeSSF(mbpath + file);
                modlist.Items.Add(modmeta[0]);
            }
        }

        /**
         * Decodes a *.SSF file.
         * @return the decoded array
         */
        public string[] DecodeSSF(string filepath)
        {
            string[] decoded = new string[1];
            try
            {
                // Prepares the DataSet and the DataTable
                DataSet ds = new DataSet("smartsaveformat");
                ds.ReadXml(filepath);
                DataTable dt = ds.Tables["datas"];

                // Prepares the array to return
                decoded = new string[dt.Columns.Count];

                // Puts saved variables on the array to return
                decoded[0] = dt.Rows[0]["col_name"].ToString();
                decoded[1] = dt.Rows[0]["col_author"].ToString();
                decoded[2] = dt.Rows[0]["col_version"].ToString();
                decoded[3] = dt.Rows[0]["col_description"].ToString();
                decoded[4] = dt.Rows[0]["col_image-url"].ToString();


            }
            catch (Exception e)
            {
                // Shows error MessageBox
                MessageBox.Show("Erreur lors du chargement des informations liées au mod. Cela peut arriver si le fichier est corrompu ou n'a pas le bon format.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Une erreur a eu lieu. L'application va maintenant se fermer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

            // Returns the array
            return decoded;
        }

        public void updateModInfo(string path)
        {
            // Gets mod info
            string[] modmeta = DecodeSSF(path);

            // Shows mod info
            modTitle.Text = modmeta[0];
            modAuthor.Text = modmeta[1] + " / " + modmeta[2];
            modDescription.Text = modmeta[3];
        }
        #endregion
    }
}
