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
            System.Windows.Forms.Label customer_nameLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label customer_roleLabel;
            System.Windows.Forms.Label customer_contactLabel;
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.StudentTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.del = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.crr = new System.Windows.Forms.ComboBox();
            this.cn = new System.Windows.Forms.TextBox();
            this.cid = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.TextBox();
            customer_nameLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            customer_roleLabel = new System.Windows.Forms.Label();
            customer_contactLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // del
            // 
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
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
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.back.Location = new System.Drawing.Point(420, 357);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(208, 62);
            this.back.TabIndex = 24;
            this.back.Text = "Go back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // crr
            // 
            this.crr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.crr.ForeColor = System.Drawing.Color.White;
            this.crr.FormattingEnabled = true;
            this.crr.Location = new System.Drawing.Point(305, 207);
            this.crr.Name = "crr";
            this.crr.Size = new System.Drawing.Size(343, 28);
            this.crr.TabIndex = 49;
            // 
            // customer_nameLabel
            // 
            customer_nameLabel.AutoSize = true;
            customer_nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            customer_nameLabel.Location = new System.Drawing.Point(160, 170);
            customer_nameLabel.Name = "customer_nameLabel";
            customer_nameLabel.Size = new System.Drawing.Size(126, 20);
            customer_nameLabel.TabIndex = 48;
            customer_nameLabel.Text = "Customer name:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            customer_idLabel.Location = new System.Drawing.Point(160, 135);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(98, 20);
            customer_idLabel.TabIndex = 45;
            customer_idLabel.Text = "Customer id:";
            // 
            // customer_roleLabel
            // 
            customer_roleLabel.AutoSize = true;
            customer_roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            customer_roleLabel.Location = new System.Drawing.Point(160, 210);
            customer_roleLabel.Name = "customer_roleLabel";
            customer_roleLabel.Size = new System.Drawing.Size(112, 20);
            customer_roleLabel.TabIndex = 46;
            customer_roleLabel.Text = "Customer role:";
            // 
            // customer_contactLabel
            // 
            customer_contactLabel.AutoSize = true;
            customer_contactLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            customer_contactLabel.Location = new System.Drawing.Point(160, 242);
            customer_contactLabel.Name = "customer_contactLabel";
            customer_contactLabel.Size = new System.Drawing.Size(139, 20);
            customer_contactLabel.TabIndex = 47;
            customer_contactLabel.Text = "Customer contact:";
            // 
            // cn
            // 
            this.cn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cn.ForeColor = System.Drawing.Color.White;
            this.cn.Location = new System.Drawing.Point(305, 170);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(343, 26);
            this.cn.TabIndex = 42;
            // 
            // cid
            // 
            this.cid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cid.ForeColor = System.Drawing.Color.White;
            this.cid.Location = new System.Drawing.Point(305, 135);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(343, 26);
            this.cid.TabIndex = 43;
            // 
            // con
            // 
            this.con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.con.ForeColor = System.Drawing.Color.White;
            this.con.Location = new System.Drawing.Point(305, 242);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(343, 26);
            this.con.TabIndex = 44;
            // 
            // Delete_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(765, 506);
            this.Controls.Add(this.crr);
            this.Controls.Add(customer_nameLabel);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(customer_roleLabel);
            this.Controls.Add(customer_contactLabel);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.con);
            this.Controls.Add(this.back);
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
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox crr;
        private System.Windows.Forms.TextBox cn;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox con;
    }
}