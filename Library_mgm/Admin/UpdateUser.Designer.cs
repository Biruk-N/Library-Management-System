namespace Library_mgm
{
    partial class UpdateUser
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
            this.up = new System.Windows.Forms.Button();
            this.library_management_systemDataSet2 = new Library_mgm.library_management_systemDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Library_mgm.library_management_systemDataSet2TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager();
            this.fn = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            fNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(263, 159);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(64, 20);
            fNameLabel.TabIndex = 2;
            fNameLabel.Text = "f Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(263, 191);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(72, 20);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(200, 329);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(208, 62);
            this.up.TabIndex = 0;
            this.up.Text = "Update";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_bindingTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Culog_inTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Log_inTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(341, 159);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(343, 26);
            this.fn.TabIndex = 24;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(341, 191);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(343, 26);
            this.ad.TabIndex = 25;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(554, 329);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(208, 62);
            this.back.TabIndex = 26;
            this.back.Text = "Go back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 503);
            this.Controls.Add(this.back);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.ad);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.up);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private library_management_systemDataSet2 library_management_systemDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private library_management_systemDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private library_management_systemDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Button back;
    }
}