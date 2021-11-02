using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_Km_to_miles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            // close app

            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            // clear listbox

            outputListBox.Items.Clear();


        }

        private void displayButton_Click(object sender, EventArgs e)
        {

            const double MILES_CONST = 0.6214;

            // Clear listbox case it's not cleared when button is pressed. 

            if (outputListBox.Items.Count > 0)
            {
                outputListBox.Items.Clear();
            } 


             
            // Convert Km to miles from 60 to 130 km

            for (int kph = 60; kph <= 130; kph = kph + 10)
            {
                double mph = kph * MILES_CONST;

                outputListBox.Items.Add($"Kilometers: {kph} - Miles: {mph}");
            } 

            
        }
    }
}
