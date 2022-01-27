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
    public partial class CuRegister : Form
    {
        public CuRegister()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet2);

        }

        private void CuRegister_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Culog_in' table. You can move, or remove it, as needed.
            this.culog_inTableAdapter.Fill(this.library_management_systemDataSet2.Culog_in);
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.library_management_systemDataSet2.Customer);

        }

        private void reg_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            string cmdstring = @"insert into Customer values (@ua, @de) insert into Culog_in values (@uu, @pa)";
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);

                cmd.Parameters.Add("@ua", SqlDbType.NVarChar).Value = fn.Text;
                cmd.Parameters.Add("@de", SqlDbType.NVarChar).Value = ad.Text;

                cmd.Parameters.Add("@uu", SqlDbType.NVarChar).Value = un.Text;
                cmd.Parameters.Add("@pa", SqlDbType.NVarChar).Value = ps.Text;
                dr = cmd.ExecuteReader();
                conn.Close();
                
                if (dr.HasRows)
                {
                    Book bo = new Book();
                    bo.Show();
                    this.Hide();
                }

               

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
