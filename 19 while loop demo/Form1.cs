using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_while_loop_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {

            int i = 0;
            while ( i < 5) 
            {
                MessageBox.Show("You have been deceived!");
                i++;             

            }
        }
    }
}
