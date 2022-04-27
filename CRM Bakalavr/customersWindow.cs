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
    public partial class customersWindow : Sample2
    {
        public customersWindow()
        {
            InitializeComponent();
        }

        Int64 custID;
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteCustomer", "@cID",0, custID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertCustomer(nameTxt.Text, phoneTxt.Text, addressTxt.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
                }
                else if (edit == 1)//update
                {
                    Updation.updateCustomer(custID, nameTxt.Text, phoneTxt.Text, addressTxt.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCustomers(dataGridView1, custIDGV, NameGV, phoneGV, addressGV);
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

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if(nameTxt.Text == "") { nameTxt.BackColor = Color.Firebrick; } else { nameTxt.BackColor = Color.White; }
           
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text == "") { phoneTxt.BackColor = Color.Firebrick; } else { phoneTxt.BackColor = Color.White; }
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            if (addressTxt.Text == "") { addressTxt.BackColor = Color.Firebrick; } else { addressTxt.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                custID = Convert.ToInt64(row.Cells["custIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                phoneTxt.Text = row.Cells["phoneGV"].Value.ToString();
                addressTxt.Text = row.Cells["addressGV"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
