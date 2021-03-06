using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advantage_Book_Club
{
  public partial class PointsAwardedForm : Form
  {
    public PointsAwardedForm()
    {
      InitializeComponent();
    }

    private void calcButton_Click(object sender, EventArgs e)
    {


      if(int.TryParse(purchasedTextBox.Text, out int numberPurchased))
      {

       
        
        // Choose points following purchases
        // use pattern matching in case clauses in C# 7.3 and below

        switch (numberPurchased)
        {
          case var n when (n <=  0):
            pointsTextBox.Text = "0";
            break;
          case 1:
            pointsTextBox.Text = "5"; 
            break;
          case 2:
            pointsTextBox.Text = "15";
            break;
          case 3:
            pointsTextBox.Text = "30"; 
            break;
          case var n when (n >= 4):
            pointsTextBox.Text = "60";
            break;        
         
        }



      }
      else
      {
        MessageBox.Show("Please, input integer number");
      }














    }

    private void clearButton_Click(object sender, EventArgs e)
    {

      pointsTextBox.Clear();
     
      purchasedTextBox.Clear();
      purchasedTextBox.Focus();

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void pointsTextBox_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
