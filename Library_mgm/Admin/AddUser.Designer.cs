namespace Library_mgm
{
    partial class AddUser
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
            this.Add = new System.Windows.Forms.Button();
            this.library_management_systemDataSet2 = new Library_mgm.library_management_systemDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Library_mgm.library_management_systemDataSet2TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager1 = new Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager();
            this.ad = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            fNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(156, 172);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(64, 20);
            fNameLabel.TabIndex = 15;
            fNameLabel.Text = "f Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(156, 204);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 17;
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
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(160, 401);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(208, 62);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // library_management_systemDataSet2
            // 
            this.library_management_systemDataSet2.DataSetName = "library_management_systemDataSet2";
            this.library_management_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.library_management_systemDataSet2;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Book_bindingTableAdapter = null;
            this.tableAdapterManager1.BookTableAdapter = null;
            this.tableAdapterManager1.BorrowerTableAdapter = null;
            this.tableAdapterManager1.CategoryTableAdapter = null;
            this.tableAdapterManager1.Culog_inTableAdapter = null;
            this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager1.Log_inTableAdapter = null;
            this.tableAdapterManager1.ShelfTableAdapter = null;
            this.tableAdapterManager1.StaffTableAdapter = null;
            this.tableAdapterManager1.StudentTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(266, 204);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(343, 26);
            this.ad.TabIndex = 18;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(266, 172);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(343, 26);
            this.fn.TabIndex = 18;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(421, 401);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(208, 62);
            this.back.TabIndex = 25;
            this.back.Text = "Go back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 575);
            this.Controls.Add(this.back);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ad);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.Add);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private library_management_systemDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Add;
        private library_management_systemDataSet2 library_management_systemDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private library_management_systemDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private library_management_systemDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Button back;
    }
}