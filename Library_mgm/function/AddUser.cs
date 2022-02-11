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
            InitializeCombox();
        }
        private void InitializeCombox() 
        {
            crr.Items.AddRange(Enum.GetNames(typeof(Role)));
            crr.SelectedIndex = 1;
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            string cmdstring = "insert into Customer values('" + cid.Text + "','" + cn.Text + "','" + crr.Text + "','" + con.Text + "')";
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
            
            this.Hide();
        }

        private void crr_SelectedIndexChanged(object sender, EventArgs e)
        {
           //Role r = new Role();

        }
    }
}
