using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Library_mgm
{
    public partial class Feedback : Form
    {
        
        public Feedback()
        {
            InitializeComponent();
            
           // string na = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

          

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            string na = textBox1.Text;
            StreamWriter write = new StreamWriter(@"C:\Users\GL COMPUTER\Desktop\Library_mgm\Feed\" + na + ".txt");
            write.WriteLine(textBox2.Text);
            write.Close();
        }
       
    }
}
