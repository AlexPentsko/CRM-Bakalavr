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
    public partial class rolesWindow : Sample2
    {
        public rolesWindow()
        {
            InitializeComponent();
        }
        int edit = 0; int delStatus = 0;
        

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
            if (roleErrorLabel.Visible)
            {
                MainClass.showMessage("Fields with * are empty", "Error");
            }
            else
            {
                if(edit == 0) //code for SAVE operation
                {
                    Insertion.insertRole(roleTxt.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
                else if (edit == 1) // code for UPDATE operation
                {
                    Updation.updateRole(roleTxt.Text, roleID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {

                if (delStatus == 1) //code for DEL
                {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) 
                {
                    Deletion.deleteData("st_deleteRole", "@rid", roleID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
                }
            }
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getRoles(dataGridView1, roleIDGV, roleNameGv);
        }
        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void roleTxt_TextChanged(object sender, EventArgs e)
        {
            if (roleTxt.Text == "") { roleErrorLabel.Visible = true; } else { roleErrorLabel.Visible = false; }
        }
        Int16 roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt16(row.Cells["roleIDGV"].Value.ToString());
                roleTxt.Text = row.Cells["roleNameGv"].Value.ToString();
            }
        }
    }
}
