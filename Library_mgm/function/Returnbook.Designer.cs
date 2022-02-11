namespace Library_mgm
{
    partial class Returnbook
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
            System.Windows.Forms.Label bt;
            System.Windows.Forms.Label book_issue_dateLabel;
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sc = new System.Windows.Forms.Button();
            this.issue = new System.Windows.Forms.Button();
            this.ciid = new System.Windows.Forms.TextBox();
            this.studentTableAdapter1 = new Library_mgm.library_management_systemDataSetTableAdapters.StudentTableAdapter();
            this.issue_bookTableAdapter = new Library_mgm.library_management_systemDataSet7TableAdapters.Issue_bookTableAdapter();
            this.library_management_systemDataSet7 = new Library_mgm.library_management_systemDataSet7();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.issue_bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.tableAdapterManager1 = new Library_mgm.library_management_systemDataSet7TableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btt = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            this.bidi = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            bt = new System.Windows.Forms.Label();
            book_issue_dateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sc);
            this.panel1.Controls.Add(this.ciid);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 616);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.sc.Location = new System.Drawing.Point(48, 97);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(161, 34);
            this.sc.TabIndex = 1;
            this.sc.Text = "Search Book";
            this.sc.UseVisualStyleBackColor = true;
            this.sc.Click += new System.EventHandler(this.sc_Click);
            // 
            // issue
            // 
            this.issue.FlatAppearance.BorderSize = 0;
            this.issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue.Location = new System.Drawing.Point(381, 161);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(161, 34);
            this.issue.TabIndex = 1;
            this.issue.Text = "Return Book";
            this.issue.UseVisualStyleBackColor = true;
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // ciid
            // 
            this.ciid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.ciid.ForeColor = System.Drawing.Color.White;
            this.ciid.Location = new System.Drawing.Point(44, 43);
            this.ciid.Name = "ciid";
            this.ciid.Size = new System.Drawing.Size(254, 26);
            this.ciid.TabIndex = 0;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // issue_bookTableAdapter
            // 
            this.issue_bookTableAdapter.ClearBeforeFill = true;
            // 
            // library_management_systemDataSet7
            // 
            this.library_management_systemDataSet7.DataSetName = "library_management_systemDataSet7";
            this.library_management_systemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // issue_bookBindingSource
            // 
            this.issue_bookBindingSource.DataMember = "Issue_book";
            this.issue_bookBindingSource.DataSource = this.library_management_systemDataSet7;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.library_management_systemDataSet;
            // 
            // library_management_systemDataSet
            // 
            this.library_management_systemDataSet.DataSetName = "library_management_systemDataSet";
            this.library_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(333, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 269);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bidi);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(bt);
            this.panel3.Controls.Add(book_issue_dateLabel);
            this.panel3.Controls.Add(this.issue);
            this.panel3.Controls.Add(this.btt);
            this.panel3.Controls.Add(this.bid);
            this.panel3.Location = new System.Drawing.Point(48, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 212);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // bt
            // 
            bt.AutoSize = true;
            bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            bt.Location = new System.Drawing.Point(10, 33);
            bt.Name = "bt";
            bt.Size = new System.Drawing.Size(79, 20);
            bt.TabIndex = 28;
            bt.Text = "Book title:";
            // 
            // book_issue_dateLabel
            // 
            book_issue_dateLabel.AutoSize = true;
            book_issue_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_issue_dateLabel.Location = new System.Drawing.Point(556, 27);
            book_issue_dateLabel.Name = "book_issue_dateLabel";
            book_issue_dateLabel.Size = new System.Drawing.Size(127, 20);
            book_issue_dateLabel.TabIndex = 29;
            book_issue_dateLabel.Text = "Book issue date:";
            // 
            // btt
            // 
            this.btt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btt.ForeColor = System.Drawing.Color.White;
            this.btt.Location = new System.Drawing.Point(153, 27);
            this.btt.Name = "btt";
            this.btt.Size = new System.Drawing.Size(275, 26);
            this.btt.TabIndex = 23;
            // 
            // bid
            // 
            this.bid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bid.ForeColor = System.Drawing.Color.White;
            this.bid.Location = new System.Drawing.Point(699, 24);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(254, 26);
            this.bid.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            label2.Location = new System.Drawing.Point(10, 98);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 20);
            label2.TabIndex = 31;
            label2.Text = "Select return date";
            // 
            // bidi
            // 
            this.bidi.Location = new System.Drawing.Point(153, 92);
            this.bidi.Name = "bidi";
            this.bidi.Size = new System.Drawing.Size(275, 26);
            this.bidi.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 670);
            this.Controls.Add(this.panel1);
            this.Name = "Returnbook";
            this.Text = "Returnbook";
            this.Load += new System.EventHandler(this.Returnbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issue_bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sc;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.TextBox ciid;
        private library_management_systemDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private library_management_systemDataSet7TableAdapters.Issue_bookTableAdapter issue_bookTableAdapter;
        private library_management_systemDataSet7 library_management_systemDataSet7;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource issue_bookBindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSet library_management_systemDataSet;
        private library_management_systemDataSet7TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox btt;
        private System.Windows.Forms.TextBox bid;
        private System.Windows.Forms.DateTimePicker bidi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}