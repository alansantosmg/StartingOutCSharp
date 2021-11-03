using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace _22_Friend_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // cath file operation errors
            try
            {
                // create streamWrite object 
                StreamWriter outPutFile = File.CreateText(@"c:\users\alans\Documents\Friend.txt");

                
                outPutFile.WriteLine(nameTextBox.Text);     // write stream to file


                outPutFile.Close();     // close the file
            }


            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);     // file error operation message
            }

        }

        private void appendButton_Click(object sender, EventArgs e)
        {
            // cath file operation errors
            try
            {
                // create streamWrite object 
                StreamWriter outPutFile = File.AppendText(@"c:\users\alans\Documents\Friend.txt");

                
                outPutFile.WriteLine(nameTextBox1.Text);   // write stream to file

               
                outPutFile.Close();   // close the file
            }


            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);   // file error operation message
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
