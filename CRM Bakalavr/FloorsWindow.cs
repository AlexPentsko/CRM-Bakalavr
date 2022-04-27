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
    public partial class FloorsWindow : Sample2
    {
        public FloorsWindow()
        {
            InitializeComponent();
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteFloor", "@floorID", floorID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
        }
        Int16 floorID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertFloors(floorTxt.Text, Convert.ToInt16(floorNumberDD.SelectedItem.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
                }
                else if (edit == 1)//update
                {
                    Updation.updateFloors(floorID, floorTxt.Text, Convert.ToInt16(floorNumberDD.SelectedItem.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getFloors(dataGridView1, floorIDGV, floorNameGV, floorNumberGV);
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

        private void floorTxt_TextChanged(object sender, EventArgs e)
        {
            if (floorTxt.Text == "") { floorTxt.BackColor = Color.Firebrick; } else { floorTxt.BackColor = Color.White; }
        }

        private void floorNumberDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(floorNumberDD.SelectedIndex == -1) { floorNumberDD.BackColor = Color.Firebrick; } else { floorNumberDD.BackColor = Color.White; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delStatus = 1;
                MainClass.DisableControls(leftPanel);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                floorID = Convert.ToInt16(row.Cells["floorIDGV"].Value.ToString());
                floorTxt.Text = row.Cells["floorNameGV"].Value.ToString();
                floorNumberDD.SelectedItem = row.Cells["floorNumberGV"].Value.ToString();
            }
        }
    }

}
