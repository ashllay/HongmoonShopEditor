namespace HongmoonShop
{
    partial class SQL_Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnTestSQL = new System.Windows.Forms.Button();
            this.TxbSQLIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbSQLuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbSQLpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnTestSQL);
            this.groupBox1.Controls.Add(this.TxbSQLIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxbSQLuser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxbSQLpass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL";
            // 
            // BtnTestSQL
            // 
            this.BtnTestSQL.Location = new System.Drawing.Point(158, 16);
            this.BtnTestSQL.Name = "BtnTestSQL";
            this.BtnTestSQL.Size = new System.Drawing.Size(69, 74);
            this.BtnTestSQL.TabIndex = 9;
            this.BtnTestSQL.Text = "Test Connection";
            this.BtnTestSQL.UseVisualStyleBackColor = true;
            this.BtnTestSQL.Click += new System.EventHandler(this.BtnTestSQL_Click);
            // 
            // TxbSQLIP
            // 
            this.TxbSQLIP.Location = new System.Drawing.Point(52, 17);
            this.TxbSQLIP.Name = "TxbSQLIP";
            this.TxbSQLIP.Size = new System.Drawing.Size(100, 20);
            this.TxbSQLIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pass:";
            // 
            // TxbSQLuser
            // 
            this.TxbSQLuser.Location = new System.Drawing.Point(52, 43);
            this.TxbSQLuser.Name = "TxbSQLuser";
            this.TxbSQLuser.Size = new System.Drawing.Size(100, 20);
            this.TxbSQLuser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User:";
            // 
            // TxbSQLpass
            // 
            this.TxbSQLpass.Location = new System.Drawing.Point(52, 69);
            this.TxbSQLpass.Name = "TxbSQLpass";
            this.TxbSQLpass.PasswordChar = '*';
            this.TxbSQLpass.Size = new System.Drawing.Size(100, 20);
            this.TxbSQLpass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP:";
            // 
            // SQL_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 119);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SQL_Settings";
            this.Text = "SQL_Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQL_Settings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnTestSQL;
        private System.Windows.Forms.TextBox TxbSQLIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbSQLuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbSQLpass;
        private System.Windows.Forms.Label label1;
    }
}