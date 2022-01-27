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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string conString = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            string cmdStrig = "select * from log_in where username = @un and pass = @pw";
            SqlDataReader dr;
            try
            {

                con.Open();
              
                SqlCommand cmd = new SqlCommand(cmdStrig, con);

                cmd.Parameters.Add("@un", SqlDbType.NVarChar).Value = nameTxtBox.Text;
                cmd.Parameters.Add("@pw", SqlDbType.NVarChar).Value = pwdTxtBox.Text;

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Admin d = new Admin();
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

            finally
            {
                con.Close();
                MessageBox.Show("In finally block. DB disconnected!");

            }
                
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register next = new Register();
            next.Show();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

