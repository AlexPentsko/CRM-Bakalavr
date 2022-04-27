using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace CRM_Bakalavr
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\rms_connect"))
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();
                MainClass.showWindow(ls, this);
                //ls.Show();
            }
            
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Settings obj = new Settings();
            MainClass.showWindow(obj, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginScreen ls = new LoginScreen();
            MainClass.showWindow(ls, this);
        }
    }
}
