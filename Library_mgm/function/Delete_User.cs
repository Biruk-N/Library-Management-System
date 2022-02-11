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
    public partial class Delete_User : Form
    {
        public Delete_User()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void Delete_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet.Student' table. You can move, or remove it, as needed.
            

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void del_Click_1(object sender, EventArgs e)
        {

            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            string cmdstring = "delete from Customer where '" + cid.Text + "'=Customer_id and'" + cn.Text + "'=Customer_name";
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);


                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Customer delete from db");



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
