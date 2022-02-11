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
    public partial class View_customer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
         
        public View_customer()
        {
            InitializeComponent();
        }

        private void View_customer_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer where Customer_name like( '%" + cu.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
