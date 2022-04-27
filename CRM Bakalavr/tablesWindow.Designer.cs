namespace CRM_Bakalavr
{
    partial class tablesWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.chairsDD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.floorDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableNumberDD = new System.Windows.Forms.ComboBox();
            this.detailsGbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumberGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chairsGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(129, 34);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.tableNumberDD);
            this.leftPanel.Controls.Add(this.floorDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.chairsDD);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(300, 593);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.chairsDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.floorDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.tableNumberDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsGbx);
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Size = new System.Drawing.Size(846, 593);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            this.rightPanel.Controls.SetChildIndex(this.detailsGbx, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Table Number;";
            // 
            // chairsDD
            // 
            this.chairsDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chairsDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chairsDD.FormattingEnabled = true;
            this.chairsDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.chairsDD.Location = new System.Drawing.Point(14, 322);
            this.chairsDD.Name = "chairsDD";
            this.chairsDD.Size = new System.Drawing.Size(274, 36);
            this.chairsDD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Of Chairs";
            // 
            // floorDD
            // 
            this.floorDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floorDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.floorDD.FormattingEnabled = true;
            this.floorDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.floorDD.Location = new System.Drawing.Point(14, 415);
            this.floorDD.Name = "floorDD";
            this.floorDD.Size = new System.Drawing.Size(274, 36);
            this.floorDD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Floor Number:";
            // 
            // tableNumberDD
            // 
            this.tableNumberDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableNumberDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tableNumberDD.FormattingEnabled = true;
            this.tableNumberDD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.tableNumberDD.Location = new System.Drawing.Point(14, 231);
            this.tableNumberDD.Name = "tableNumberDD";
            this.tableNumberDD.Size = new System.Drawing.Size(274, 36);
            this.tableNumberDD.TabIndex = 10;
            // 
            // detailsGbx
            // 
            this.detailsGbx.Controls.Add(this.dataGridView1);
            this.detailsGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailsGbx.ForeColor = System.Drawing.Color.DimGray;
            this.detailsGbx.Location = new System.Drawing.Point(0, 163);
            this.detailsGbx.Name = "detailsGbx";
            this.detailsGbx.Size = new System.Drawing.Size(846, 430);
            this.detailsGbx.TabIndex = 8;
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
            this.floorIDGV,
            this.floorNameGV,
            this.tableidGV,
            this.TableNumberGV,
            this.chairsGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(840, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // snoGV
            // 
            this.snoGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.snoGV.HeaderText = "";
            this.snoGV.MinimumWidth = 8;
            this.snoGV.Name = "snoGV";
            this.snoGV.ReadOnly = true;
            this.snoGV.Width = 29;
            // 
            // floorIDGV
            // 
            this.floorIDGV.HeaderText = "floorID";
            this.floorIDGV.MinimumWidth = 8;
            this.floorIDGV.Name = "floorIDGV";
            this.floorIDGV.ReadOnly = true;
            this.floorIDGV.Visible = false;
            this.floorIDGV.Width = 150;
            // 
            // floorNameGV
            // 
            this.floorNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.floorNameGV.HeaderText = "Floor";
            this.floorNameGV.MinimumWidth = 8;
            this.floorNameGV.Name = "floorNameGV";
            this.floorNameGV.ReadOnly = true;
            // 
            // tableidGV
            // 
            this.tableidGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tableidGV.HeaderText = "TableID";
            this.tableidGV.MinimumWidth = 8;
            this.tableidGV.Name = "tableidGV";
            this.tableidGV.ReadOnly = true;
            this.tableidGV.Visible = false;
            // 
            // TableNumberGV
            // 
            this.TableNumberGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableNumberGV.HeaderText = "Table Number";
            this.TableNumberGV.MinimumWidth = 8;
            this.TableNumberGV.Name = "TableNumberGV";
            this.TableNumberGV.ReadOnly = true;
            // 
            // chairsGV
            // 
            this.chairsGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chairsGV.HeaderText = "Chairs";
            this.chairsGV.MinimumWidth = 8;
            this.chairsGV.Name = "chairsGV";
            this.chairsGV.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(846, 34);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 51);
            this.panel6.TabIndex = 13;
            // 
            // tablesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 593);
            this.Name = "tablesWindow";
            this.Text = "Tables";
            this.Load += new System.EventHandler(this.tablesWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tableNumberDD;
        private System.Windows.Forms.ComboBox floorDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chairsDD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox detailsGbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableidGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumberGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn chairsGV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}