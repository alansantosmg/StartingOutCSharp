using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Numeral_Converter
{
  public partial class NumberToRomanForm : Form
  {
    public NumberToRomanForm()
    {
      InitializeComponent();
    }


    // Method to closes the app
    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    // Method to clear form
    private void ClearButton_Click(object sender, EventArgs e)
    {
      PromptNumeralTextBox.Text = "";
      ResultLabel.Text = ""!;
    }



    // Method to prompt numeral and return Roman from 1 to 10. 
    private void ConvertButton_Click(object sender, EventArgs e)
    {
      
      // Test if number is a integer
     if( int.TryParse(PromptNumeralTextBox.Text, out int number))
      {

        // Convert number to roman
        switch (number)
        {
          case 1:
            ResultLabel.Text = "I";
            break;
          case 2:
            ResultLabel.Text = "II";
            break;
          case 3:
            ResultLabel.Text = "III";
            break;
          case 4:
            ResultLabel.Text = "IV";
            break;
          case 5:
            ResultLabel.Text = "V";
            break;
          case 6:
            ResultLabel.Text = "VI";
            break;
          case 7:
            ResultLabel.Text = "VII";
            break;
          case 8:
            ResultLabel.Text = "VIII";
            break;
          case 9:
            ResultLabel.Text = "IX";
            break;
          case 10:
            ResultLabel.Text = "X";
            break;
          default:
            // show message case int is not from 1 to 10
            MessageBox.Show("Enter a number from 1 to 10");
            break;

        }

      }
      else
      {
        // show message if input is not a integer
        MessageBox.Show("Enter a integer from 1 to 10");
      }
     

    }
  }
}
