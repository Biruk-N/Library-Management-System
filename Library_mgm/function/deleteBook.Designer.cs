namespace Library_mgm
{
    partial class deleteBook
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
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.delete = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            book_idLabel = new System.Windows.Forms.Label();
            book_titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.Location = new System.Drawing.Point(97, 180);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(66, 20);
            book_idLabel.TabIndex = 1;
            book_idLabel.Text = "Book id:";
            // 
            // book_titleLabel
            // 
            book_titleLabel.AutoSize = true;
            book_titleLabel.Location = new System.Drawing.Point(97, 212);
            book_titleLabel.Name = "book_titleLabel";
            book_titleLabel.Size = new System.Drawing.Size(79, 20);
            book_titleLabel.TabIndex = 3;
            book_titleLabel.Text = "Book title:";
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
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(308, 286);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 33);
            this.delete.TabIndex = 34;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(227, 209);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(453, 26);
            this.bt.TabIndex = 28;
            // 
            // bid
            // 
            this.bid.Location = new System.Drawing.Point(227, 180);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(453, 26);
            this.bid.TabIndex = 27;
            // 
            // deleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 614);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.bid);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(book_titleLabel);
            this.Name = "deleteBook";
            this.Text = "deleteBook";
            this.Load += new System.EventHandler(this.deleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox bt;
        private System.Windows.Forms.TextBox bid;

    }
}