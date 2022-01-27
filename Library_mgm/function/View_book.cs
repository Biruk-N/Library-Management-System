using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_mgm
{
    public partial class View_book : Form
    {

        public View_book()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void View_book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet3.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);


        }

        private void search_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);

            string cmdstring = "select * from Book where Book_title like( '%" + bookinput.Text + "%')";
            
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = ;

                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
               //SqlDataAdapter da = new SqlDataAdapter(conn);
              // da.Fill(dt);
               
                conn.Close();
                bookDataGridView.DataSource = dt;



            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
