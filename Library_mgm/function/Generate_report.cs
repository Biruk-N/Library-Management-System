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
    public partial class Generate_report : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
       
        public Generate_report()
        {
            InitializeComponent();
            InitializedataGridView();
        }
        public void InitializedataGridView() 
        {
           
        
        }
        private void Generate_report_Load(object sender, EventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Issue_book";
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
