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
            wasHashBoxClicked = true;
            installButton.Enabled = hashTextBox.Text.Length.Equals(40);
            invalidHash.Visible = !hashTextBox.Text.Length.Equals(40);
        }
    }
}
