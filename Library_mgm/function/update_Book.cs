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
    public partial class update_Book : Form
    {
        public update_Book()
        {
            InitializeComponent();
        }

        private void update_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet3.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.library_management_systemDataSet3.Book);

        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet3);

        }

        private void bookBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet3);

        }

        private void up_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            string cmdstring = "update Book set Book_id='" + bid.Text + "', Book_Language = '" + bl.Text + "', Publication_year = '" + py.Text + "',Author = '" + au.Text + "', Purchase_date = '" + pda.Text + "', Book_price = '" + bpri.Text + "', Book_quantity = '" + bq.Text + "' where Book_title='" + bt.Text + "' ";
            //
            //"insert into Book values('" + bid.Text + "','" + bt.Text + "','" + bl.Text + "','" + py.Text + "','" + au.Text + "','" + pda.Text + "','" + bpri.Text + "','" + bq.Text + "')";
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);


                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Customer data updated");



            }
              

             
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
