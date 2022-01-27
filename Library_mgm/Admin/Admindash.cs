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
    public partial class Admindash : Form
    {
        public Admindash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string conString = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            //SqlConnection con = new SqlConnection(conString);
            //string cmdStrig = "select * from Book";
            //SqlDataReader dr;
            //try
            //{

            //    con.Open();

            //    SqlCommand cmd = new SqlCommand(cmdStrig, con);


            //    dr = cmd.ExecuteReader();

            //    if (dr.HasRows)
            //    {
            //        string v = "select count from Book ";
                    
            //        SqlCommand cc = new SqlCommand(v, con);

            //        //MessageBox.Show(cc);
                 
                  
            //    }
            //    else
            //        MessageBox.Show("Password/username mismatch");

            //}

            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    con.Close();
            //}
            AdmBook ab = new AdmBook();
            ab.Show();
            this.Hide();

          
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddUser au = new AddUser();
            au.Show();
            this.Hide();
        }

        private void del_Click(object sender, EventArgs e)
        {
            Delete_User delete = new Delete_User();
            delete.Show();
            this.Hide();
        }

        private void up_Click(object sender, EventArgs e)
        {
            UpdateUser upus= new UpdateUser();
            upus.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void Admindash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.library_management_systemDataSet2.Customer);
            // TODO: This line of code loads data into the 'library_management_systemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.library_management_systemDataSet.Student);

        }
    }
}
