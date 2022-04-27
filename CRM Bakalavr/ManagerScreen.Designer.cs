
namespace CRM_Bakalavr
{
    partial class ManagerScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customersBtn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.ordersBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.modBtn = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(300, 684);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(865, 684);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.customersBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoriesBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menuBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ordersBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.billBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.modBtn, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 639);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // customersBtn
            // 
            this.customersBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersBtn.FlatAppearance.BorderSize = 2;
            this.customersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersBtn.ForeColor = System.Drawing.Color.Black;
            this.customersBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_вкусно_100;
            this.customersBtn.Location = new System.Drawing.Point(3, 3);
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(282, 207);
            this.customersBtn.TabIndex = 3;
            this.customersBtn.Text = "Customers";
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customersBtn.UseVisualStyleBackColor = false;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesBtn.FlatAppearance.BorderSize = 2;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoriesBtn.ForeColor = System.Drawing.Color.Black;
            this.categoriesBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_рыба_и_овощи_100;
            this.categoriesBtn.Location = new System.Drawing.Point(291, 3);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(282, 207);
            this.categoriesBtn.TabIndex = 4;
            this.categoriesBtn.Text = "Food Categories";
            this.categoriesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBtn.FlatAppearance.BorderSize = 2;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuBtn.ForeColor = System.Drawing.Color.Black;
            this.menuBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_меню_ресторана_100;
            this.menuBtn.Location = new System.Drawing.Point(579, 3);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(283, 207);
            this.menuBtn.TabIndex = 5;
            this.menuBtn.Text = "Food Menu";
            this.menuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // ordersBtn
            // 
            this.ordersBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ordersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersBtn.FlatAppearance.BorderSize = 2;
            this.ordersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersBtn.ForeColor = System.Drawing.Color.Black;
            this.ordersBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_столик_в_ресторане_100;
            this.ordersBtn.Location = new System.Drawing.Point(3, 216);
            this.ordersBtn.Name = "ordersBtn";
            this.ordersBtn.Size = new System.Drawing.Size(282, 207);
            this.ordersBtn.TabIndex = 7;
            this.ordersBtn.Text = "Orders";
            this.ordersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ordersBtn.UseVisualStyleBackColor = false;
            this.ordersBtn.Click += new System.EventHandler(this.ordersBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.billBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.billBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billBtn.FlatAppearance.BorderSize = 2;
            this.billBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.billBtn.ForeColor = System.Drawing.Color.Black;
            this.billBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_оплаченный_счет_100;
            this.billBtn.Location = new System.Drawing.Point(291, 216);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(282, 207);
            this.billBtn.TabIndex = 9;
            this.billBtn.Text = "Bill Generation";
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modBtn.FlatAppearance.BorderSize = 2;
            this.modBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modBtn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modBtn.ForeColor = System.Drawing.Color.Black;
            this.modBtn.Image = global::CRM_Bakalavr.Properties.Resources.icons8_бронирование_2_100__1_;
            this.modBtn.Location = new System.Drawing.Point(579, 216);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(283, 207);
            this.modBtn.TabIndex = 11;
            this.modBtn.Text = "Order Modification";
            this.modBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 2;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(579, 429);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(283, 207);
            this.button14.TabIndex = 14;
            this.button14.Text = "...";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(291, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 207);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 207);
            this.button2.TabIndex = 16;
            this.button2.Text = "...";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 684);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreen";
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button customersBtn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button ordersBtn;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button modBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button14;
    }
}