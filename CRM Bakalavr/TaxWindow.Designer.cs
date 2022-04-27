namespace CRM_Bakalavr
{
    partial class TaxWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.taxValueTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taxTypeDD = new System.Windows.Forms.ComboBox();
            this.detailsGbx = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.snoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxTypeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.detailsGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTxt.Size = new System.Drawing.Size(131, 34);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel6);
            this.leftPanel.Controls.Add(this.taxTypeDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.taxValueTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Size = new System.Drawing.Size(300, 694);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxValueTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.taxTypeDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel6, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.detailsGbx);
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Size = new System.Drawing.Size(838, 694);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            this.rightPanel.Controls.SetChildIndex(this.detailsGbx, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(3, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tax Amount (%)";
            // 
            // taxValueTxt
            // 
            this.taxValueTxt.Location = new System.Drawing.Point(6, 223);
            this.taxValueTxt.Name = "taxValueTxt";
            this.taxValueTxt.Size = new System.Drawing.Size(287, 34);
            this.taxValueTxt.TabIndex = 3;
            this.taxValueTxt.TextChanged += new System.EventHandler(this.taxValueTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type:";
            // 
            // taxTypeDD
            // 
            this.taxTypeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taxTypeDD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taxTypeDD.FormattingEnabled = true;
            this.taxTypeDD.Items.AddRange(new object[] {
            "Inclusive ",
            "Exclusive"});
            this.taxTypeDD.Location = new System.Drawing.Point(5, 312);
            this.taxTypeDD.Name = "taxTypeDD";
            this.taxTypeDD.Size = new System.Drawing.Size(286, 36);
            this.taxTypeDD.TabIndex = 5;
            this.taxTypeDD.SelectedIndexChanged += new System.EventHandler(this.taxTypeDD_SelectedIndexChanged);
            // 
            // detailsGbx
            // 
            this.detailsGbx.Controls.Add(this.dataGridView1);
            this.detailsGbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailsGbx.ForeColor = System.Drawing.Color.DimGray;
            this.detailsGbx.Location = new System.Drawing.Point(0, 163);
            this.detailsGbx.Name = "detailsGbx";
            this.detailsGbx.Size = new System.Drawing.Size(838, 531);
            this.detailsGbx.TabIndex = 7;
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
            this.taxTypeGV,
            this.valueGV,
            this.taxIDGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(832, 498);
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
            // taxTypeGV
            // 
            this.taxTypeGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taxTypeGV.HeaderText = "Tax Type";
            this.taxTypeGV.MinimumWidth = 8;
            this.taxTypeGV.Name = "taxTypeGV";
            this.taxTypeGV.ReadOnly = true;
            // 
            // valueGV
            // 
            this.valueGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueGV.HeaderText = "Value (%)";
            this.valueGV.MinimumWidth = 8;
            this.valueGV.Name = "valueGV";
            this.valueGV.ReadOnly = true;
            // 
            // taxIDGV
            // 
            this.taxIDGV.HeaderText = "Tax ID";
            this.taxIDGV.MinimumWidth = 8;
            this.taxIDGV.Name = "taxIDGV";
            this.taxIDGV.ReadOnly = true;
            this.taxIDGV.Visible = false;
            this.taxIDGV.Width = 150;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 51);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 129);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(838, 34);
            this.panel5.TabIndex = 10;
            // 
            // TaxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 694);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "TaxWindow";
            this.Text = "Tax";
            this.Load += new System.EventHandler(this.TaxWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.detailsGbx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox taxTypeDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox taxValueTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox detailsGbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxTypeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxIDGV;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
    }
}