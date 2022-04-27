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
    public partial class tablesWindow : Sample2
    {
        public tablesWindow()
        {
            InitializeComponent();
        }

        private void tablesWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getFloors", floorDD, "Floor", "ID"); // bere dani z BD
            floorDD.SelectedIndex = -1;
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delStatus == 1) //code for DEL
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to delete this record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion.deleteData("st_deleteTables", "@tableID", tableID);
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, chairsGV);
                }
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            Retreival.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, chairsGV);
        }
        int tableID;
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count == 0)
            {
                if (edit == 0) // save
                {
                    Insertion.insertTable(Convert.ToInt32(tableNumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV,chairsGV); 
                }
                else if (edit == 1)//update
                {
                    Updation.updateTable(tableID, Convert.ToInt32(tableNumberDD.SelectedItem.ToString()), Convert.ToInt16(chairsDD.SelectedItem.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString()));
                    MainClass.resetDisable(leftPanel);
                    Retreival.getTables(dataGridView1, floorIDGV, floorNameGV, TableNumberGV, tableidGV, chairsGV);
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
                tableID = Convert.ToInt32(row.Cells["tableidGV"].Value.ToString());
                tableNumberDD.SelectedItem = row.Cells["TableNumberGV"].Value.ToString();
                chairsDD.SelectedItem = row.Cells["chairsGV"].Value.ToString();
                floorDD.SelectedValue = row.Cells["floorIDGV"].Value;
            }
        }
    }
}
