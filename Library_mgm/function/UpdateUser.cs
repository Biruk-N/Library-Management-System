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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void up_Click(object sender, EventArgs e)
        {
           
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
        }

        private void back_Click(object sender, EventArgs e)
        {
          
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void del_Click_1(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            string cmdstring = "update Customer set Customer_id='" + cid.Text + "',  Customer_role='" + crr.Text + "', Customer_contact='" + con.Text + "' where Customer_name='" + cn.Text + "' ";
            //"update Book set Book_id='" + bid.Text + "','" + bl.Text + "','" + py.Text + "','" + au.Text + "','" + pda.Text + "','" + bpri.Text + "','" + bq.Text + "' where Book_title='" + bt.Text + "' ";
            //
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);
                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Customer info updated");



            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
