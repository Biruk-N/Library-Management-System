namespace Library_mgm
{
    partial class Add_book
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
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label book_titleLabel;
            System.Windows.Forms.Label book_LanguageLabel;
            System.Windows.Forms.Label publication_yearLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label purchase_dateLabel;
            System.Windows.Forms.Label book_priceLabel;
            System.Windows.Forms.Label book_quantityLabel;
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.ad = new System.Windows.Forms.Button();
            this.bq = new System.Windows.Forms.TextBox();
            this.bpri = new System.Windows.Forms.TextBox();
            this.au = new System.Windows.Forms.TextBox();
            this.bl = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            this.library_management_systemDataSet3 = new Library_mgm.library_management_systemDataSet3();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter1 = new Library_mgm.library_management_systemDataSet3TableAdapters.BookTableAdapter();
            this.tableAdapterManager1 = new Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager();
            this.pdaa = new System.Windows.Forms.DateTimePicker();
            this.pda = new System.Windows.Forms.TextBox();
            book_idLabel = new System.Windows.Forms.Label();
            book_titleLabel = new System.Windows.Forms.Label();
            book_LanguageLabel = new System.Windows.Forms.Label();
            publication_yearLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            purchase_dateLabel = new System.Windows.Forms.Label();
            book_priceLabel = new System.Windows.Forms.Label();
            book_quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_idLabel.Location = new System.Drawing.Point(91, 68);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(66, 20);
            book_idLabel.TabIndex = 0;
            book_idLabel.Text = "Book id:";
            // 
            // book_titleLabel
            // 
            book_titleLabel.AutoSize = true;
            book_titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_titleLabel.Location = new System.Drawing.Point(91, 100);
            book_titleLabel.Name = "book_titleLabel";
            book_titleLabel.Size = new System.Drawing.Size(79, 20);
            book_titleLabel.TabIndex = 2;
            book_titleLabel.Text = "Book title:";
            // 
            // book_LanguageLabel
            // 
            book_LanguageLabel.AutoSize = true;
            book_LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_LanguageLabel.Location = new System.Drawing.Point(91, 132);
            book_LanguageLabel.Name = "book_LanguageLabel";
            book_LanguageLabel.Size = new System.Drawing.Size(126, 20);
            book_LanguageLabel.TabIndex = 4;
            book_LanguageLabel.Text = "Book Language:";
            // 
            // publication_yearLabel
            // 
            publication_yearLabel.AutoSize = true;
            publication_yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            publication_yearLabel.Location = new System.Drawing.Point(91, 164);
            publication_yearLabel.Name = "publication_yearLabel";
            publication_yearLabel.Size = new System.Drawing.Size(124, 20);
            publication_yearLabel.TabIndex = 6;
            publication_yearLabel.Text = "Publication year:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            authorLabel.Location = new System.Drawing.Point(91, 202);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(61, 20);
            authorLabel.TabIndex = 10;
            authorLabel.Text = "Author:";
            // 
            // purchase_dateLabel
            // 
            purchase_dateLabel.AutoSize = true;
            purchase_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            purchase_dateLabel.Location = new System.Drawing.Point(91, 233);
            purchase_dateLabel.Name = "purchase_dateLabel";
            purchase_dateLabel.Size = new System.Drawing.Size(116, 20);
            purchase_dateLabel.TabIndex = 35;
            purchase_dateLabel.Text = "Purchase date:";
            // 
            // book_priceLabel
            // 
            book_priceLabel.AutoSize = true;
            book_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_priceLabel.Location = new System.Drawing.Point(91, 266);
            book_priceLabel.Name = "book_priceLabel";
            book_priceLabel.Size = new System.Drawing.Size(88, 20);
            book_priceLabel.TabIndex = 37;
            book_priceLabel.Text = "Book price:";
            // 
            // book_quantityLabel
            // 
            book_quantityLabel.AutoSize = true;
            book_quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_quantityLabel.Location = new System.Drawing.Point(91, 298);
            book_quantityLabel.Name = "book_quantityLabel";
            book_quantityLabel.Size = new System.Drawing.Size(110, 20);
            book_quantityLabel.TabIndex = 39;
            book_quantityLabel.Text = "Book quantity:";
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
            // ad
            // 
            this.ad.FlatAppearance.BorderSize = 0;
            this.ad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.ad.Location = new System.Drawing.Point(261, 374);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(266, 33);
            this.ad.TabIndex = 25;
            this.ad.Text = "Save book";
            this.ad.UseVisualStyleBackColor = true;
            this.ad.Click += new System.EventHandler(this.ad_Click);
            // 
            // bq
            // 
            this.bq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bq.Location = new System.Drawing.Point(226, 292);
            this.bq.Name = "bq";
            this.bq.Size = new System.Drawing.Size(453, 26);
            this.bq.TabIndex = 21;
            this.bq.TextChanged += new System.EventHandler(this.cid_TextChanged);
            // 
            // bpri
            // 
            this.bpri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bpri.Location = new System.Drawing.Point(226, 260);
            this.bpri.Name = "bpri";
            this.bpri.Size = new System.Drawing.Size(453, 26);
            this.bpri.TabIndex = 24;
            this.bpri.TextChanged += new System.EventHandler(this.sid_TextChanged);
            // 
            // au
            // 
            this.au.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.au.Location = new System.Drawing.Point(226, 196);
            this.au.Name = "au";
            this.au.Size = new System.Drawing.Size(453, 26);
            this.au.TabIndex = 23;
            this.au.TextChanged += new System.EventHandler(this.au_TextChanged);
            // 
            // bl
            // 
            this.bl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bl.Location = new System.Drawing.Point(226, 129);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(453, 26);
            this.bl.TabIndex = 17;
            this.bl.TextChanged += new System.EventHandler(this.bl_TextChanged);
            // 
            // py
            // 
            this.py.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.py.Location = new System.Drawing.Point(226, 164);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(453, 26);
            this.py.TabIndex = 20;
            this.py.TextChanged += new System.EventHandler(this.py_TextChanged);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bt.Location = new System.Drawing.Point(226, 97);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(453, 26);
            this.bt.TabIndex = 19;
            this.bt.TextChanged += new System.EventHandler(this.bt_TextChanged);
            // 
            // bid
            // 
            this.bid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bid.Location = new System.Drawing.Point(226, 68);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(453, 26);
            this.bid.TabIndex = 18;
            this.bid.TextChanged += new System.EventHandler(this.bid_TextChanged);
            // 
            // library_management_systemDataSet3
            // 
            this.library_management_systemDataSet3.DataSetName = "library_management_systemDataSet3";
            this.library_management_systemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "Book";
            this.bookBindingSource1.DataSource = this.library_management_systemDataSet3;
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookTableAdapter = this.bookTableAdapter1;
            this.tableAdapterManager1.Culog_inTableAdapter = null;
            this.tableAdapterManager1.Log_inTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pdaa
            // 
            this.pdaa.CustomFormat = "yyyy/MM/dd";
            this.pdaa.Location = new System.Drawing.Point(136, 432);
            this.pdaa.Name = "pdaa";
            this.pdaa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pdaa.Size = new System.Drawing.Size(453, 26);
            this.pdaa.TabIndex = 40;
            this.pdaa.ValueChanged += new System.EventHandler(this.pda_ValueChanged);
            // 
            // pda
            // 
            this.pda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.pda.Location = new System.Drawing.Point(226, 230);
            this.pda.Name = "pda";
            this.pda.Size = new System.Drawing.Size(453, 26);
            this.pda.TabIndex = 24;
            this.pda.TextChanged += new System.EventHandler(this.sid_TextChanged);
            // 
            // Add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(753, 525);
            this.Controls.Add(this.pdaa);
            this.Controls.Add(purchase_dateLabel);
            this.Controls.Add(book_priceLabel);
            this.Controls.Add(book_quantityLabel);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.bq);
            this.Controls.Add(this.pda);
            this.Controls.Add(this.bpri);
            this.Controls.Add(this.au);
            this.Controls.Add(this.bl);
            this.Controls.Add(this.py);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.bid);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(book_titleLabel);
            this.Controls.Add(book_LanguageLabel);
            this.Controls.Add(publication_yearLabel);
            this.Controls.Add(authorLabel);
            this.Name = "Add_book";
            this.Text = "Add_book";
            this.Load += new System.EventHandler(this.Add_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button ad;
        private System.Windows.Forms.TextBox bq;
        private System.Windows.Forms.TextBox bpri;
        private System.Windows.Forms.TextBox au;
        private System.Windows.Forms.TextBox bl;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.TextBox bt;
        private System.Windows.Forms.TextBox bid;
        private library_management_systemDataSet3 library_management_systemDataSet3;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private library_management_systemDataSet3TableAdapters.BookTableAdapter bookTableAdapter1;
        private library_management_systemDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DateTimePicker pdaa;
        private System.Windows.Forms.TextBox pda;
    }
}