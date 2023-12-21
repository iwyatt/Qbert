namespace Qbert
{
    partial class QbertMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QbertMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatPhoneNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enforceFieldLengthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDuplicateEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBlankRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postToEloquaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaddgv = new System.Windows.Forms.DataGridView();
            this.leadbs = new System.Windows.Forms.BindingSource(this.components);
            this.leadds = new System.Data.DataSet();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.elqtext5 = new System.Windows.Forms.TextBox();
            this.elqField5 = new System.Windows.Forms.Label();
            this.elqtext4 = new System.Windows.Forms.TextBox();
            this.elqField4 = new System.Windows.Forms.Label();
            this.elqtext1 = new System.Windows.Forms.TextBox();
            this.elqtext3 = new System.Windows.Forms.TextBox();
            this.elqField1 = new System.Windows.Forms.Label();
            this.elqField3 = new System.Windows.Forms.Label();
            this.elqbox1 = new System.Windows.Forms.CheckBox();
            this.elqField6 = new System.Windows.Forms.Label();
            this.elqtext2 = new System.Windows.Forms.TextBox();
            this.elqField2 = new System.Windows.Forms.Label();
            this.dgcontext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fixAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaddgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadds)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.dgcontext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixAllToolStripMenuItem,
            this.formatPhoneNumbersToolStripMenuItem,
            this.enforceFieldLengthsToolStripMenuItem,
            this.findDuplicateEmailsToolStripMenuItem,
            this.removeBlankRowsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fixAllToolStripMenuItem
            // 
            this.fixAllToolStripMenuItem.Name = "fixAllToolStripMenuItem";
            this.fixAllToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.fixAllToolStripMenuItem.Text = "Fix All";
            this.fixAllToolStripMenuItem.Click += new System.EventHandler(this.fixAllToolStripMenuItem_Click);
            // 
            // formatPhoneNumbersToolStripMenuItem
            // 
            this.formatPhoneNumbersToolStripMenuItem.Name = "formatPhoneNumbersToolStripMenuItem";
            this.formatPhoneNumbersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.formatPhoneNumbersToolStripMenuItem.Text = "Format Phone Numbers";
            this.formatPhoneNumbersToolStripMenuItem.Click += new System.EventHandler(this.formatPhoneNumbersToolStripMenuItem_Click);
            // 
            // enforceFieldLengthsToolStripMenuItem
            // 
            this.enforceFieldLengthsToolStripMenuItem.Name = "enforceFieldLengthsToolStripMenuItem";
            this.enforceFieldLengthsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.enforceFieldLengthsToolStripMenuItem.Text = "Enforce Field Lengths";
            this.enforceFieldLengthsToolStripMenuItem.Click += new System.EventHandler(this.enforceFieldLengthsToolStripMenuItem_Click);
            // 
            // findDuplicateEmailsToolStripMenuItem
            // 
            this.findDuplicateEmailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.findDuplicateEmailsToolStripMenuItem.Name = "findDuplicateEmailsToolStripMenuItem";
            this.findDuplicateEmailsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.findDuplicateEmailsToolStripMenuItem.Text = "Duplicates";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // removeBlankRowsToolStripMenuItem
            // 
            this.removeBlankRowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsToolStripMenuItem});
            this.removeBlankRowsToolStripMenuItem.Name = "removeBlankRowsToolStripMenuItem";
            this.removeBlankRowsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.removeBlankRowsToolStripMenuItem.Text = "Remove Blank";
            // 
            // rowsToolStripMenuItem
            // 
            this.rowsToolStripMenuItem.Name = "rowsToolStripMenuItem";
            this.rowsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rowsToolStripMenuItem.Text = "Rows";
            this.rowsToolStripMenuItem.Click += new System.EventHandler(this.rowsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postToEloquaToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // postToEloquaToolStripMenuItem
            // 
            this.postToEloquaToolStripMenuItem.Name = "postToEloquaToolStripMenuItem";
            this.postToEloquaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.postToEloquaToolStripMenuItem.Text = "Post to Eloqua";
            this.postToEloquaToolStripMenuItem.Click += new System.EventHandler(this.postToEloquaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.leaddgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 417);
            this.panel1.TabIndex = 2;
            // 
            // leaddgv
            // 
            this.leaddgv.AllowUserToOrderColumns = true;
            this.leaddgv.AutoGenerateColumns = false;
            this.leaddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaddgv.DataSource = this.leadbs;
            this.leaddgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leaddgv.Location = new System.Drawing.Point(0, 0);
            this.leaddgv.Name = "leaddgv";
            this.leaddgv.Size = new System.Drawing.Size(778, 417);
            this.leaddgv.TabIndex = 0;
            // 
            // leadbs
            // 
            this.leadbs.DataSource = this.leadds;
            this.leadbs.Position = 0;
            // 
            // leadds
            // 
            this.leadds.DataSetName = "leadds";
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "csv";
            this.ofd.FileName = "*.csv";
            this.ofd.Filter = "CSV fiiles|*.csv";
            this.ofd.ReadOnlyChecked = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 449);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LeadData";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Uniform Values";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.elqtext5);
            this.groupBox3.Controls.Add(this.elqField5);
            this.groupBox3.Controls.Add(this.elqtext4);
            this.groupBox3.Controls.Add(this.elqField4);
            this.groupBox3.Controls.Add(this.elqtext1);
            this.groupBox3.Controls.Add(this.elqtext3);
            this.groupBox3.Controls.Add(this.elqField1);
            this.groupBox3.Controls.Add(this.elqField3);
            this.groupBox3.Controls.Add(this.elqbox1);
            this.groupBox3.Controls.Add(this.elqField6);
            this.groupBox3.Controls.Add(this.elqtext2);
            this.groupBox3.Controls.Add(this.elqField2);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 377);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hidden System Field Values";
            // 
            // elqtext5
            // 
            this.elqtext5.Location = new System.Drawing.Point(108, 19);
            this.elqtext5.Name = "elqtext5";
            this.elqtext5.Size = new System.Drawing.Size(163, 20);
            this.elqtext5.TabIndex = 18;
            this.elqtext5.Text = "http://now.eloqua.com/e/f2.aspx";
            // 
            // elqField5
            // 
            this.elqField5.AutoSize = true;
            this.elqField5.Location = new System.Drawing.Point(6, 22);
            this.elqField5.Name = "elqField5";
            this.elqField5.Size = new System.Drawing.Size(89, 13);
            this.elqField5.TabIndex = 17;
            this.elqField5.Text = "Eloqua Post URL";
            // 
            // elqtext4
            // 
            this.elqtext4.Location = new System.Drawing.Point(108, 97);
            this.elqtext4.Name = "elqtext4";
            this.elqtext4.Size = new System.Drawing.Size(163, 20);
            this.elqtext4.TabIndex = 16;
            this.elqtext4.Text = "email sent";
            // 
            // elqField4
            // 
            this.elqField4.AutoSize = true;
            this.elqField4.Location = new System.Drawing.Point(6, 100);
            this.elqField4.Name = "elqField4";
            this.elqField4.Size = new System.Drawing.Size(88, 13);
            this.elqField4.TabIndex = 15;
            this.elqField4.Text = "email_notification";
            // 
            // elqtext1
            // 
            this.elqtext1.Location = new System.Drawing.Point(108, 145);
            this.elqtext1.Name = "elqtext1";
            this.elqtext1.Size = new System.Drawing.Size(163, 20);
            this.elqtext1.TabIndex = 0;
            this.elqtext1.Text = "00-CPL-Campaigns";
            // 
            // elqtext3
            // 
            this.elqtext3.Location = new System.Drawing.Point(108, 45);
            this.elqtext3.Name = "elqtext3";
            this.elqtext3.Size = new System.Drawing.Size(163, 20);
            this.elqtext3.TabIndex = 14;
            this.elqtext3.Text = "00D000000000aaa";
            // 
            // elqField1
            // 
            this.elqField1.AutoSize = true;
            this.elqField1.Location = new System.Drawing.Point(6, 148);
            this.elqField1.Name = "elqField1";
            this.elqField1.Size = new System.Drawing.Size(72, 13);
            this.elqField1.TabIndex = 1;
            this.elqField1.Text = "elqFormName";
            // 
            // elqField3
            // 
            this.elqField3.AutoSize = true;
            this.elqField3.Location = new System.Drawing.Point(6, 48);
            this.elqField3.Name = "elqField3";
            this.elqField3.Size = new System.Drawing.Size(21, 13);
            this.elqField3.TabIndex = 13;
            this.elqField3.Text = "oid";
            // 
            // elqbox1
            // 
            this.elqbox1.AutoSize = true;
            this.elqbox1.Checked = true;
            this.elqbox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.elqbox1.Location = new System.Drawing.Point(108, 123);
            this.elqbox1.Name = "elqbox1";
            this.elqbox1.Size = new System.Drawing.Size(15, 14);
            this.elqbox1.TabIndex = 12;
            this.elqbox1.UseVisualStyleBackColor = true;
            // 
            // elqField6
            // 
            this.elqField6.AutoSize = true;
            this.elqField6.Location = new System.Drawing.Point(6, 124);
            this.elqField6.Name = "elqField6";
            this.elqField6.Size = new System.Drawing.Size(93, 13);
            this.elqField6.TabIndex = 4;
            this.elqField6.Text = "RL_EloquaTrigger";
            // 
            // elqtext2
            // 
            this.elqtext2.Location = new System.Drawing.Point(108, 71);
            this.elqtext2.Name = "elqtext2";
            this.elqtext2.Size = new System.Drawing.Size(163, 20);
            this.elqtext2.TabIndex = 3;
            this.elqtext2.Text = "607";
            // 
            // elqField2
            // 
            this.elqField2.AutoSize = true;
            this.elqField2.Location = new System.Drawing.Point(6, 74);
            this.elqField2.Name = "elqField2";
            this.elqField2.Size = new System.Drawing.Size(50, 13);
            this.elqField2.TabIndex = 2;
            this.elqField2.Text = "elqSiteID";
            // 
            // dgcontext
            // 
            this.dgcontext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixAllToolStripMenuItem1});
            this.dgcontext.Name = "contextMenuStrip1";
            this.dgcontext.ShowImageMargin = false;
            this.dgcontext.Size = new System.Drawing.Size(81, 26);
            // 
            // fixAllToolStripMenuItem1
            // 
            this.fixAllToolStripMenuItem1.Name = "fixAllToolStripMenuItem1";
            this.fixAllToolStripMenuItem1.Size = new System.Drawing.Size(80, 22);
            this.fixAllToolStripMenuItem1.Text = "Fix All";
            this.fixAllToolStripMenuItem1.Click += new System.EventHandler(this.fixAllToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // QbertMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "QbertMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Qbert";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leaddgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadds)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.dgcontext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Data.DataSet leadds;
        public System.Windows.Forms.BindingSource leadbs;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToEloquaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDuplicateEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enforceFieldLengthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatPhoneNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridView leaddgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem removeBlankRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rowsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox elqtext5;
        private System.Windows.Forms.Label elqField5;
        private System.Windows.Forms.TextBox elqtext4;
        private System.Windows.Forms.Label elqField4;
        private System.Windows.Forms.TextBox elqtext3;
        private System.Windows.Forms.Label elqField3;
        private System.Windows.Forms.CheckBox elqbox1;
        private System.Windows.Forms.Label elqField6;
        private System.Windows.Forms.TextBox elqtext2;
        private System.Windows.Forms.Label elqField2;
        private System.Windows.Forms.Label elqField1;
        private System.Windows.Forms.TextBox elqtext1;
        private System.Windows.Forms.ContextMenuStrip dgcontext;
        private System.Windows.Forms.ToolStripMenuItem fixAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

