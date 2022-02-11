namespace Library_mgm
{
    partial class View_customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.library_management_systemDataSet = new Library_mgm.library_management_systemDataSet();
            this.cu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableAdapterManager1 = new Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager();
            this.bookTableAdapter1 = new Library_mgm.library_management_systemDataSet3TableAdapters.BookTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_mgm.library_management_systemDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new Library_mgm.library_management_systemDataSetTableAdapters.TableAdapterManager();
            this.library_management_systemDataSet3 = new Library_mgm.library_management_systemDataSet3();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(710, 331);
            this.dataGridView1.TabIndex = 11;
            // 
            // search
            // 
            this.search.FlatAppearance.BorderSize = 0;
            this.search.Location = new System.Drawing.Point(16, 129);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(156, 37);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // library_management_systemDataSet
            // 
            this.library_management_systemDataSet.DataSetName = "library_management_systemDataSet";
            this.library_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cu
            // 
            this.cu.Location = new System.Drawing.Point(16, 75);
            this.cu.Name = "cu";
            this.cu.Size = new System.Drawing.Size(195, 26);
            this.cu.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search by name";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BookTableAdapter = this.bookTableAdapter1;
            this.tableAdapterManager1.Culog_inTableAdapter = null;
            this.tableAdapterManager1.Log_inTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Library_mgm.library_management_systemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
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
            // View_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(994, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.label1);
            this.Name = "View_customer";
            this.Text = "View_customer";
            this.Load += new System.EventHandler(this.View_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_management_systemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button search;
        private library_management_systemDataSet library_management_systemDataSet;
        private System.Windows.Forms.TextBox cu;
        private System.Windows.Forms.Label label1;
        private library_management_systemDataSet3TableAdapters.TableAdapterManager tableAdapterManager1;
        private library_management_systemDataSet3TableAdapters.BookTableAdapter bookTableAdapter1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private library_management_systemDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private library_management_systemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private library_management_systemDataSet3 library_management_systemDataSet3;
        private System.Windows.Forms.BindingSource bookBindingSource1;
    }
}