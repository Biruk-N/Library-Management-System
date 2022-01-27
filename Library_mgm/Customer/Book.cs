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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {


          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            string cmdStrig = "select * from Book where Book_title = 'The Power Of Now';";
            SqlDataReader dr;
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand(cmdStrig, con);
                

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Issuse_book d = new Issuse_book();
                    d.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Password/username mismatch");

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
