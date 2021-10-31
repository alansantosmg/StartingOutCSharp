using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Sales_discount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        // Close application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear form
        private void clearButton_Click(object sender, EventArgs e)
        {
            packagesTextBox.Clear();
            resultTotalwDiscount.Text = "";
            resultDiscount.Text = "";
            resultTotal.Text = "";

        }

        private void calculateButton_Click(object sender, EventArgs e)

            
        {

            // package price
            const double PRICE = 99;


            // calculate discount
            double discount = 0.0;
            if (int.TryParse(packagesTextBox.Text, out int packagesPurchased))
            {
                
                switch (packagesPurchased)
                {
                    case var n when (n >= 10 && n <=20):
                        discount = packagesPurchased * PRICE * 20 / 100;
                        break;
                    case var n when (n >= 20 && n <= 49):
                        discount = packagesPurchased * PRICE * 30 / 100;
                        break;
                    case var n when (n >= 50 && n <= 99):
                        discount = packagesPurchased * PRICE * 40 / 100;
                        break;
                    case var n when (n >= 100 ):
                        discount = packagesPurchased * PRICE * 50 / 100;
                        break;
                    default:
                        break;
                }

               
                // show results
                resultTotalwDiscount.Text = (packagesPurchased * PRICE).ToString("C");
                resultDiscount.Text = discount.ToString("C");
                resultTotal.Text = ((packagesPurchased * PRICE) - discount).ToString("C");

            }
            else 
            {
                // catch error if user don't input a valid number
                MessageBox.Show("Input a valid integer number of packages purchased");            
            }
        }
    }
}
