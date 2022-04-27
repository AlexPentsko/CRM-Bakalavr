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
    public partial class FoodCategoriesWindow : Sample2
    {
        public FoodCategoriesWindow()
        {
            InitializeComponent();
        }
        int catID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGv"].Value.ToString());
                categoryTxt.Text = row.Cells["catGV"].Value.ToString();
            }
        }

        private void categoryTxt_TextChanged(object sender, EventArgs e)
        {
            if(categoryTxt.Text == "") { categoryTxt.BackColor = Color.Firebrick; } else { categoryTxt.BackColor = Color.White; }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteCategory", "@id", catID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategory(dataGridView1, catIDGv, catGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getCategory(dataGridView1, catIDGv, catGV);
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertCategory(categoryTxt.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategory(dataGridView1, catIDGv, catGV);
                }
                else if (edit == 1)//update
                {
                    Updation.updateCategory(catID, categoryTxt.Text);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getCategory(dataGridView1, catIDGv, catGV);
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
    }
}
