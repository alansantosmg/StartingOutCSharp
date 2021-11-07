using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _23_south_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // close app
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void getCountriesButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Open file
                StreamReader inputFile;
                inputFile = File.OpenText(@"c:\intel\countries.txt");

                // if not end of file
                while (!inputFile.EndOfStream) 
                
                {
                   // get countries from file
                   countrieslistBox.Items.Add(inputFile.ReadLine()) ;
                }
                
                // close file
                inputFile.Close();

            }
            catch (Exception ex)
            {
                // if cannot open or close file
                MessageBox.Show(ex.Message);
            }

        }
    }
}
