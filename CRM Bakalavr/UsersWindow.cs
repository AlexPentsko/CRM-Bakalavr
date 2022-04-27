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
    public partial class UsersWindow : Sample2
    {
        public UsersWindow()
        {
            InitializeComponent();
        }

        private void UsersWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getRoles", rolesDD, "Role", "RoleID"); //відображає ролі в юзерс
            rolesDD.SelectedIndex = -1; //по замовчуванню щоб поле ролі було пусте.
            //Помилка уныкальної ролі створена в БД, вивід помилки в класі Insertion.
            rolesDD.BackColor = Color.White;
            
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (nameTxt.Text == "") { nameTxt.BackColor = Color.Firebrick; } else { nameTxt.BackColor = Color.White; }
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressTxt.BackColor = Color.Firebrick; } else { addressTxt.BackColor = Color.White; }
        }

        private void rolesDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolesDD.SelectedIndex == -1) { rolesDD.BackColor = Color.Firebrick; } else { rolesDD.BackColor = Color.White; }
        }



        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteUsers", "@userID", userID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGv);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGv);
        }
        int userID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertUsers(nameTxt.Text, userTxt.Text, PasswordTxt.Text, addressTxt.Text, phoneTxt.Text, Convert.ToInt16(rolesDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGv);
                }
                else if (edit == 1)//update
                {
                    Updation.updateUsers(userID, nameTxt.Text, userTxt.Text, PasswordTxt.Text, addressTxt.Text, phoneTxt.Text, Convert.ToInt16(rolesDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getUsers(dataGridView1, userIDGV, NameGV, usernameGV, passGV, phoneGV, addressGV, roleIDGV, roleNameGv);
                }
                    
                
            }
            else
            {
                MessageBox.Show("Please enter all requaired fills!");
            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt16(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                userTxt.Text = row.Cells["usernameGV"].Value.ToString();
                PasswordTxt.Text = row.Cells["passGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
                rolesDD.SelectedValue = row.Cells["roleIDGV"].Value;

            }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { PasswordTxt.BackColor = Color.Firebrick; } else { PasswordTxt.BackColor = Color.White; }
        }
    }
}
