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
    public partial class Issuse_book : Form
    {
        SqlConnection conn = new SqlConnection( @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
        public Issuse_book()
        {
            InitializeComponent();
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void bookBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library_management_systemDataSet);

        }

        private void Issuse_book_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void sc_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from Customer where Customer_id = '"+ciid.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("this Id not found");
            }
            else
            {
                 foreach (DataRow dr in dt.Rows)
                {
                    cna.Text = dr["Customer_name"].ToString();
                    crr.Text = dr["Customer_role"].ToString();
                    ccon.Text = dr["Customer_contact"].ToString();

                }
            }
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btt_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;
            if (e.KeyCode != Keys.Enter)//user require to enter
            {
                listBox1.Items.Clear();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"select * from Book where Book_title like('%" + btt.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["Book_title"].ToString());  
                    }
                }
            }
        }

        private void btt_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Down)//user require to enter
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)//user require to enter
            {
                btt.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible =false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            btt.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }
        private void b1_Click(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void issue_Click(object sender, EventArgs e)
        {
            try
            {
                int books_Qty = 0;

                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = @"select * from Book where book_title = '" + btt.Text + "'";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    books_Qty = Convert.ToInt32(dr2["available_qty"].ToString());
                }
                if (books_Qty > 0)
                {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"insert into Issue_book values('" + ciid.Text + "', '" + cna.Text + "', '" + crr.Text + "', '" + ccon.Text + "', '" + btt.Text + "', '" + bid.Text + "','')";
                        cmd.ExecuteNonQuery();

                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = @"update Book set available_qty = available_qty-1 where book_title = '"+ btt.Text +"'";
                        cmd1.ExecuteNonQuery();

                MessageBox.Show("issue successfully");
                }
                else
                {
                    MessageBox.Show("Book is not available sorry!");
                }


            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
