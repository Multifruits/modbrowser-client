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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            MessageBox.Show("Vous avez atteint l'objectif [A propos] ! Vous gagnez : 1x [COOKIE].", "Félicitations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
