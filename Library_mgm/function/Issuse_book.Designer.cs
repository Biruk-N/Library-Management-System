namespace Library_mgm
{
    partial class Issuse_book
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
            System.Windows.Forms.Label cn;
            System.Windows.Forms.Label cr;
            System.Windows.Forms.Label cc;
            System.Windows.Forms.Label bt;
            System.Windows.Forms.Label book_issue_dateLabel;
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.studentTableAdapter1 = new Library_mgm.library_management_systemDataSetTableAdapters.StudentTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bidi = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Button();
            this.issue = new System.Windows.Forms.Button();
            this.btt = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            this.ccon = new System.Windows.Forms.TextBox();
            this.crr = new System.Windows.Forms.TextBox();
            this.cna = new System.Windows.Forms.TextBox();
            this.ciid = new System.Windows.Forms.TextBox();
            this.library_management_systemDataSet7 = new Library_mgm.library_management_systemDataSet7();
            this.issue_bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issue_bookTableAdapter = new Library_mgm.library_management_systemDataSet7TableAdapters.Issue_bookTableAdapter();
            this.tableAdapterManager1 = new Library_mgm.library_management_systemDataSet7TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            cn = new System.Windows.Forms.Label();
            cr = new System.Windows.Forms.Label();
            cc = new System.Windows.Forms.Label();
            bt = new System.Windows.Forms.Label();
            book_issue_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cn
            // 
            cn.AutoSize = true;
            cn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            cn.Location = new System.Drawing.Point(449, 53);
            cn.Name = "cn";
            cn.Size = new System.Drawing.Size(126, 20);
            cn.TabIndex = 10;
            cn.Text = "Customer name:";
            // 
            // cr
            // 
            cr.AutoSize = true;
            cr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            cr.Location = new System.Drawing.Point(449, 97);
            cr.Name = "cr";
            cr.Size = new System.Drawing.Size(112, 20);
            cr.TabIndex = 12;
            cr.Text = "Customer role:";
            // 
            // cc
            // 
            cc.AutoSize = true;
            cc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            cc.Location = new System.Drawing.Point(449, 137);
            cc.Name = "cc";
            cc.Size = new System.Drawing.Size(139, 20);
            cc.TabIndex = 14;
            cc.Text = "Customer contact:";
            // 
            // bt
            // 
            bt.AutoSize = true;
            bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            bt.Location = new System.Drawing.Point(449, 230);
            bt.Name = "bt";
            bt.Size = new System.Drawing.Size(79, 20);
            bt.TabIndex = 16;
            bt.Text = "Book title:";
            // 
            // book_issue_dateLabel
            // 
            book_issue_dateLabel.AutoSize = true;
            book_issue_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_issue_dateLabel.Location = new System.Drawing.Point(449, 185);
            book_issue_dateLabel.Name = "book_issue_dateLabel";
            book_issue_dateLabel.Size = new System.Drawing.Size(127, 20);
            book_issue_dateLabel.TabIndex = 18;
            book_issue_dateLabel.Text = "Book issue date:";
            // 
            // library_management_systemDataSet
            // 
            this.library_management_systemDataSet.DataSetName = "library_management_systemDataSet";
            this.library_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.library_management_systemDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_bindingTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bidi);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(cn);
            this.panel1.Controls.Add(cr);
            this.panel1.Controls.Add(cc);
            this.panel1.Controls.Add(bt);
            this.panel1.Controls.Add(book_issue_dateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sc);
            this.panel1.Controls.Add(this.issue);
            this.panel1.Controls.Add(this.btt);
            this.panel1.Controls.Add(this.bid);
            this.panel1.Controls.Add(this.ccon);
            this.panel1.Controls.Add(this.crr);
            this.panel1.Controls.Add(this.cna);
            this.panel1.Controls.Add(this.ciid);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.panel1.Location = new System.Drawing.Point(33, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bidi
            // 
            this.bidi.Location = new System.Drawing.Point(69, 332);
            this.bidi.Name = "bidi";
            this.bidi.Size = new System.Drawing.Size(254, 26);
            this.bidi.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(592, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 84);
            this.listBox1.TabIndex = 19;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Customer Id";
            // 
            // sc
            // 
            this.sc.FlatAppearance.BorderSize = 0;
            this.sc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sc.Location = new System.Drawing.Point(48, 107);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(161, 34);
            this.sc.TabIndex = 1;
            this.sc.Text = "Search Customer";
            this.sc.UseVisualStyleBackColor = true;
            this.sc.Click += new System.EventHandler(this.sc_Click);
            // 
            // issue
            // 
            this.issue.FlatAppearance.BorderSize = 0;
            this.issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue.Location = new System.Drawing.Point(309, 364);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(161, 34);
            this.issue.TabIndex = 1;
            this.issue.Text = "Issue Book";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // btt
            // 
            this.btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btt.Location = new System.Drawing.Point(592, 224);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(254, 26);
            this.btt.TabIndex = 0;
            this.btt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btt_KeyDown);
            this.btt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btt_KeyUp);
            // 
            // bid
            // 
            this.bid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bid.Location = new System.Drawing.Point(592, 182);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(254, 26);
            this.bid.TabIndex = 0;
            // 
            // ccon
            // 
            this.ccon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ccon.Location = new System.Drawing.Point(592, 134);
            this.ccon.Name = "ccon";
            this.ccon.Size = new System.Drawing.Size(254, 26);
            this.ccon.TabIndex = 0;
            // 
            // crr
            // 
            this.crr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.crr.Location = new System.Drawing.Point(592, 97);
            this.crr.Name = "crr";
            this.crr.Size = new System.Drawing.Size(254, 26);
            this.crr.TabIndex = 0;
            // 
            // cna
            // 
            this.cna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cna.Location = new System.Drawing.Point(592, 53);
            this.cna.Name = "cna";
            this.cna.Size = new System.Drawing.Size(254, 26);
            this.cna.TabIndex = 0;
            // 
            // ciid
            // 
            this.ciid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ciid.Location = new System.Drawing.Point(44, 43);
            this.ciid.Name = "ciid";
            this.ciid.Size = new System.Drawing.Size(254, 26);
            this.ciid.TabIndex = 0;
            // 
            // library_management_systemDataSet7
            // 
            this.library_management_systemDataSet7.DataSetName = "library_management_systemDataSet7";
            this.library_management_systemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issue_bookBindingSource
            // 
            this.issue_bookBindingSource.DataMember = "Issue_book";
            this.issue_bookBindingSource.DataSource = this.library_management_systemDataSet7;
            // 
            // issue_bookTableAdapter
            // 
            this.issue_bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdmininformTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookTableAdapter = null;
            this.tableAdapterManager1.Culog_inTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = null;
            this.tableAdapterManager1.Issue_bookTableAdapter = this.issue_bookTableAdapter;
            this.tableAdapterManager1.Log_inTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_mgm.library_management_systemDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(639, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Issuse_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Issuse_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issuse_book";
            this.Load += new System.EventHandler(this.Issuse_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private library_management_systemDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.TextBox btt;
        private System.Windows.Forms.TextBox ccon;
        private System.Windows.Forms.TextBox crr;
        private System.Windows.Forms.TextBox cna;
        private System.Windows.Forms.TextBox ciid;
        private library_management_systemDataSet7 library_management_systemDataSet7;
        private System.Windows.Forms.BindingSource issue_bookBindingSource;
        private library_management_systemDataSet7TableAdapters.Issue_bookTableAdapter issue_bookTableAdapter;
        private library_management_systemDataSet7TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button sc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker bidi;
        private System.Windows.Forms.TextBox bid;
        private System.Windows.Forms.Button button1;

    }
}