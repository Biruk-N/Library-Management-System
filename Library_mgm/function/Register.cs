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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)


        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string cmdstring = " insert into Admininform values('" + fn.Text + " ',' " + ac.Text + "'); insert into Log_in values ('"+un.Text+"', '"+ pa.Text +"')";
            SqlDataReader dr;
          
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand(cmdstring, con);        
                dr = cmd.ExecuteReader();
               
                con.Close();
                MessageBox.Show("registerd");
                Admindash d = new Admindash();
                d.Show();
                this.Hide();

                


            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void had_Click(object sender, EventArgs e)
        {
            Login next = new Login();
            next.Show();
            this.Close();
        }
    }
}
