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
    public partial class Returnbook : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
     
        public Returnbook()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Returnbook_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }
        public void fill_grid(string ciddd)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from Issue_book where Customer_id = '"+ciddd.ToString()+"'and Book_return_date = ''";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            
        }

        private void sc_Click(object sender, EventArgs e)
        {
            fill_grid(ciid.Text);
            panel2.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select * from Issue_book where id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                btt.Text = dr2["Book_title"].ToString();
                bid.Text = dr2["Book_issue_date"].ToString();

            }
        }

        private void issue_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
          
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update Issue_book set Book_return_date = '"+bidi.Value.ToString()+"' where id=" + i + "";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = @"update Book set available_qty = available_qty + 1 where Book_title='" + btt.Text + "' ";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Book return successfully!!!");
            panel3.Visible = false;
            fill_grid(ciid.Text);
        }
    }
}
