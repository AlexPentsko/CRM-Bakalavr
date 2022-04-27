using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Bakalavr
{
    public partial class OrderModificationWindow : Sample2
    {
        public OrderModificationWindow()
        {
            InitializeComponent();
        }


        private void OrderModificationWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, orderIDsCB);
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, null , orderIDsLB);
            dataGridView1.DataSource = null;
            Retreival.loadItems("st_getMenu", itemsDD, "Menu Item", "MenuID");// taking items in list

        }
        private double orderAmount(Int64 orderID)
        {
            double om = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderAmount", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                MainClass.con.Open();
                om = Convert.ToDouble(cmd.ExecuteScalar().ToString());
                MainClass.con.Close();
            }   
            catch (Exception)
            {

            }
            return om;
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            ordersWindow.InsertOrderDetails(Convert.ToInt64(orderIDsCB.SelectedValue.ToString()), dataGridView1);
            double total = Convert.ToDouble(totalLabel.Text) + orderAmount(Convert.ToInt64(orderIDsCB.SelectedValue.ToString()));
            Updation.updateOrder(Convert.ToInt64(orderIDsCB.SelectedValue.ToString()), total);
        }
        private void getOrderDetails(Int64 orderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getOrderDetailsWRTOrderID",MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orderID", orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                itemIDGV.DataPropertyName = dt.Columns["ItemID"].ToString();
                ItemGV.DataPropertyName = dt.Columns["Item"].ToString();
                perPriceGV.DataPropertyName = dt.Columns["Per Item Price"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                orderIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                totalOrderAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void orderIDsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderIDsCB.SelectedIndex != -1)
            {
               DataRowView drv = orderIDsCB.SelectedItem as DataRowView;
               getOrderDetails(Convert.ToInt64(drv[0].ToString())); 
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, orderIDsCB);
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, null, orderIDsLB);
            dataGridView1.DataSource = null;
        }

        private void orderIDsCB_Enter(object sender, EventArgs e)
        {
            
        }

        private void orderIDsCB_Validating(object sender, CancelEventArgs e)
        {
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, orderIDsCB);
            Retreival.getOrderIDsWRTDate(dateTimePicker1.Value, null, orderIDsLB);
        }

        private void itemsDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsDD.SelectedIndex != -1)
            {

                try
                {
                    itemsDD.BackColor = Color.White;
                    SqlCommand cmd = new SqlCommand("st_getPriceWRTItem", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemsDD.SelectedValue.ToString()));
                    MainClass.con.Open();
                    priceTxt.Text = Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()), 0).ToString(); //remove all 0 after dot //1.0000
                    MainClass.con.Close();
                    Image i = Retreival.getItemImage(Convert.ToInt32(itemsDD.SelectedValue.ToString())); //load piture from DB
                    dishPictureBox.Image = i;
                    dishPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    DataRowView drv = itemsDD.SelectedItem as DataRowView;
                    Retreival.loadCategoryWRTItem(drv["Menu Item"].ToString());
                }
                catch (Exception ex)
                {
                    MainClass.con.Close();
                    MainClass.showMessage(ex.Message, "Error");
                }
            }
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            if (MainClass.checkControls(leftPanel).Count != 0)
            {
                MainClass.showMessage("Field with red are mandatory.", "Error");
            }
            else
            {
                bool check = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["itemIDGV"].Value.ToString() == itemsDD.SelectedValue.ToString()) //if item is found check true
                    {
                        check = true;
                        break;
                    }

                }

                DataRowView drvItem = itemsDD.SelectedItem as DataRowView;
                float totalAmount = 0;
                if (check)
                {
                    MainClass.showMessage("Item added already!", "Success");
                }
                else
                {

                   

                        totalAmount += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(quantityTxt.Value); //total price
                        totalLabel.Text = totalAmount.ToString();
                        DataRowView drv = orderIDsCB.SelectedItem as DataRowView;
                        DataRowView drv2 = itemsDD.SelectedItem as DataRowView;
                        dataGridView1.Rows.Add(null, Convert.ToInt64(drv[0].ToString()), 
                            Convert.ToInt64(itemsDD.SelectedValue.ToString()), drv2[1].ToString(), 
                            Convert.ToDouble(priceTxt.Text), 
                            quantityTxt.Value, Convert.ToDouble(priceTxt.Text)*Convert.ToInt32(quantityTxt.Value));
                            

                    
                }

            }
            MainClass.sno(dataGridView1, "snoGV"); //numeracia v gridview
        }
    }
}
