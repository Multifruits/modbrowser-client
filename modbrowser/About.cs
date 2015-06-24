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

namespace modbrowser
{
    public partial class About : Form
    {
        // localization
        private System.Resources.ResourceManager RM = null;
        private CultureInfo EnglishCulture = new CultureInfo("en");
        private CultureInfo FrenchCulture = new CultureInfo("fr");

        public About()
        {
            // Localization
            RM = new System.Resources.ResourceManager("modbrowser.About", System.Reflection.Assembly.GetExecutingAssembly());
            if (Properties.Settings.Default.language == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = FrenchCulture;
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = EnglishCulture;
            }

            InitializeComponent();
            MessageBox.Show(RM.GetString("achievementGot"), RM.GetString("congrats"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
