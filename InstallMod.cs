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
    public partial class InstallMod : Form
    {
        public bool wasHashBoxClicked = false;

        public InstallMod()
        {
            InitializeComponent();
        }

        /**
         * What to do when the hash box is clicked.
         */
        private void hashBoxClicked(object sender, EventArgs e)
        {
            if (!wasHashBoxClicked)
            {
                wasHashBoxClicked = true;
                hashTextBox.Text = "";
            }
        }

        /**
         * What to do when the hash box text is changed.
         */
        private void hashBoxChanged(object sender, EventArgs e)
        {
            if (hashTextBox.Text != "415ab40ae9b7cc4e66d6769cb2c08106e8293b48" && hashTextBox.Text.Length == 40)
            {
                installButton.Enabled = true;
                invalidHash.Visible = false;
            }
            else
            {
                installButton.Enabled = false;
                invalidHash.Visible = true;
            }
        }
    }
}
