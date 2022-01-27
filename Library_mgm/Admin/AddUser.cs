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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.library_management_systemDataSet2.Customer);
            // TODO: This line of code loads data into the 'library_management_systemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.library_management_systemDataSet.Student);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
             string cmdstring = "insert into Customer values('" + fn.Text + "','" + ad.Text + "')";
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);
                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("new Customer added");



            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admindash admdash = new Admindash();
            admdash.Show();
            this.Hide();
        }
    }
}
