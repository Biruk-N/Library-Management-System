namespace Library_mgm
{
    partial class update_Book
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
            this.back = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.library_management_systemDataSet3 = new Library_mgm.library_management_systemDataSet3();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSet3TableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager();
            this.bq = new System.Windows.Forms.TextBox();
            this.pda = new System.Windows.Forms.TextBox();
            this.bpri = new System.Windows.Forms.TextBox();
            this.au = new System.Windows.Forms.TextBox();
            this.bl = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.TextBox();
            this.bt = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            book_idLabel = new System.Windows.Forms.Label();
            book_titleLabel = new System.Windows.Forms.Label();
            book_LanguageLabel = new System.Windows.Forms.Label();
            publication_yearLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            purchase_dateLabel = new System.Windows.Forms.Label();
            book_priceLabel = new System.Windows.Forms.Label();
            book_quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_idLabel.Location = new System.Drawing.Point(35, 35);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(66, 20);
            book_idLabel.TabIndex = 33;
            book_idLabel.Text = "Book id:";
            // 
            // book_titleLabel
            // 
            book_titleLabel.AutoSize = true;
            book_titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_titleLabel.Location = new System.Drawing.Point(35, 67);
            book_titleLabel.Name = "book_titleLabel";
            book_titleLabel.Size = new System.Drawing.Size(79, 20);
            book_titleLabel.TabIndex = 35;
            book_titleLabel.Text = "Book title:";
            // 
            // book_LanguageLabel
            // 
            book_LanguageLabel.AutoSize = true;
            book_LanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_LanguageLabel.Location = new System.Drawing.Point(35, 99);
            book_LanguageLabel.Name = "book_LanguageLabel";
            book_LanguageLabel.Size = new System.Drawing.Size(126, 20);
            book_LanguageLabel.TabIndex = 37;
            book_LanguageLabel.Text = "Book Language:";
            // 
            // publication_yearLabel
            // 
            publication_yearLabel.AutoSize = true;
            publication_yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            publication_yearLabel.Location = new System.Drawing.Point(35, 131);
            publication_yearLabel.Name = "publication_yearLabel";
            publication_yearLabel.Size = new System.Drawing.Size(124, 20);
            publication_yearLabel.TabIndex = 39;
            publication_yearLabel.Text = "Publication year:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            authorLabel.Location = new System.Drawing.Point(35, 163);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(61, 20);
            authorLabel.TabIndex = 41;
            authorLabel.Text = "Author:";
            // 
            // purchase_dateLabel
            // 
            purchase_dateLabel.AutoSize = true;
            purchase_dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            purchase_dateLabel.Location = new System.Drawing.Point(35, 196);
            purchase_dateLabel.Name = "purchase_dateLabel";
            purchase_dateLabel.Size = new System.Drawing.Size(116, 20);
            purchase_dateLabel.TabIndex = 43;
            purchase_dateLabel.Text = "Purchase date:";
            // 
            // book_priceLabel
            // 
            book_priceLabel.AutoSize = true;
            book_priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_priceLabel.Location = new System.Drawing.Point(35, 227);
            book_priceLabel.Name = "book_priceLabel";
            book_priceLabel.Size = new System.Drawing.Size(88, 20);
            book_priceLabel.TabIndex = 45;
            book_priceLabel.Text = "Book price:";
            // 
            // book_quantityLabel
            // 
            book_quantityLabel.AutoSize = true;
            book_quantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            book_quantityLabel.Location = new System.Drawing.Point(35, 259);
            book_quantityLabel.Name = "book_quantityLabel";
            book_quantityLabel.Size = new System.Drawing.Size(110, 20);
            book_quantityLabel.TabIndex = 47;
            book_quantityLabel.Text = "Book quantity:";
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.back.Location = new System.Drawing.Point(537, 368);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(179, 44);
            this.back.TabIndex = 32;
            this.back.Text = "Go back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // up
            // 
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.up.Location = new System.Drawing.Point(158, 368);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(179, 44);
            this.up.TabIndex = 27;
            this.up.Text = "Update";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // library_management_systemDataSet3
            // 
            this.library_management_systemDataSet3.DataSetName = "library_management_systemDataSet3";
            this.library_management_systemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.library_management_systemDataSet3;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.Culog_inTableAdapter = null;
            this.tableAdapterManager.Log_inTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bq
            // 
            this.bq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bq.ForeColor = System.Drawing.Color.White;
            this.bq.Location = new System.Drawing.Point(241, 256);
            this.bq.Name = "bq";
            this.bq.Size = new System.Drawing.Size(453, 26);
            this.bq.TabIndex = 52;
            // 
            // pda
            // 
            this.pda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.pda.ForeColor = System.Drawing.Color.White;
            this.pda.Location = new System.Drawing.Point(241, 194);
            this.pda.Name = "pda";
            this.pda.Size = new System.Drawing.Size(453, 26);
            this.pda.TabIndex = 55;
            // 
            // bpri
            // 
            this.bpri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bpri.ForeColor = System.Drawing.Color.White;
            this.bpri.Location = new System.Drawing.Point(241, 224);
            this.bpri.Name = "bpri";
            this.bpri.Size = new System.Drawing.Size(453, 26);
            this.bpri.TabIndex = 54;
            // 
            // au
            // 
            this.au.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.au.ForeColor = System.Drawing.Color.White;
            this.au.Location = new System.Drawing.Point(241, 160);
            this.au.Name = "au";
            this.au.Size = new System.Drawing.Size(453, 26);
            this.au.TabIndex = 53;
            // 
            // bl
            // 
            this.bl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bl.ForeColor = System.Drawing.Color.White;
            this.bl.Location = new System.Drawing.Point(241, 93);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(453, 26);
            this.bl.TabIndex = 48;
            // 
            // py
            // 
            this.py.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.py.ForeColor = System.Drawing.Color.White;
            this.py.Location = new System.Drawing.Point(241, 128);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(453, 26);
            this.py.TabIndex = 51;
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bt.ForeColor = System.Drawing.Color.White;
            this.bt.Location = new System.Drawing.Point(241, 61);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(453, 26);
            this.bt.TabIndex = 50;
            // 
            // bid
            // 
            this.bid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.bid.ForeColor = System.Drawing.Color.White;
            this.bid.Location = new System.Drawing.Point(241, 32);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(453, 26);
            this.bid.TabIndex = 49;
            // 
            // update_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 474);
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
            this.Controls.Add(purchase_dateLabel);
            this.Controls.Add(book_priceLabel);
            this.Controls.Add(book_quantityLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.up);
            this.Name = "update_Book";
            this.Text = "update_Book";
            this.Load += new System.EventHandler(this.update_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button up;
        private library_management_systemDataSet3 library_management_systemDataSet3;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSet3TableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bq;
        private System.Windows.Forms.TextBox pda;
        private System.Windows.Forms.TextBox bpri;
        private System.Windows.Forms.TextBox au;
        private System.Windows.Forms.TextBox bl;
        private System.Windows.Forms.TextBox py;
        private System.Windows.Forms.TextBox bt;
        private System.Windows.Forms.TextBox bid;
    }
}