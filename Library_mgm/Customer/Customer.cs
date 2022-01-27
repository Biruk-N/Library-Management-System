using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_mgm
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Feedback feed = new Feedback();
            feed.Show();
            this.Hide();
        }
    }
}
