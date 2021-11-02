using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Ending_Balance_Form
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            startingBalTextBox.Clear();
            monthsTextBox.Clear();
            endingBalanceTextBox.Clear();
            DetailListBox.Items.Clear();
            startingBalTextBox.Focus();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            // constant for the monthly interest rate
            const decimal INTEREST_RATE = 0.005m;

            // local variables
            decimal balance;    // the account balance
            int months;         // the number of the months
            
            int count = 1;      // the loop counter

            // get starting the balance
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                // Get the mumber of the months
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    DetailListBox.Items.Clear();

                    // the following loop calculates the ending balance
                    while (count <= months)
                    {
                        // add this month's interests to the balance
                        balance = balance + (INTEREST_RATE * balance);
                        
                        
                        DetailListBox.Items.Add($"The ending balance for the month  {count} is {balance.ToString("c")}");
                        count++;

                    }

                    // display ending balance
                    endingBalanceTextBox.Text = balance.ToString("c");

                   

                }
                else
                {
                    // invalid number of months was entered
                    MessageBox.Show("Invalid value for mounths");
                }

            }
            else
            {
                // invalid balance was entered
                MessageBox.Show("Invalid value for balance");
            }






        }
    }
}
