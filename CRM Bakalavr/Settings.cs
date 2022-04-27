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
using System.Xml;
using System.IO;
using System.Security.AccessControl;

namespace CRM_Bakalavr
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void serverTxt_TextChanged(object sender, EventArgs e)
        {
            if (serverTxt.Text == "") { serverErrorLabel.Visible = true; } else { serverErrorLabel.Visible = false; }
        }

        private void databaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (databaseTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userErrorLabel.Visible = false;
                passErrorLabel.Visible = false;
                userTxt.Enabled = false;
                passTxt.Enabled = false;
                userTxt.Text = "";
                passTxt.Text = "";
            }
            else
            {
                userTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (userTxt.Text == "") { userErrorLabel.Visible = true; } else { userErrorLabel.Visible = false; }
            }
           
        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
            }
        }
         public void updateConfigFile(string con)
        {
            //obnovlyue config file
            XmlDocument XmlDoc = new XmlDocument();
            //zavantazhue config
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if(xElement.Name == "connectionStrings")
                {
                    //zavantazhue the conection string
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }
            //zapisue the connection string v config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        string connection;
        private void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\rms_connect";
            File.WriteAllText(path, connection);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                if (serverTxt.Text == "") { serverErrorLabel.Visible = true; } else { serverErrorLabel.Visible = false; }
                if (databaseTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
                if(serverErrorLabel.Visible || dbErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are empty.", "Error");
                }
                else
                {
                    connection = "Data Source=" + serverTxt.Text + 
                                 ";Initial Catalog=" + databaseTxt.Text + 
                                 ";Integrated Security=true;MultipleActiveResultSets = true;";
                    saveConnection();
                    DialogResult dr = MessageBox.Show("Setting saved successfully.");
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                    
                    
                }
            }
            else
            {
                if (serverTxt.Text == "") { serverErrorLabel.Visible = true; } else { serverErrorLabel.Visible = false; }
                if (databaseTxt.Text == "") { dbErrorLabel.Visible = true; } else { dbErrorLabel.Visible = false; }
                if (userTxt.Text == "") { userErrorLabel.Visible = true; } else { userErrorLabel.Visible = false; }
                if (passTxt.Text == "") { passErrorLabel.Visible = true; } else { passErrorLabel.Visible = false; }
                if (serverErrorLabel.Visible || dbErrorLabel.Visible || userErrorLabel.Visible || passErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are empty.", "Error");
                }
                else
                {
                    connection = "Data Source" + serverTxt.Text +
                                ";Initial Catalog=" + databaseTxt.Text +
                                ";User ID=" + userTxt.Text + ";Password=" + passTxt.Text + ";MultipleActiveResultSets = true;";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Setting saved successfully.");
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);
                    }
                }

            }
        }
    }
}
