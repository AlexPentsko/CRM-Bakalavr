using CrystalDecisions.CrystalReports.Engine;
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
    public partial class OrderCompletionWindow : Sample

    {
        public OrderCompletionWindow()
        {
            InitializeComponent();
        }
        int chk = 0;
        private void OrderCompletionWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Retreival.loadItems("st_getFloors", floorDD, "Floor", "ID"); // floors
            Retreival.loadItems("st_getTax", taxDD, "Type", "Value"); // floors
            floorDD.SelectedIndex = -1;//making clear floordd by def
            tablesDD.SelectedIndex = -1;//making clear floordd by def
            dataGridView1.DataSource = null; //making clear datagridview by def
            billLabel.Text = "";
            orderIDTxt.Text = "";
        }

        private void floorDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(floorDD.SelectedIndex != -1)
            {
                Retreival.loadItems("st_getTablesWRTFloor", tablesDD, "Table Number", "Table ID", "@floorID", Convert.ToInt32(floorDD.SelectedValue.ToString()));
                tablesDD.SelectedIndex = -1;
                dataGridView1.DataSource = null; //making clear datagridview by def
                billLabel.Text = "";
                orderIDTxt.Text = "";
            }
            else
            {

            }
        }
        float taxAmount = 0;
        private void tablesDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesDD.SelectedIndex != -1)
            {
                if (chk != 0)
                {
                    if (Retreival.getOrder4Bill(Convert.ToInt32(tablesDD.SelectedValue.ToString()), dataGridView1, itemGV, quantGV, amountGV, orderIDGV, totalAmountGV))
                    {
                        float amount = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                             amount += (float)Math.Round(Convert.ToDouble(row.Cells["amountGV"].Value.ToString()), 0);
                        }

                    
                    float percentage = Convert.ToSingle(taxDD.SelectedValue.ToString()) / 100;
                    taxAmount = amount * percentage;
                    DataRowView drv = taxDD.SelectedItem as DataRowView;
                    if (drv["Type"].ToString() == "Inclusive") // if the tax incl then
                    {

                    }
                    else if (drv["Type"].ToString() == "Exclusive") //exclusive
                    {
                        amount += taxAmount;
                    }

                    billLabel.Text = amount.ToString();
                    orderIDTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
                    amtPaidTxt.Text = "";
                    amtReturnedTxt.Text = "";
                }

            }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            adminHomeScreenWindow obj = new adminHomeScreenWindow();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void tablesDD_Enter(object sender, EventArgs e)
        {
            chk = 1;
        }

        private void amtPaidTxt_TextChanged(object sender, EventArgs e)
        {
            if(amtPaidTxt.Text == "") 
            { 
                amtPaidTxt.BackColor = Color.Firebrick; 
            } 
            else 
            { 
                amtPaidTxt.BackColor = Color.White;
                if (Convert.ToDouble(amtPaidTxt.Text) >= Convert.ToDouble(billLabel.Text)) //amt paid and returned
                {
                    double amtPaid = Convert.ToDouble(amtPaidTxt.Text);
                    double amtReturn = amtPaid - Convert.ToDouble(billLabel.Text);
                    amtReturnedTxt.Text = amtReturn.ToString();

                }
            }
        }
        ReportDocument rd;
        private void billBtn_Click(object sender, EventArgs e) 
        {
            if(orderTypeDD.SelectedIndex == 0)
            {
                if (amtReturnedTxt.Text != "" && taxDD.SelectedIndex != -1 && floorDD.SelectedIndex != -1 && tablesDD.SelectedIndex != -1) //dine in
                {
                    int ch = Updation.updateOrder(Convert.ToInt64(orderIDTxt.Text), Convert.ToSingle(amtPaidTxt.Text), Convert.ToSingle(amtReturnedTxt.Text), 2, taxID, taxAmount);
                    if (ch > 0)
                    {
                        DialogResult dr = MessageBox.Show("Order Completed Successfully", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK) //showing report when press the bill btn and update the data
                        {
                            rd = new ReportDocument();
                           
                        Retreival.loadBillReport(rd, crystalReportViewer1, 2,Convert.ToInt64(orderIDTxt.Text));
      
                        }
                    }
                }
            
            }
            else
            {
                if (amtReturnedTxt.Text != "" && taxDD.SelectedIndex != -1 && phoneTxt.Text != "") //take away and home del
                {
                    int ch = Updation.updateOrder(Convert.ToInt64(orderIDTxt.Text), Convert.ToSingle(amtPaidTxt.Text), Convert.ToSingle(amtReturnedTxt.Text), 2, taxID, taxAmount);
                    if (ch > 0)
                    {
                        DialogResult dr = MessageBox.Show("Order Completed Successfully", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK) //showing report when press the bill btn and update the data
                        {
                            rd = new ReportDocument();
                            Retreival.loadBillReport(rd, crystalReportViewer1, 2, Convert.ToInt64(orderIDTxt.Text));

                        }
                    }
                }
            }   
        }

        private void orderTypeDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderTypeDD.SelectedIndex != -1)
            {
                if(orderTypeDD.SelectedIndex == 0) //dinein mode
                {
                    floorDD.Enabled = true;
                    tablesDD.Enabled = true;
                    phoneLabel.Visible = false;
                    phoneTxt.Visible = false;
                    floorDD.Visible = true;
                    tablesDD.Visible = true;
                    tableLabel.Visible = true;
                    floorLabel.Visible = true;
                }
                else
                {
                    floorDD.Enabled = false;
                    tablesDD.Enabled = false;
                    phoneLabel.Visible = true;
                    phoneTxt.Visible = true;
                    floorDD.Visible = false;
                    tablesDD.Visible = false;
                    tableLabel.Visible = false;
                    floorLabel.Visible = false;
                }
            }
        }

        private void phoneTxt_Leave(object sender, EventArgs e) //upload orders by phone num
        {
            if(phoneTxt.Text != "")
            {
                Retreival.getOrder4Bill(phoneTxt.Text, dataGridView1, itemGV, quantGV, amountGV, orderIDGV, totalAmountGV);
                double amount = Math.Round(Convert.ToDouble(dataGridView1.Rows[0].Cells["totalAmountGV"].Value.ToString()),0);
                double percentage = Convert.ToDouble(taxDD.SelectedValue.ToString()) / 100;
                double taxAmount = amount * percentage;
                DataRowView drv = taxDD.SelectedItem as DataRowView;
                if (drv["Type"].ToString() == "Inclusive") // if the tax incl then
                {

                }
                else if (drv["Type"].ToString() == "Exclusive") //exclusive
                {
                    amount += taxAmount;
                }

                billLabel.Text = amount.ToString();
                orderIDTxt.Text = dataGridView1.Rows[0].Cells["orderIDGV"].Value.ToString();
            }
        }
        Int16 taxID =0;
        private void taxDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(taxDD.SelectedIndex != -1)
            {
                DataRowView drv = taxDD.SelectedItem as DataRowView;
                taxID = Retreival.getTaxID(drv["Type"].ToString());
            }
        }

        private void OrderCompletionWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd!= null)
            {
                rd.Close();
            }
        }
    }
}
