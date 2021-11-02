using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Friend_file
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // close app
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // create a streamWriter object
                StreamWriter outputFile;

                // Points to streawriter object to the file location
                // see the path!
                outputFile = File.AppendText(@"c:\users\alans\Documents\Friend.txt");

                // append file
                outputFile.WriteLine(nameTextBox.Text);
                outputFile.WriteLine(10);
                outputFile.WriteLine("test");


                // close file
                outputFile.Close();


            }
            catch (Exception ex)
            {
                // show message if got file error
                MessageBox.Show(ex.Message) ;
            }
        }
    }
}
