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
    public partial class ChefOrderWindow : Sample2
    {
        public ChefOrderWindow()
        {
            InitializeComponent();
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen2 adm = new HomeScreen2();
            MainClass.showWindow(adm, MDI.ActiveForm);
            
        }
        private void ChefOrderWindow_Load(object sender, EventArgs e)
        {
            Retreival.getPendingOrders(dataGridView1,orderIDGV,statusGV);
            addBtn.Visible = false;
            editBtn.Visible = false;
            deleteBtn.Visible = false;
            saveBtn.Visible = false;
            //viewBtn.Visible = false;
            

        }
        Int64 orderID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                orderID = Convert.ToInt64(row.Cells["orderIDGV"].Value.ToString());
                Retreival.getPendingOrderDetails(orderID, dataGridView2, productGV, QuantityGV);
                //MainClass.sno(dataGridView1, "snoGV2");
                if(e.ColumnIndex == 0) //DONE button function
                {
                    DialogResult dr = MessageBox.Show("Are you sure?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        Updation.updateOrderStatus(orderID,1);
                        Retreival.getPendingOrders(dataGridView1, orderIDGV, statusGV);
                        
                    }
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            Retreival.getPendingOrders(dataGridView1, orderIDGV, statusGV);
            MainClass.sno(dataGridView1, "snoGV");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
