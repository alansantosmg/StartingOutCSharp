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

            try
            {
                StreamWriter outPutFile = File.CreateText("Friend.txt");

                outPutFile.WriteLine(nameTextBox.Text);

                outPutFile.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
