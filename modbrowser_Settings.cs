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
        public modbrowser_Settings()
        {
            InitializeComponent();
            minecraftPathBox.Text = System.IO.File.ReadAllText("config.txt");
        }

        /**
         * Folder browser dialog
         */
        private void selectFolder(object sender, EventArgs e)
        {
            DialogResult minecraftPath = minecraftFolderBrowser.ShowDialog();
            if (minecraftPath == DialogResult.OK) {
                minecraftPathBox.Text = minecraftFolderBrowser.SelectedPath;
            }
            
        }
    }
}
