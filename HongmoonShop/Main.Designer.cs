namespace HongmoonShop
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CboxItemList = new System.Windows.Forms.ComboBox();
            this.TxbItemUpdateName = new System.Windows.Forms.TextBox();
            this.TxbUpdatePrice = new System.Windows.Forms.TextBox();
            this.BtnLoadItems = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GboxMain = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.GboxMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CboxItemList
            // 
            this.CboxItemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxItemList.Enabled = false;
            this.CboxItemList.FormattingEnabled = true;
            this.CboxItemList.Location = new System.Drawing.Point(47, 13);
            this.CboxItemList.Name = "CboxItemList";
            this.CboxItemList.Size = new System.Drawing.Size(203, 21);
            this.CboxItemList.TabIndex = 1;
            this.CboxItemList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxbItemUpdateName
            // 
            this.TxbItemUpdateName.Enabled = false;
            this.TxbItemUpdateName.Location = new System.Drawing.Point(47, 40);
            this.TxbItemUpdateName.Name = "TxbItemUpdateName";
            this.TxbItemUpdateName.Size = new System.Drawing.Size(203, 20);
            this.TxbItemUpdateName.TabIndex = 2;
            // 
            // TxbUpdatePrice
            // 
            this.TxbUpdatePrice.Enabled = false;
            this.TxbUpdatePrice.Location = new System.Drawing.Point(47, 66);
            this.TxbUpdatePrice.Name = "TxbUpdatePrice";
            this.TxbUpdatePrice.Size = new System.Drawing.Size(203, 20);
            this.TxbUpdatePrice.TabIndex = 3;
            // 
            // BtnLoadItems
            // 
            this.BtnLoadItems.Location = new System.Drawing.Point(256, 13);
            this.BtnLoadItems.Name = "BtnLoadItems";
            this.BtnLoadItems.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadItems.TabIndex = 4;
            this.BtnLoadItems.Text = "Load";
            this.BtnLoadItems.UseVisualStyleBackColor = true;
            this.BtnLoadItems.Click += new System.EventHandler(this.BtnLoadItems_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(256, 40);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 46);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLSettingsToolStripMenuItem,
            this.connectToSQLServerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // sQLSettingsToolStripMenuItem
            // 
            this.sQLSettingsToolStripMenuItem.Name = "sQLSettingsToolStripMenuItem";
            this.sQLSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sQLSettingsToolStripMenuItem.Text = "SQL Settings";
            this.sQLSettingsToolStripMenuItem.Click += new System.EventHandler(this.sQLSettingsToolStripMenuItem_Click);
            // 
            // connectToSQLServerToolStripMenuItem
            // 
            this.connectToSQLServerToolStripMenuItem.Name = "connectToSQLServerToolStripMenuItem";
            this.connectToSQLServerToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.connectToSQLServerToolStripMenuItem.Text = "Connect to SQL-Server";
            this.connectToSQLServerToolStripMenuItem.Click += new System.EventHandler(this.connectToSQLServerToolStripMenuItem_Click);
            // 
            // GboxMain
            // 
            this.GboxMain.Controls.Add(this.label1);
            this.GboxMain.Controls.Add(this.label3);
            this.GboxMain.Controls.Add(this.CboxItemList);
            this.GboxMain.Controls.Add(this.label2);
            this.GboxMain.Controls.Add(this.TxbItemUpdateName);
            this.GboxMain.Controls.Add(this.TxbUpdatePrice);
            this.GboxMain.Controls.Add(this.BtnSave);
            this.GboxMain.Controls.Add(this.BtnLoadItems);
            this.GboxMain.Enabled = false;
            this.GboxMain.Location = new System.Drawing.Point(12, 27);
            this.GboxMain.Name = "GboxMain";
            this.GboxMain.Size = new System.Drawing.Size(341, 97);
            this.GboxMain.TabIndex = 9;
            this.GboxMain.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 135);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(362, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StsStatusLabel
            // 
            this.StsStatusLabel.Name = "StsStatusLabel";
            this.StsStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 157);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GboxMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Hongmoon Shop Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GboxMain.ResumeLayout(false);
            this.GboxMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToSQLServerToolStripMenuItem;
        private System.Windows.Forms.ComboBox CboxItemList;
        private System.Windows.Forms.TextBox TxbItemUpdateName;
        private System.Windows.Forms.TextBox TxbUpdatePrice;
        private System.Windows.Forms.Button BtnLoadItems;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GboxMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StsStatusLabel;
    }
}

