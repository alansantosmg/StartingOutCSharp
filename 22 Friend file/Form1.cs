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
                StreamWriter outPutFile = File.CreateText("Friend.txt");

                // write stream to file
                outPutFile.WriteLine(nameTextBox.Text);

                // close the file
                outPutFile.Close();
            }


            catch (Exception ex)
            {
                // file error operation message
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
