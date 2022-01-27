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
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label book_titleLabel;
            System.Windows.Forms.Label book_LanguageLabel;
            System.Windows.Forms.Label publication_yearLabel;
            System.Windows.Forms.Label binding_idLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label shelf_idLabel;
            System.Windows.Forms.Label category_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issuse_book));
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.bookBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.book_idTextBox = new System.Windows.Forms.TextBox();
            this.book_titleTextBox = new System.Windows.Forms.TextBox();
            this.book_LanguageTextBox = new System.Windows.Forms.TextBox();
            this.publication_yearTextBox = new System.Windows.Forms.TextBox();
            this.binding_idTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.shelf_idTextBox = new System.Windows.Forms.TextBox();
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.studentTableAdapter1 = new Library_mgm.library_management_systemDataSetTableAdapters.StudentTableAdapter();
            this.issue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            book_idLabel = new System.Windows.Forms.Label();
            book_titleLabel = new System.Windows.Forms.Label();
            book_LanguageLabel = new System.Windows.Forms.Label();
            publication_yearLabel = new System.Windows.Forms.Label();
            binding_idLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            shelf_idLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).BeginInit();
            this.bookBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            book_idLabel.Location = new System.Drawing.Point(154, 135);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(66, 20);
            book_idLabel.TabIndex = 1;
            book_idLabel.Text = "Book id:";
            // 
            // book_titleLabel
            // 
            book_titleLabel.AutoSize = true;
            book_titleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            book_titleLabel.Location = new System.Drawing.Point(154, 167);
            book_titleLabel.Name = "book_titleLabel";
            book_titleLabel.Size = new System.Drawing.Size(79, 20);
            book_titleLabel.TabIndex = 3;
            book_titleLabel.Text = "Book title:";
            // 
            // book_LanguageLabel
            // 
            book_LanguageLabel.AutoSize = true;
            book_LanguageLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            book_LanguageLabel.Location = new System.Drawing.Point(154, 199);
            book_LanguageLabel.Name = "book_LanguageLabel";
            book_LanguageLabel.Size = new System.Drawing.Size(126, 20);
            book_LanguageLabel.TabIndex = 5;
            book_LanguageLabel.Text = "Book Language:";
            // 
            // publication_yearLabel
            // 
            publication_yearLabel.AutoSize = true;
            publication_yearLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            publication_yearLabel.Location = new System.Drawing.Point(154, 231);
            publication_yearLabel.Name = "publication_yearLabel";
            publication_yearLabel.Size = new System.Drawing.Size(124, 20);
            publication_yearLabel.TabIndex = 7;
            publication_yearLabel.Text = "Publication year:";
            // 
            // binding_idLabel
            // 
            binding_idLabel.AutoSize = true;
            binding_idLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            binding_idLabel.Location = new System.Drawing.Point(154, 263);
            binding_idLabel.Name = "binding_idLabel";
            binding_idLabel.Size = new System.Drawing.Size(82, 20);
            binding_idLabel.TabIndex = 9;
            binding_idLabel.Text = "Binding id:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            authorLabel.Location = new System.Drawing.Point(154, 295);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(61, 20);
            authorLabel.TabIndex = 11;
            authorLabel.Text = "Author:";
            // 
            // shelf_idLabel
            // 
            shelf_idLabel.AutoSize = true;
            shelf_idLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            shelf_idLabel.Location = new System.Drawing.Point(154, 327);
            shelf_idLabel.Name = "shelf_idLabel";
            shelf_idLabel.Size = new System.Drawing.Size(63, 20);
            shelf_idLabel.TabIndex = 13;
            shelf_idLabel.Text = "shelf id:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            category_idLabel.Location = new System.Drawing.Point(154, 359);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(93, 20);
            category_idLabel.TabIndex = 15;
            category_idLabel.Text = "Category id:";
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
            // bookBindingNavigator
            // 
            this.bookBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookBindingNavigator.BindingSource = this.bookBindingSource;
            this.bookBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookBindingNavigatorSaveItem});
            this.bookBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookBindingNavigator.Name = "bookBindingNavigator";
            this.bookBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookBindingNavigator.Size = new System.Drawing.Size(990, 31);
            this.bookBindingNavigator.TabIndex = 0;
            this.bookBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bookBindingNavigatorSaveItem
            // 
            this.bookBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookBindingNavigatorSaveItem.Image")));
            this.bookBindingNavigatorSaveItem.Name = "bookBindingNavigatorSaveItem";
            this.bookBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
            this.bookBindingNavigatorSaveItem.Text = "Save Data";
            this.bookBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookBindingNavigatorSaveItem_Click_1);
            // 
            // book_idTextBox
            // 
            this.book_idTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.book_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_id", true));
            this.book_idTextBox.Location = new System.Drawing.Point(286, 132);
            this.book_idTextBox.Name = "book_idTextBox";
            this.book_idTextBox.Size = new System.Drawing.Size(425, 26);
            this.book_idTextBox.TabIndex = 2;
            // 
            // book_titleTextBox
            // 
            this.book_titleTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.book_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_title", true));
            this.book_titleTextBox.Location = new System.Drawing.Point(286, 164);
            this.book_titleTextBox.Name = "book_titleTextBox";
            this.book_titleTextBox.Size = new System.Drawing.Size(425, 26);
            this.book_titleTextBox.TabIndex = 4;
            // 
            // book_LanguageTextBox
            // 
            this.book_LanguageTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.book_LanguageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Book_Language", true));
            this.book_LanguageTextBox.Location = new System.Drawing.Point(286, 196);
            this.book_LanguageTextBox.Name = "book_LanguageTextBox";
            this.book_LanguageTextBox.Size = new System.Drawing.Size(425, 26);
            this.book_LanguageTextBox.TabIndex = 6;
            // 
            // publication_yearTextBox
            // 
            this.publication_yearTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.publication_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publication_year", true));
            this.publication_yearTextBox.Location = new System.Drawing.Point(286, 228);
            this.publication_yearTextBox.Name = "publication_yearTextBox";
            this.publication_yearTextBox.Size = new System.Drawing.Size(425, 26);
            this.publication_yearTextBox.TabIndex = 8;
            // 
            // binding_idTextBox
            // 
            this.binding_idTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.binding_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Binding_id", true));
            this.binding_idTextBox.Location = new System.Drawing.Point(286, 260);
            this.binding_idTextBox.Name = "binding_idTextBox";
            this.binding_idTextBox.Size = new System.Drawing.Size(425, 26);
            this.binding_idTextBox.TabIndex = 10;
            // 
            // authorTextBox
            // 
            this.authorTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(286, 292);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(425, 26);
            this.authorTextBox.TabIndex = 12;
            // 
            // shelf_idTextBox
            // 
            this.shelf_idTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.shelf_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "shelf_id", true));
            this.shelf_idTextBox.Location = new System.Drawing.Point(286, 324);
            this.shelf_idTextBox.Name = "shelf_idTextBox";
            this.shelf_idTextBox.Size = new System.Drawing.Size(425, 26);
            this.shelf_idTextBox.TabIndex = 14;
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(286, 356);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(425, 26);
            this.category_idTextBox.TabIndex = 16;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.issue.Location = new System.Drawing.Point(286, 422);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(425, 31);
            this.issue.TabIndex = 17;
            this.issue.Text = "Issue_book";
            this.issue.UseVisualStyleBackColor = false;
            this.issue.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(730, 422);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Issuse_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_mgm.Properties.Resources.GettyImages_900301626_437925_t2i3bm;
            this.ClientSize = new System.Drawing.Size(990, 576);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.issue);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(this.book_idTextBox);
            this.Controls.Add(book_titleLabel);
            this.Controls.Add(this.book_titleTextBox);
            this.Controls.Add(book_LanguageLabel);
            this.Controls.Add(this.book_LanguageTextBox);
            this.Controls.Add(publication_yearLabel);
            this.Controls.Add(this.publication_yearTextBox);
            this.Controls.Add(binding_idLabel);
            this.Controls.Add(this.binding_idTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(shelf_idLabel);
            this.Controls.Add(this.shelf_idTextBox);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(this.bookBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Issuse_book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issuse_book";
            this.Load += new System.EventHandler(this.Issuse_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingNavigator)).EndInit();
            this.bookBindingNavigator.ResumeLayout(false);
            this.bookBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox book_idTextBox;
        private System.Windows.Forms.TextBox book_titleTextBox;
        private System.Windows.Forms.TextBox book_LanguageTextBox;
        private System.Windows.Forms.TextBox publication_yearTextBox;
        private System.Windows.Forms.TextBox binding_idTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox shelf_idTextBox;
        private System.Windows.Forms.TextBox category_idTextBox;
        private library_management_systemDataSetTableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.Button issue;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}