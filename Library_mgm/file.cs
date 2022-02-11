using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Library_mgm
{

    class file
    {
        public static void fileto(){
         
            var fileAddress = @"C:\Users\GL COMPUTER\Desktop\Library_mgm\Feed\Biruk.txt";

            string aa = " ";
            string[] lines = File.ReadAllLines(fileAddress);
            foreach (string all in lines)
            {
                aa += all;
            }
            MessageBox.Show(aa);
          
            
        }
           
    }
}
