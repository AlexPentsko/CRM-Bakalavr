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
    public partial class LoginScreen : Sample
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0) //validacia danih
            {
                if (Retreival.isValidUser(userTxt.Text,passTxt.Text)) //if vse correct do
                {
                    if (Retreival.ROLE == "Admin")
                    {
                        adminHomeScreenWindow ahsw = new adminHomeScreenWindow();
                        MainClass.showWindow(ahsw, this, MDI.ActiveForm);
                    }
                    else if(Retreival.ROLE == "Chef")
                    {
                        HomeScreen2 ahsw = new HomeScreen2();
                        MainClass.showWindow(ahsw, this, MDI.ActiveForm);
                    }
                    else if (Retreival.ROLE == "Manager")
                    {
                        ManagerScreen ahsw = new ManagerScreen();
                        MainClass.showWindow(ahsw, this, MDI.ActiveForm);
                    }


                }
                else
                {
                    //stay on log window
                }
                
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (userTxt.Text == "") { userTxt.BackColor = Color.Firebrick; } else { userTxt.BackColor = Color.White; }
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (passTxt.Text == "") { passTxt.BackColor = Color.Firebrick; } else { passTxt.BackColor = Color.White; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
