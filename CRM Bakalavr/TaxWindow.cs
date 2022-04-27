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
    public partial class TaxWindow : Sample2
    {
        public TaxWindow()
        {
            InitializeComponent();
        }

        private void TaxWindow_Load(object sender, EventArgs e)
        {

        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteTax", "@taxID", TaxID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTax(dataGridView1, taxIDGV, taxTypeGV, valueGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getTax(dataGridView1, taxIDGV, taxTypeGV, valueGV);
        }
        Int16 TaxID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertTax(Convert.ToSingle(taxValueTxt.Text), taxTypeDD.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTax(dataGridView1, taxIDGV, taxTypeGV, valueGV);
                }
                else if (edit == 1)//update
                {
                    Updation.updateTax(TaxID, Convert.ToSingle(taxValueTxt.Text), taxTypeDD.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTax(dataGridView1, taxIDGV, taxTypeGV, valueGV);
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
                TaxID = Convert.ToInt16(row.Cells["taxIDGV"].Value.ToString());
                taxValueTxt.Text = row.Cells["valueGV"].Value.ToString();
                taxTypeDD.SelectedItem = row.Cells["taxTypeGV"].Value.ToString();
            }
        }

        private void taxTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (taxTypeDD.SelectedIndex == -1) { taxTypeDD.BackColor = Color.Firebrick; } else { taxTypeDD.BackColor = Color.White; }
        }

        private void taxValueTxt_TextChanged(object sender, EventArgs e)
        {
            if (taxValueTxt.Text == "") { taxValueTxt.BackColor = Color.Firebrick; } else { taxValueTxt.BackColor = Color.White; }
        }
    }
}
