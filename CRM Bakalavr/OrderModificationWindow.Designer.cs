namespace CRM_Bakalavr
{
    partial class OrderModificationWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.orderIDsCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.itemsDD = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.orderIDsLB = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dishPictureBox = new System.Windows.Forms.PictureBox();
            this.cartBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.totalOrderAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(137, 34);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.dishPictureBox);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Controls.Add(this.orderIDsLB);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.itemsDD);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.orderIDsCB);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Size = new System.Drawing.Size(300, 725);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.orderIDsCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.itemsDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.orderIDsLB, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.dishPictureBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(884, 725);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 34);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Order ID:";
            // 
            // orderIDsCB
            // 
            this.orderIDsCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orderIDsCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orderIDsCB.Enabled = false;
            this.orderIDsCB.FormattingEnabled = true;
            this.orderIDsCB.Location = new System.Drawing.Point(7, 231);
            this.orderIDsCB.Name = "orderIDsCB";
            this.orderIDsCB.Size = new System.Drawing.Size(286, 36);
            this.orderIDsCB.TabIndex = 1;
            this.orderIDsCB.SelectedIndexChanged += new System.EventHandler(this.orderIDsCB_SelectedIndexChanged);
            this.orderIDsCB.Enter += new System.EventHandler(this.orderIDsCB_Enter);
            this.orderIDsCB.Validating += new System.ComponentModel.CancelEventHandler(this.orderIDsCB_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Select Item:";
            // 
            // itemsDD
            // 
            this.itemsDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemsDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemsDD.Enabled = false;
            this.itemsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itemsDD.FormattingEnabled = true;
            this.itemsDD.Location = new System.Drawing.Point(7, 301);
            this.itemsDD.Name = "itemsDD";
            this.itemsDD.Size = new System.Drawing.Size(286, 36);
            this.itemsDD.TabIndex = 8;
            this.itemsDD.SelectedIndexChanged += new System.EventHandler(this.itemsDD_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price:";
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Location = new System.Drawing.Point(7, 371);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(286, 34);
            this.priceTxt.TabIndex = 10;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quantity:";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Location = new System.Drawing.Point(7, 439);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(286, 34);
            this.quantityTxt.TabIndex = 13;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderIDsLB
            // 
            this.orderIDsLB.FormattingEnabled = true;
            this.orderIDsLB.ItemHeight = 28;
            this.orderIDsLB.Location = new System.Drawing.Point(7, 479);
            this.orderIDsLB.Name = "orderIDsLB";
            this.orderIDsLB.Size = new System.Drawing.Size(286, 88);
            this.orderIDsLB.TabIndex = 4;
            this.orderIDsLB.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.orderIDGV,
            this.itemIDGV,
            this.ItemGV,
            this.perPriceGV,
            this.quantityGV,
            this.priceGV,
            this.deleteGV,
            this.totalOrderAmountGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(884, 608);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Tag = "";
            // 
            // dishPictureBox
            // 
            this.dishPictureBox.Image = global::CRM_Bakalavr.Properties.Resources.food;
            this.dishPictureBox.Location = new System.Drawing.Point(36, 560);
            this.dishPictureBox.Name = "dishPictureBox";
            this.dishPictureBox.Size = new System.Drawing.Size(225, 202);
            this.dishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dishPictureBox.TabIndex = 14;
            this.dishPictureBox.TabStop = false;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.cartBtn.Enabled = false;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartBtn.ForeColor = System.Drawing.Color.Khaki;
            this.cartBtn.Location = new System.Drawing.Point(36, 489);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(225, 54);
            this.cartBtn.TabIndex = 15;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 588);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(884, 137);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.totalLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 137);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.totalLabel.Location = new System.Drawing.Point(445, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(436, 137);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "0.0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 137);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Amount:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "#";
            this.snoGV.MinimumWidth = 8;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 60;
            // 
            // orderIDGV
            // 
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.MinimumWidth = 8;
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            this.orderIDGV.Visible = false;
            this.orderIDGV.Width = 150;
            // 
            // itemIDGV
            // 
            this.itemIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemIDGV.HeaderText = "ItemID";
            this.itemIDGV.MinimumWidth = 8;
            this.itemIDGV.Name = "itemIDGV";
            this.itemIDGV.ReadOnly = true;
            this.itemIDGV.Visible = false;
            // 
            // ItemGV
            // 
            this.ItemGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemGV.HeaderText = "Item";
            this.ItemGV.MinimumWidth = 8;
            this.ItemGV.Name = "ItemGV";
            this.ItemGV.ReadOnly = true;
            // 
            // perPriceGV
            // 
            this.perPriceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.perPriceGV.HeaderText = "Per Unit Price";
            this.perPriceGV.MinimumWidth = 8;
            this.perPriceGV.Name = "perPriceGV";
            this.perPriceGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.MinimumWidth = 8;
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // priceGV
            // 
            this.priceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceGV.HeaderText = "Total Price";
            this.priceGV.MinimumWidth = 8;
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            this.deleteGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.deleteGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.MinimumWidth = 8;
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "Remove";
            this.deleteGV.UseColumnTextForButtonValue = true;
            this.deleteGV.Width = 75;
            // 
            // totalOrderAmountGV
            // 
            this.totalOrderAmountGV.HeaderText = "Total";
            this.totalOrderAmountGV.MinimumWidth = 8;
            this.totalOrderAmountGV.Name = "totalOrderAmountGV";
            this.totalOrderAmountGV.ReadOnly = true;
            this.totalOrderAmountGV.Visible = false;
            this.totalOrderAmountGV.Width = 150;
            // 
            // OrderModificationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 725);
            this.Name = "OrderModificationWindow";
            this.Text = "Order Modification";
            this.Load += new System.EventHandler(this.OrderModificationWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox orderIDsCB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox orderIDsLB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox itemsDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.PictureBox dishPictureBox;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderAmountGV;
    }
}