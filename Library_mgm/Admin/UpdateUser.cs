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
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            string cmdstring = "update Customer set Address='" + ad.Text + "' where fName='" + fn.Text + "' ";
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

        private void del_Click(object sender, EventArgs e)
        {
            //string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"delete from emp where emp_name=@ps and emp_dep=@de";
            //SqlDataReader dr;
            //try
            //{


            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(cmdstring, conn);

            //    //  cmd.Parameters.Add("@un", SqlDbType.Int).Value = emp_idTextBox.Text;
            //    cmd.Parameters.Add("@ps", SqlDbType.NVarChar).Value = emp_nameTextBox.Text;
            //    cmd.Parameters.Add("@de", SqlDbType.NVarChar).Value = emp_depTextBox.Text;

            //    dr = cmd.ExecuteReader();

            //    //if (dr.HasRows)
            //    //{
            //    //    Empl ea = new Empl();
            //    //    ea.Show();
            //    //    this.Hide();
            //    //}
            //    //else
            //    //    MessageBox.Show("Password/username mismatch");

            //    conn.Close();
            //    MessageBox.Show("The data deleted!!!");

            //}
            //catch (SqlException ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet2);

        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.library_management_systemDataSet2.Customer);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admindash admdash = new Admindash();
            admdash.Show();
            this.Hide();
        }
    }
}
