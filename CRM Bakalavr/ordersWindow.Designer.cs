namespace CRM_Bakalavr
{
    partial class ordersWindow
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
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.itemsDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.NumericUpDown();
            this.cartBtn = new System.Windows.Forms.Button();
            this.dishPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.floorDD = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableDD = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.orderTypeDD = new System.Windows.Forms.ComboBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.detailsGbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).BeginInit();
            this.detailsGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.itemListBox);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.phoneLabel);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.tableDD);
            this.leftPanel.Controls.Add(this.floorDD);
            this.leftPanel.Controls.Add(this.orderTypeDD);
            this.leftPanel.Controls.Add(this.dishPictureBox);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.cartBtn);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.itemsDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Size = new System.Drawing.Size(300, 1050);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.itemsDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label9, 0);
            this.leftPanel.Controls.SetChildIndex(this.dishPictureBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.orderTypeDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.floorDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.tableDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.itemListBox, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsGbx);
            this.rightPanel.Size = new System.Drawing.Size(829, 1050);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.detailsGbx, 0);
            // 
            // priceTxt
            // 
            this.priceTxt.Enabled = false;
            this.priceTxt.Location = new System.Drawing.Point(14, 313);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(270, 34);
            this.priceTxt.TabIndex = 2;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(9, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Item:";
            // 
            // itemsDD
            // 
            this.itemsDD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.itemsDD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemsDD.Enabled = false;
            this.itemsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.itemsDD.FormattingEnabled = true;
            this.itemsDD.Location = new System.Drawing.Point(14, 231);
            this.itemsDD.Name = "itemsDD";
            this.itemsDD.Size = new System.Drawing.Size(270, 36);
            this.itemsDD.TabIndex = 6;
            this.itemsDD.SelectedIndexChanged += new System.EventHandler(this.itemsDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(9, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity:";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Enabled = false;
            this.quantityTxt.Location = new System.Drawing.Point(14, 392);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(270, 34);
            this.quantityTxt.TabIndex = 9;
            this.quantityTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTxt.ValueChanged += new System.EventHandler(this.quantityTxt_ValueChanged);
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.cartBtn.Enabled = false;
            this.cartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cartBtn.Location = new System.Drawing.Point(14, 778);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(270, 54);
            this.cartBtn.TabIndex = 10;
            this.cartBtn.Text = "ADD TO CART";
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // dishPictureBox
            // 
            this.dishPictureBox.Image = global::CRM_Bakalavr.Properties.Resources.food;
            this.dishPictureBox.Location = new System.Drawing.Point(14, 848);
            this.dishPictureBox.Name = "dishPictureBox";
            this.dishPictureBox.Size = new System.Drawing.Size(270, 202);
            this.dishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dishPictureBox.TabIndex = 11;
            this.dishPictureBox.TabStop = false;
            this.dishPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(9, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Floor:";
            // 
            // floorDD
            // 
            this.floorDD.AllowDrop = true;
            this.floorDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorDD.Enabled = false;
            this.floorDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.floorDD.FormattingEnabled = true;
            this.floorDD.Location = new System.Drawing.Point(14, 558);
            this.floorDD.Name = "floorDD";
            this.floorDD.Size = new System.Drawing.Size(270, 36);
            this.floorDD.TabIndex = 12;
            this.floorDD.SelectedIndexChanged += new System.EventHandler(this.floorDD_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(9, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Table:";
            // 
            // tableDD
            // 
            this.tableDD.AllowDrop = true;
            this.tableDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableDD.Enabled = false;
            this.tableDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableDD.FormattingEnabled = true;
            this.tableDD.Location = new System.Drawing.Point(14, 641);
            this.tableDD.Name = "tableDD";
            this.tableDD.Size = new System.Drawing.Size(270, 36);
            this.tableDD.TabIndex = 14;
            this.tableDD.SelectedIndexChanged += new System.EventHandler(this.tableDD_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(9, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Order Type:";
            // 
            // orderTypeDD
            // 
            this.orderTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderTypeDD.Enabled = false;
            this.orderTypeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderTypeDD.FormattingEnabled = true;
            this.orderTypeDD.Items.AddRange(new object[] {
            "Dine-In",
            "Take-Away",
            "Home-Delivery"});
            this.orderTypeDD.Location = new System.Drawing.Point(14, 475);
            this.orderTypeDD.Name = "orderTypeDD";
            this.orderTypeDD.Size = new System.Drawing.Size(270, 36);
            this.orderTypeDD.TabIndex = 16;
            this.orderTypeDD.SelectedIndexChanged += new System.EventHandler(this.orderTypeDD_SelectedIndexChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneLabel.Location = new System.Drawing.Point(9, 685);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(147, 28);
            this.phoneLabel.TabIndex = 19;
            this.phoneLabel.Text = "Enter Phone #:";
            this.phoneLabel.Visible = false;
            // 
            // phoneTxt
            // 
            this.phoneTxt.AllowDrop = true;
            this.phoneTxt.Enabled = false;
            this.phoneTxt.Location = new System.Drawing.Point(14, 720);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(270, 34);
            this.phoneTxt.TabIndex = 20;
            this.phoneTxt.Visible = false;
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // detailsGbx
            // 
            this.detailsGbx.Controls.Add(this.dataGridView1);
            this.detailsGbx.Controls.Add(this.panel5);
            this.detailsGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailsGbx.ForeColor = System.Drawing.Color.DimGray;
            this.detailsGbx.Location = new System.Drawing.Point(0, 129);
            this.detailsGbx.Name = "detailsGbx";
            this.detailsGbx.Size = new System.Drawing.Size(829, 921);
            this.detailsGbx.TabIndex = 6;
            this.detailsGbx.TabStop = false;
            this.detailsGbx.Text = "Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snoGV,
            this.tableIDGV,
            this.floorIDGV,
            this.catidGV,
            this.CatNameGV,
            this.itemIDGV,
            this.ItemGV,
            this.priceGV,
            this.quantityGV,
            this.orderTypeGV,
            this.floorGV,
            this.tableGV,
            this.phoneGV,
            this.deleteGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(823, 751);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // tableIDGV
            // 
            this.tableIDGV.HeaderText = "TableIDGV";
            this.tableIDGV.MinimumWidth = 8;
            this.tableIDGV.Name = "tableIDGV";
            this.tableIDGV.ReadOnly = true;
            this.tableIDGV.Visible = false;
            this.tableIDGV.Width = 150;
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "FloorIDGV";
            this.floorIDGV.MinimumWidth = 8;
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            this.floorIDGV.Width = 150;
            // 
            // catidGV
            // 
            this.catidGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catidGV.HeaderText = "CateID";
            this.catidGV.MinimumWidth = 8;
            this.catidGV.Name = "catidGV";
            this.catidGV.ReadOnly = true;
            this.catidGV.Visible = false;
            // 
            // CatNameGV
            // 
            this.CatNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CatNameGV.HeaderText = "Category";
            this.CatNameGV.MinimumWidth = 8;
            this.CatNameGV.Name = "CatNameGV";
            this.CatNameGV.ReadOnly = true;
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
            // priceGV
            // 
            this.priceGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceGV.HeaderText = "Price";
            this.priceGV.MinimumWidth = 8;
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.MinimumWidth = 8;
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // orderTypeGV
            // 
            this.orderTypeGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderTypeGV.HeaderText = "Order Type";
            this.orderTypeGV.MinimumWidth = 8;
            this.orderTypeGV.Name = "orderTypeGV";
            this.orderTypeGV.ReadOnly = true;
            // 
            // floorGV
            // 
            this.floorGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorGV.HeaderText = "Floor";
            this.floorGV.MinimumWidth = 8;
            this.floorGV.Name = "floorGV";
            this.floorGV.ReadOnly = true;
            // 
            // tableGV
            // 
            this.tableGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableGV.HeaderText = "Table";
            this.tableGV.MinimumWidth = 8;
            this.tableGV.Name = "tableGV";
            this.tableGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.MinimumWidth = 8;
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
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
            this.deleteGV.Width = 76;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 781);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 137);
            this.panel5.TabIndex = 1;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(823, 137);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLabel.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.totalLabel.Location = new System.Drawing.Point(414, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(406, 137);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "0.0";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(405, 137);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total Amount:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 28;
            this.itemListBox.Location = new System.Drawing.Point(12, 990);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(225, 60);
            this.itemListBox.TabIndex = 23;
            this.itemListBox.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 51);
            this.panel6.TabIndex = 24;
            // 
            // ordersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 1050);
            this.Name = "ordersWindow";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.ordersWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quantityTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).EndInit();
            this.detailsGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox itemsDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox orderTypeDD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tableDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox floorDD;
        private System.Windows.Forms.PictureBox dishPictureBox;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.NumericUpDown quantityTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label phoneLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox detailsGbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.Panel panel6;
    }
}