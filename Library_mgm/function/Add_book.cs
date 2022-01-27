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
    public partial class Add_book : Form
    {
        public Add_book()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void Add_book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_management_systemDataSet3.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet1.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet2.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);
            // TODO: This line of code loads data into the 'library_management_systemDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.library_management_systemDataSet3.Book);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ad_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            string cmdstring = "insert into Book values('" + bid.Text + "','" + bt.Text + "','" + bl.Text + "','" + py.Text + "','" + au.Text + "','"+ pda.Text +"','" + bpri.Text + "','"+bq.Text+"')";
            //
            SqlDataReader dr;
            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdstring, conn);

                //cmd.Parameters.Add("@ua", SqlDbType.Int).Value = bid.Text;
                //cmd.Parameters.Add("@de", SqlDbType.VarChar).Value = bt.Text;

                //cmd.Parameters.Add("@uu", SqlDbType.VarChar).Value = bl.Text;
                //cmd.Parameters.Add("@pa", SqlDbType.Int).Value = py.Text;
                //cmd.Parameters.Add("@uq", SqlDbType.Int).Value = biid.Text;
                //cmd.Parameters.Add("@dq", SqlDbType.VarChar).Value = au.Text;

                //cmd.Parameters.Add("@us", SqlDbType.Int).Value = sid.Text;
                //cmd.Parameters.Add("@pw", SqlDbType.Int).Value = cid.Text;
                dr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("new book added");



            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void au_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_TextChanged(object sender, EventArgs e)
        {

        }

        private void biid_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void bl_TextChanged(object sender, EventArgs e)
        {

        }

        private void py_TextChanged(object sender, EventArgs e)
        {

        }

        private void bid_TextChanged(object sender, EventArgs e)
        {

        }

        private void pda_ValueChanged(object sender, EventArgs e)
        {
            

            // Set the MinDate and MaxDate.
        
            // Set the CustomFormat string.
            //pda.CustomFormat = "yyyy MMMM dd";
            //pda.Format = DateTimePickerFormat.Custom;

         
        }
    }
}
