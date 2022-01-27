namespace Library_mgm
{
    partial class Delete_User
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
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label addressLabel;
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.fn = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.del = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            fNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(156, 116);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(64, 20);
            fNameLabel.TabIndex = 20;
            fNameLabel.Text = "f Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(156, 148);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address:";
            // 
            // library_management_systemDataSet
            // 
            this.library_management_systemDataSet.DataSetName = "library_management_systemDataSet";
            this.library_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.library_management_systemDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_bindingTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(266, 116);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(343, 26);
            this.fn.TabIndex = 22;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(266, 148);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(343, 26);
            this.ad.TabIndex = 23;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(160, 357);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(208, 62);
            this.del.TabIndex = 19;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(420, 357);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(208, 62);
            this.back.TabIndex = 24;
            this.back.Text = "Go back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 506);
            this.Controls.Add(this.back);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ad);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.del);
            this.Name = "Delete_User";
            this.Text = "Delete_User";
            this.Load += new System.EventHandler(this.Delete_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private library_management_systemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button back;
    }
}