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
    public partial class ManagerScreen : Sample

    {
        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {

        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            customersWindow ccw = new customersWindow();
            MainClass.showWindow(ccw, this, MDI.ActiveForm);
        }

        private void categoriesBtn_Click(object sender, EventArgs e)
        {
            FoodCategoriesWindow fcw = new FoodCategoriesWindow();
            MainClass.showWindow(fcw, this, MDI.ActiveForm);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            menuWindow mnw = new menuWindow();
            MainClass.showWindow(mnw, this, MDI.ActiveForm);
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            ordersWindow ow = new ordersWindow();
            MainClass.showWindow(ow, this, MDI.ActiveForm);
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            OrderCompletionWindow tw = new OrderCompletionWindow();
            MainClass.showWindow(tw, this, MDI.ActiveForm);
        }

        private void modBtn_Click(object sender, EventArgs e)
        {
            OrderModificationWindow tw = new OrderModificationWindow();
            MainClass.showWindow(tw, this, MDI.ActiveForm);
        }
    }
}
