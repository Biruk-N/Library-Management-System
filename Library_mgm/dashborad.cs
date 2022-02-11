using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Runtime.InteropServices;

namespace Library_mgm
{
    public partial class dashborad : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True");
           

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //); 
        public dashborad()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            nav.Height = dbtn.Height;
            nav.Top = dbtn.Top;
            nav.Left = dbtn.Left;
            dbtn.BackColor = Color.FromArgb(46, 51, 73);
           // Controls.Remove(panel3); 
        }
        private void btn22_Click(object sender, EventArgs e)
        {
            nav.Height = btn22.Height;
            nav.Top = btn22.Top;
            nav.Left = btn22.Left;
            btn22.BackColor = Color.FromArgb(46, 51, 73);
            //Controls.Visible(panel3);
            panel3.Visible = true;
            Generate_report gr = new Generate_report();
            gr.Show();

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            nav.Height = btn3.Height;
            nav.Top = btn3.Top;
            nav.Left = btn3.Left;
            btn3.BackColor = Color.FromArgb(46, 51, 73);
            var t = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss ");
            MessageBox.Show(t);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            nav.Height = btn4.Height;
            nav.Top = btn4.Top;
            nav.Left = btn4.Left;
            btn4.BackColor = Color.FromArgb(46, 51, 73);
            Contactus u = new Contactus();
            u.Show();
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            nav.Height = btn5.Height;
            nav.Top = btn5.Top;
            nav.Left = btn5.Left;
            btn5.BackColor = Color.FromArgb(46, 51, 73);
            View_book vb = new View_book();
            vb.Show();
            //string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(connstring);
            ////string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            //SqlCommand cmdstring = new SqlCommand(@"SELECT Book_title FROM Book", conn);

            //try
            //{


            //    conn.Open();
            //    //  SqlCommand cmd = new SqlCommand(cmdstring, conn);



            //    using (SqlDataReader reader = cmdstring.ExecuteReader())
            //    {

            //        while (reader.Read())
            //        {
            //            string f = String.Format("{0}", reader[0]);
            //            MessageBox.Show(f);
            //        }
                    
            //    }
            //    conn.Close();





            //}

            //catch (SqlException ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void dashborad_Load(object sender, EventArgs e)
        {
            //switch (dashborad)
            //{
            //    case dbtn.Click:
            //        panel2.Visible;
            //}

            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            SqlCommand cmdstring = new SqlCommand(@"SELECT count(Book_id) FROM Book", conn);

            try
            {


                conn.Open();
                //  SqlCommand cmd = new SqlCommand(cmdstring, conn);



                using (SqlDataReader reader = cmdstring.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        ll.Text = String.Format("{0}", reader[0]);
                    }
                }
                conn.Close();





            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            cmdstring = new SqlCommand(@"SELECT count(Customer_id) FROM Customer", conn);

            try
            {


                conn.Open();
                //  SqlCommand cmd = new SqlCommand(cmdstring, conn);



                using (SqlDataReader reader = cmdstring.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        label7.Text = String.Format("{0}", reader[0]);
                    }
                }
                conn.Close();





            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            cmdstring = new SqlCommand(@"SELECT count(id) FROM Issue_Book", conn);

            try
            {


                conn.Open();
                //  SqlCommand cmd = new SqlCommand(cmdstring, conn);



                using (SqlDataReader reader = cmdstring.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        l2.Text = String.Format("{0}", reader[0]);
                    }
                }
                conn.Close();





            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dbtn_Leave(object sender, EventArgs e)
        {
            dbtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn22_Leave(object sender, EventArgs e)
        {
            btn22.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn3_Leave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn4_Leave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn5_Leave(object sender, EventArgs e)
        {
            btn5.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ll_Click(object sender, EventArgs e)
        {
            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            SqlCommand cmdstring =new SqlCommand (@"SELECT count(Book_id) FROM Book", conn);
          
            try
            {


                conn.Open();
              //  SqlCommand cmd = new SqlCommand(cmdstring, conn);

                
               
                  using (SqlDataReader reader = cmdstring.ExecuteReader())
                  {
                      
                      while (reader.Read())
                      {
                           ll.Text =  String.Format("{0}", reader[0]);
                      }
                  }
                conn.Close();
              
           



            }
           
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

            string connstring = @"Data Source=DESKTOP-0LFNEKC\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            //string cmdstring = @"insert into Book values (@ua, @de, @uu, @pa, @uq, @dq, @us, @pw)";
            SqlCommand cmdstring = new SqlCommand(@"SELECT count(Customer_id) FROM Customer", conn);

            try
            {


                conn.Open();
                //  SqlCommand cmd = new SqlCommand(cmdstring, conn);



                using (SqlDataReader reader = cmdstring.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        label7.Text = String.Format("{0}", reader[0]);
                    }
                }
                conn.Close();





            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[][] jagged_arr = new int[][]{new int[]{1,1,1}, new int[]{12,11,11},};
  
        // Initialize the elements
            //jagged_arr[0] = new int[] {1, 2, 3, 4};
            //jagged_arr[1] = new int[] {11, 34, 67};
            //jagged_arr[2] = new int[] {89, 23};
            //jagged_arr[3] = new int[] {0, 45, 78, 53, 99};
  
        // Display the array elements:
        //for (int i = 0; i < jagged_arr.Length; i++) {
  
        //    // Print the row number
        //    //System.Console.Write("Row({0}): ", j);
  
        //    for (int j = 0; j < jagged_arr[i].Length; j++) {
  
        //        // Print the elements in the row
        //        System.Console.Write("{0} ", jagged_arr[i][j]);
        //    }
        //    System.Console.WriteLine();


        //}
            string res = " ";
            foreach (int [] x in jagged_arr)
            {
                  
                foreach (int item in x)
                {
                  res+= item.ToString() + "  ";
                 }
              
            }       
                 MessageBox.Show(res);
            }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            View_customer vc = new View_customer();
            vc.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            //View_customer vc = new View_customer();
            //vc.Show();
        }
            
	
		 
	}


    }


