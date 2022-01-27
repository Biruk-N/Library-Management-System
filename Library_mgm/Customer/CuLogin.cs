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
    public partial class CuLogin : Form
    {
        public CuLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book customer = new Book();
            customer.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CuRegister reg = new CuRegister();
            reg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string conString = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            string cmdStrig = "select * from Culog_in where username = @un and pass = @pw";
            SqlDataReader dr;
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand(cmdStrig, con);

                cmd.Parameters.Add("@un", SqlDbType.NVarChar).Value = textBox2.Text;
                cmd.Parameters.Add("@pw", SqlDbType.NVarChar).Value = textBox1.Text;

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                   miduser go = new miduser();
                   go.Show();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
