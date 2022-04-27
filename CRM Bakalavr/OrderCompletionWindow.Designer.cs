namespace CRM_Bakalavr
{
    partial class OrderCompletionWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorDD = new System.Windows.Forms.ComboBox();
            this.tablesDD = new System.Windows.Forms.ComboBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.orderIDTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.orderTypeDD = new System.Windows.Forms.ComboBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.amtPaidTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.amtReturnedTxt = new System.Windows.Forms.TextBox();
            this.billBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.taxDD = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.backBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.flowLayoutPanel1);
            this.leftPanel.Controls.Add(this.panel3);
            this.leftPanel.Size = new System.Drawing.Size(455, 1050);
            this.leftPanel.Controls.SetChildIndex(this.panel3, 0);
            this.leftPanel.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.crystalReportViewer1);
            this.rightPanel.Location = new System.Drawing.Point(455, 0);
            this.rightPanel.Size = new System.Drawing.Size(675, 1050);
            this.rightPanel.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.floorLabel.Location = new System.Drawing.Point(3, 70);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(64, 28);
            this.floorLabel.TabIndex = 2;
            this.floorLabel.Text = "Floor:";
            // 
            // floorDD
            // 
            this.floorDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorDD.Enabled = false;
            this.floorDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.floorDD.FormattingEnabled = true;
            this.floorDD.Location = new System.Drawing.Point(3, 101);
            this.floorDD.Name = "floorDD";
            this.floorDD.Size = new System.Drawing.Size(448, 36);
            this.floorDD.TabIndex = 3;
            this.floorDD.SelectedIndexChanged += new System.EventHandler(this.floorDD_SelectedIndexChanged);
            // 
            // tablesDD
            // 
            this.tablesDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tablesDD.Enabled = false;
            this.tablesDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tablesDD.FormattingEnabled = true;
            this.tablesDD.Location = new System.Drawing.Point(3, 171);
            this.tablesDD.Name = "tablesDD";
            this.tablesDD.Size = new System.Drawing.Size(448, 36);
            this.tablesDD.TabIndex = 5;
            this.tablesDD.SelectedIndexChanged += new System.EventHandler(this.tablesDD_SelectedIndexChanged);
            this.tablesDD.Enter += new System.EventHandler(this.tablesDD_Enter);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tableLabel.Location = new System.Drawing.Point(3, 140);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(64, 28);
            this.tableLabel.TabIndex = 4;
            this.tableLabel.Text = "Table:";
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
            this.totalAmountGV,
            this.snoGV,
            this.itemGV,
            this.quantGV,
            this.amountGV,
            this.orderIDGV});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(3, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(447, 223);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Tag = "";
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total";
            this.totalAmountGV.MinimumWidth = 8;
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            this.totalAmountGV.Visible = false;
            this.totalAmountGV.Width = 150;
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
            // itemGV
            // 
            this.itemGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemGV.HeaderText = "Item";
            this.itemGV.MinimumWidth = 8;
            this.itemGV.Name = "itemGV";
            this.itemGV.ReadOnly = true;
            // 
            // quantGV
            // 
            this.quantGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantGV.HeaderText = "Quantity";
            this.quantGV.MinimumWidth = 8;
            this.quantGV.Name = "quantGV";
            this.quantGV.ReadOnly = true;
            // 
            // amountGV
            // 
            this.amountGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.amountGV.DefaultCellStyle = dataGridViewCellStyle13;
            this.amountGV.HeaderText = "Amount";
            this.amountGV.MinimumWidth = 8;
            this.amountGV.Name = "amountGV";
            this.amountGV.ReadOnly = true;
            // 
            // orderIDGV
            // 
            this.orderIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderIDGV.HeaderText = "Order ID";
            this.orderIDGV.MinimumWidth = 8;
            this.orderIDGV.Name = "orderIDGV";
            this.orderIDGV.ReadOnly = true;
            this.orderIDGV.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(3, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Order ID:";
            // 
            // orderIDTxt
            // 
            this.orderIDTxt.Enabled = false;
            this.orderIDTxt.Location = new System.Drawing.Point(3, 309);
            this.orderIDTxt.Name = "orderIDTxt";
            this.orderIDTxt.Size = new System.Drawing.Size(448, 34);
            this.orderIDTxt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(3, 603);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(280, 54);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Bill:";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.billLabel, true);
            this.billLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.billLabel.Location = new System.Drawing.Point(289, 603);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(76, 54);
            this.billLabel.TabIndex = 10;
            this.billLabel.Text = "0.0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.orderTypeDD);
            this.flowLayoutPanel1.Controls.Add(this.floorLabel);
            this.flowLayoutPanel1.Controls.Add(this.floorDD);
            this.flowLayoutPanel1.Controls.Add(this.tableLabel);
            this.flowLayoutPanel1.Controls.Add(this.tablesDD);
            this.flowLayoutPanel1.Controls.Add(this.phoneLabel);
            this.flowLayoutPanel1.Controls.Add(this.phoneTxt);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.orderIDTxt);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.billLabel);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.amtPaidTxt);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.amtReturnedTxt);
            this.flowLayoutPanel1.Controls.Add(this.billBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(455, 884);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Order Type:";
            // 
            // orderTypeDD
            // 
            this.orderTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderTypeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderTypeDD.FormattingEnabled = true;
            this.orderTypeDD.Items.AddRange(new object[] {
            "Dine-In",
            "Take-Away",
            "Home-Delivery"});
            this.orderTypeDD.Location = new System.Drawing.Point(3, 31);
            this.orderTypeDD.Name = "orderTypeDD";
            this.orderTypeDD.Size = new System.Drawing.Size(448, 36);
            this.orderTypeDD.TabIndex = 17;
            this.orderTypeDD.SelectedIndexChanged += new System.EventHandler(this.orderTypeDD_SelectedIndexChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneLabel.Location = new System.Drawing.Point(3, 210);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(94, 28);
            this.phoneLabel.TabIndex = 18;
            this.phoneLabel.Text = "Phone #:";
            this.phoneLabel.Visible = false;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(3, 241);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(448, 34);
            this.phoneTxt.TabIndex = 19;
            this.phoneTxt.Visible = false;
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(3, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "Details:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(3, 657);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Amount Paid:";
            // 
            // amtPaidTxt
            // 
            this.amtPaidTxt.Location = new System.Drawing.Point(3, 688);
            this.amtPaidTxt.Name = "amtPaidTxt";
            this.amtPaidTxt.Size = new System.Drawing.Size(448, 34);
            this.amtPaidTxt.TabIndex = 13;
            this.amtPaidTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amtPaidTxt.TextChanged += new System.EventHandler(this.amtPaidTxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(3, 725);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount Returned:";
            // 
            // amtReturnedTxt
            // 
            this.amtReturnedTxt.Enabled = false;
            this.amtReturnedTxt.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amtReturnedTxt.Location = new System.Drawing.Point(3, 756);
            this.amtReturnedTxt.Name = "amtReturnedTxt";
            this.amtReturnedTxt.Size = new System.Drawing.Size(448, 39);
            this.amtReturnedTxt.TabIndex = 15;
            this.amtReturnedTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.billBtn.FlatAppearance.BorderSize = 2;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billBtn.ForeColor = System.Drawing.Color.White;
            this.billBtn.Location = new System.Drawing.Point(3, 801);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(449, 63);
            this.billBtn.TabIndex = 11;
            this.billBtn.Text = "Generate Bill";
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.taxDD);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 121);
            this.panel3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(4, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tax:";
            // 
            // taxDD
            // 
            this.taxDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taxDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taxDD.FormattingEnabled = true;
            this.taxDD.Items.AddRange(new object[] {
            "Inclusive",
            "Exclusive"});
            this.taxDD.Location = new System.Drawing.Point(4, 80);
            this.taxDD.Name = "taxDD";
            this.taxDD.Size = new System.Drawing.Size(448, 36);
            this.taxDD.TabIndex = 5;
            this.taxDD.SelectedIndexChanged += new System.EventHandler(this.taxDD_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 45);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(675, 1005);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = global::CRM_Bakalavr.Properties.Resources.Без_имени_21;
            this.backBtn.Location = new System.Drawing.Point(12, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 43);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // OrderCompletionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 1050);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "OrderCompletionWindow";
            this.Text = "Order Completion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderCompletionWindow_FormClosing);
            this.Load += new System.EventHandler(this.OrderCompletionWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox tablesDD;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.ComboBox floorDD;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderIDTxt;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox taxDD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amtPaidTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox amtReturnedTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox orderTypeDD;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTxt;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDGV;
    }
}