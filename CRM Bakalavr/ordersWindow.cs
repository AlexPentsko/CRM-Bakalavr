using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CRM_Bakalavr.Properties;
using System.Transactions;

namespace CRM_Bakalavr
{
    public partial class ordersWindow : Sample2
    {
        public ordersWindow()
        {
            InitializeComponent();
        }
        float totalAmount = 0;
        int catID;
        string catName;
        private void cartBtn_Click(object sender, EventArgs e)
        {
           if(MainClass.checkControls(leftPanel).Count != 0)
            {
                MainClass.showMessage("Field with red are mandatory.", "Error");
            }
            else
            {
                bool check = false;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells["itemIDGV"].Value.ToString() == itemsDD.SelectedValue.ToString()) //if item is found check true
                    {
                        check = true;
                        break;
                    }

                }
                DataRowView drvFloor = floorDD.SelectedItem as DataRowView;
                DataRowView drvTable = tableDD.SelectedItem as DataRowView;
                DataRowView drvItem = itemsDD.SelectedItem as DataRowView;
                
                if(check)
                {
                    MainClass.showMessage("Item added already!", "Success");
                }
                else
                {
                    catID = Retreival.CATEGORYID;
                    catName = Retreival.CATEGORYNAME;
                    if (orderTypeDD.SelectedIndex == 0)//dine in
                    {
                       
                        totalAmount += Convert.ToSingle(priceTxt.Text)*Convert.ToSingle( quantityTxt.Value); //total price
                        totalLabel.Text = totalAmount.ToString();
                        dataGridView1.Rows.Add(null, Convert.ToInt32(tableDD.SelectedValue.ToString()),
                            Convert.ToInt32(floorDD.SelectedValue.ToString()),
                            catID, catName,
                            Convert.ToInt32(itemsDD.SelectedValue.ToString()),
                            drvItem["Menu Item"],
                            Convert.ToSingle(priceTxt.Text),
                            Convert.ToInt32(quantityTxt.Text),
                            orderTypeDD.SelectedItem.ToString(),
                            drvFloor["Floor"],
                            drvTable["Table Number"],
                            null);

                    }
                    else if (orderTypeDD.SelectedIndex == 1 || orderTypeDD.SelectedIndex == 2) //else
                    {
                        totalAmount += Convert.ToSingle(priceTxt.Text) * Convert.ToSingle(quantityTxt.Value);;
                        totalLabel.Text = totalAmount.ToString();
                        dataGridView1.Rows.Add(null, null,
                            null,
                           catID, catName,
                            Convert.ToInt32(itemsDD.SelectedValue.ToString()),
                            drvItem["Menu Item"],
                            Convert.ToSingle(priceTxt.Text),
                            Convert.ToInt32(quantityTxt.Text),
                            orderTypeDD.SelectedItem.ToString(),
                            null, null,
                            phoneTxt.Text);
                    }
                }

            }
            MainClass.sno(dataGridView1, "snoGV"); //numeracia v gridview
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ordersWindow_Load(object sender, EventArgs e)
        {
            Retreival.loadItems("st_getMenu", itemListBox, "Menu Item", "MenuID");// taking items in list
            Retreival.loadItems("st_getMenu", itemsDD, "Menu Item", "MenuID");// taking items in list
            Retreival.loadItems("st_getFloors", floorDD, "Floor", "ID"); // floors
            floorDD.SelectedIndex = -1; //DD will be empty by default
            itemsDD.SelectedIndex = -1;
            floorDD.BackColor = Color.White;
            tableDD.BackColor = Color.White;
            itemsDD.BackColor = Color.White;
            priceTxt.BackColor = Color.White;
            quantityTxt.BackColor = Color.White;
        }

        

        private void itemsDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(itemsDD.SelectedIndex != -1)
            {
                try
                {
                    itemsDD.BackColor = Color.White;
                    SqlCommand cmd = new SqlCommand("st_getPriceWRTItem", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mid", Convert.ToInt32(itemsDD.SelectedValue.ToString()));
                    MainClass.con.Open();
                    priceTxt.Text = Math.Round(Convert.ToDouble(cmd.ExecuteScalar().ToString()),0).ToString(); //remove all 0 after dot //1.0000
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
            else
            {
                priceTxt.Text = ""; //koli select item on backend the price was automaticaly readen
                priceTxt.BackColor = Color.White; // // // // //
                dishPictureBox.Image = Resources.food; //by def standart image
                itemsDD.BackColor = Color.Firebrick;
            }
        }

        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(floorDD.SelectedIndex != -1)
            {
                floorDD.BackColor = Color.White;
                Retreival.loadItems("st_getTablesWRTFloor", tableDD, "Table Number", "Table ID", "@floorID", Convert.ToInt32(floorDD.SelectedValue.ToString()));
                tableDD.SelectedIndex = -1;
            }
            else
            {
                floorDD.BackColor = Color.Firebrick;
            }
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderTypeDD.SelectedIndex != -1)
            {
                orderTypeDD.BackColor = Color.White;
                if (orderTypeDD.SelectedIndex == 0) //dine-in
                {
                    floorDD.Enabled = true;
                    tableDD.Enabled = true;
                    phoneTxt.Visible = false;
                    phoneLabel.Visible = false;
                    floorDD.BackColor = Color.Firebrick;
                    tableDD.BackColor = Color.Firebrick;
                    phoneTxt.BackColor = Color.White;
                }
                else //take-away or home delivery
                {
                    floorDD.Enabled = false;
                    tableDD.Enabled = false;
                    phoneTxt.Visible = true;
                    phoneLabel.Visible = true;
                    floorDD.BackColor = Color.White;
                    tableDD.BackColor = Color.White;
                    phoneTxt.BackColor = Color.Firebrick;
                }
            }
            else 
            { 
                orderTypeDD.BackColor = Color.Firebrick; 
            }
        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {
            if(priceTxt.Text != "") { priceTxt.BackColor = Color.White; } else { priceTxt.BackColor = Color.Firebrick; }
        }

        private void tableDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableDD.SelectedIndex != -1) 
            { 
                tableDD.BackColor = Color.White;
                if (Retreival.CheckTableStatus(Convert.ToInt32(tableDD.SelectedValue.ToString()), Convert.ToInt16(floorDD.SelectedValue.ToString())))
                {
                    tableDD.SelectedIndex = -1;
                }
            } 
            else 
            { 
                tableDD.BackColor = Color.Firebrick; 
            }
        }

        Int64 custID;
        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            if (phoneTxt.Text != "") 
            { 
                phoneTxt.BackColor = Color.White;
            } 
            else 
            { 
                phoneTxt.BackColor = Color.Firebrick; 
            }
        }

        private void quantityTxt_ValueChanged(object sender, EventArgs e)
        {
            if (quantityTxt.Value == 0)
            {
                quantityTxt.BackColor = Color.Firebrick;
            }
            else
            {
                quantityTxt.BackColor = Color.White;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1) // if you delete the row the price will be updated
            {
                if (e.ColumnIndex == 13)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    float prc = Convert.ToSingle(row.Cells["priceGV"].Value.ToString())*Convert.ToSingle(quantityTxt.Value); //removing price
                    totalAmount -= prc;
                    totalLabel.Text = totalAmount.ToString();
                    dataGridView1.Rows.Remove(row);
                    MainClass.sno(dataGridView1, "snoGV"); //after remove buton click update the numeration
                }
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }
        public static void InsertOrderDetails(Int64 orderID, DataGridView gv)
        {

            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {
                count += Insertion.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["itemIDGV"].Value.ToString()), Convert.ToInt16(row.Cells["quantityGV"].Value.ToString())); //insert all order details
            }
            if (count > 0)
            {
                MainClass.showMessage("Order Placed!", "Success");
            }
            else
            {
                MainClass.showMessage("Error", "Success");
            }
        }
        //private void InsertOrderDetails()
        //{
        //    Int64 orderID = Retreival.lastOrderID(); //freshed out last order
        //    int count = 0;
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        count += Insertion.insertOrderDetails(orderID, Convert.ToInt32(row.Cells["itemIDGV"].Value.ToString()), Convert.ToInt16(row.Cells["quantityGV"].Value.ToString())); //insert all order details
        //    }
        //    if (count > 0)
        //    {
        //        MainClass.showMessage("Order Placed!", "Success");
        //    }
        //    else
        //    {
        //        MainClass.showMessage("Error", "Success");
        //    }
        //}
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            using (TransactionScope sc = new TransactionScope()) //help to use DB proc in 2 different tables
            {
                try
                {
                    if(orderTypeDD.SelectedIndex == 0) //if dine-in we dont need the customer ID
                    {
                        Insertion.insertOrder(DateTime.Today, 1, Convert.ToInt16 (orderTypeDD.SelectedIndex),Convert.ToInt16(floorDD.SelectedValue.ToString()),Convert.ToInt16(tableDD.SelectedValue.ToString()),Convert.ToSingle(totalLabel.Text),0, 0, 0,0,0); //taking the system date and insert all data
                        InsertOrderDetails(Retreival.lastOrderID(),dataGridView1);

                    }
                    else //if (orderTypeDD.SelectedIndex == 1 || orderTypeDD.SelectedIndex == 2) //take-away and home del 
                    {
                        Insertion.insertOrder(DateTime.Today, custID, Convert.ToInt16(orderTypeDD.SelectedIndex), 0, 0, Convert.ToSingle(totalLabel.Text),  0, 0, 0,0,0); //taking the system date //now for the custID we need a phone number
                        InsertOrderDetails(Retreival.lastOrderID(),dataGridView1);

                    }


                }
                catch (Exception)
                {

                }
                sc.Complete();

            }
        }

        public override void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Leave(object sender, EventArgs e) //when you leave the phonetxt
        {
            if (phoneTxt.Text != "")
            {
                phoneTxt.BackColor = Color.White;
                custID = Retreival.getCustomerIDWRTPhone(phoneTxt.Text);
                if (custID == 0)
                {
                    customersWindow cw = new customersWindow();
                    MainClass.showWindow(cw, this, MDI.ActiveForm);
                }
                else
                {
                    MainClass.showMessage(Retreival.CUSTOMER + "\n" + Retreival.ADDRESS + "\n","Success");
                }
            }
            
        }
    }
}
