namespace CRM_Bakalavr
{
    partial class Settings
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
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serverErrorLabel = new System.Windows.Forms.Label();
            this.dbErrorLabel = new System.Windows.Forms.Label();
            this.userErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.serverErrorLabel);
            this.leftPanel.Controls.Add(this.passErrorLabel);
            this.leftPanel.Controls.Add(this.userErrorLabel);
            this.leftPanel.Controls.Add(this.dbErrorLabel);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Size = new System.Drawing.Size(300, 603);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.dbErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.userErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.passErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(750, 603);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // serverTxt
            // 
            this.serverTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.serverTxt.Location = new System.Drawing.Point(17, 164);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(265, 34);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.TextChanged += new System.EventHandler(this.serverTxt_TextChanged);
            // 
            // databaseTxt
            // 
            this.databaseTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.databaseTxt.Location = new System.Drawing.Point(17, 239);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(265, 34);
            this.databaseTxt.TabIndex = 4;
            this.databaseTxt.TextChanged += new System.EventHandler(this.databaseTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // userTxt
            // 
            this.userTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.userTxt.Location = new System.Drawing.Point(17, 312);
            this.userTxt.MaxLength = 50;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(265, 34);
            this.userTxt.TabIndex = 6;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "User ID";
            // 
            // passTxt
            // 
            this.passTxt.ForeColor = System.Drawing.Color.RoyalBlue;
            this.passTxt.Location = new System.Drawing.Point(17, 386);
            this.passTxt.MaxLength = 50;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(265, 34);
            this.passTxt.TabIndex = 8;
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isCB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.isCB.Location = new System.Drawing.Point(17, 433);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(166, 32);
            this.isCB.TabIndex = 9;
            this.isCB.Text = "Allow Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.saveBtn.Location = new System.Drawing.Point(17, 479);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(265, 42);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serverErrorLabel
            // 
            this.serverErrorLabel.AutoSize = true;
            this.serverErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serverErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.serverErrorLabel.Location = new System.Drawing.Point(253, 133);
            this.serverErrorLabel.Name = "serverErrorLabel";
            this.serverErrorLabel.Size = new System.Drawing.Size(29, 38);
            this.serverErrorLabel.TabIndex = 11;
            this.serverErrorLabel.Text = "*";
            this.serverErrorLabel.Visible = false;
            // 
            // dbErrorLabel
            // 
            this.dbErrorLabel.AutoSize = true;
            this.dbErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dbErrorLabel.Location = new System.Drawing.Point(253, 201);
            this.dbErrorLabel.Name = "dbErrorLabel";
            this.dbErrorLabel.Size = new System.Drawing.Size(29, 38);
            this.dbErrorLabel.TabIndex = 12;
            this.dbErrorLabel.Text = "*";
            this.dbErrorLabel.Visible = false;
            // 
            // userErrorLabel
            // 
            this.userErrorLabel.AutoSize = true;
            this.userErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.userErrorLabel.Location = new System.Drawing.Point(253, 281);
            this.userErrorLabel.Name = "userErrorLabel";
            this.userErrorLabel.Size = new System.Drawing.Size(29, 38);
            this.userErrorLabel.TabIndex = 13;
            this.userErrorLabel.Text = "*";
            this.userErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passErrorLabel.Location = new System.Drawing.Point(253, 356);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(29, 38);
            this.passErrorLabel.TabIndex = 14;
            this.passErrorLabel.Text = "*";
            this.passErrorLabel.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 603);
            this.Name = "Settings";
            this.Text = "Database Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label serverErrorLabel;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.Label userErrorLabel;
        private System.Windows.Forms.Label dbErrorLabel;
    }
}