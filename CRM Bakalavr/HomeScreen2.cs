using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Bakalavr
{
    public partial class HomeScreen2 : Sample
    {
        public HomeScreen2()
        {
            InitializeComponent();
        }

        private void rolesBtn_Click(object sender, EventArgs e)
        {

        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ChefOrderWindow cow = new ChefOrderWindow();
            MainClass.showWindow(cow, this, MDI.ActiveForm);
        }
    }
}
