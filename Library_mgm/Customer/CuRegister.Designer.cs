namespace Library_mgm
{
    partial class CuRegister
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
            System.Windows.Forms.Label fnn;
            System.Windows.Forms.Label add;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passLabel;
            this.library_management_systemDataSet2 = new Library_mgm.library_management_systemDataSet2();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Library_mgm.library_management_systemDataSet2TableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager();
            this.culog_inTableAdapter = new Library_mgm.library_management_systemDataSet2TableAdapters.Culog_inTableAdapter();
            this.culog_inBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fn = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.ps = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            fnn = new System.Windows.Forms.Label();
            add = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.culog_inBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fnn
            // 
            fnn.AutoSize = true;
            fnn.Location = new System.Drawing.Point(223, 132);
            fnn.Name = "fnn";
            fnn.Size = new System.Drawing.Size(84, 20);
            fnn.TabIndex = 1;
            fnn.Text = "Full Name:";
            // 
            // add
            // 
            add.AutoSize = true;
            add.Location = new System.Drawing.Point(223, 171);
            add.Name = "add";
            add.Size = new System.Drawing.Size(72, 20);
            add.TabIndex = 3;
            add.Text = "Address:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(221, 209);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 20);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(223, 247);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(82, 20);
            passLabel.TabIndex = 7;
            passLabel.Text = "Password:";
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
            this.tableAdapterManager.Culog_inTableAdapter = this.culog_inTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.Log_inTableAdapter = null;
            this.tableAdapterManager.ShelfTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_mgm.library_management_systemDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // culog_inTableAdapter
            // 
            this.culog_inTableAdapter.ClearBeforeFill = true;
            // 
            // culog_inBindingSource
            // 
            this.culog_inBindingSource.DataMember = "Culog_in";
            this.culog_inBindingSource.DataSource = this.library_management_systemDataSet2;
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(311, 132);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(317, 26);
            this.fn.TabIndex = 8;
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(311, 206);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(317, 26);
            this.un.TabIndex = 8;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(311, 171);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(317, 26);
            this.ad.TabIndex = 8;
            // 
            // ps
            // 
            this.ps.Location = new System.Drawing.Point(311, 247);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(317, 26);
            this.ps.TabIndex = 8;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(299, 426);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(142, 52);
            this.reg.TabIndex = 9;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // CuRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 560);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.un);
            this.Controls.Add(this.fn);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(passLabel);
            this.Controls.Add(fnn);
            this.Controls.Add(add);
            this.Name = "CuRegister";
            this.Text = "CuRegister";
            this.Load += new System.EventHandler(this.CuRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.culog_inBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private library_management_systemDataSet2 library_management_systemDataSet2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private library_management_systemDataSet2TableAdapters.CustomerTableAdapter customerTableAdapter;
        private library_management_systemDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private library_management_systemDataSet2TableAdapters.Culog_inTableAdapter culog_inTableAdapter;
        private System.Windows.Forms.BindingSource culog_inBindingSource;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.Button reg;
    }
}