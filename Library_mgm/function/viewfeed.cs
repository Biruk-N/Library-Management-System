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
    public partial class viewfeed : Form
    {
        public viewfeed()
        {
            InitializeComponent();
            InitializeCombox();
        }

        private void InitializeCombox()
        {

            var filename = @"C:\Users\GL COMPUTER\Desktop\Library_mgm\Feed\*";
            c1.Items.Add(filename);
           
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            file.fileto();
            
        }
    }
}
