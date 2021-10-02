using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Score_Average_form
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    // This method clears the form
    private void ClearButton_Click(object sender, EventArgs e)
    {
      Test1TextBox.Text = "";
      Test2TextBox.Text = "";
      Test3TextBox.Text = "";
      AverageTextBox.Text = ""; 
      Test1TextBox.Focus();
    }

    // This method close app
    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // This method calcs 3 exams average
    private void CalculateAverageButton_Click(object sender, EventArgs e)
    {
      try
      {
        // input tests results
        double test1 = double.Parse(Test1TextBox.Text);
        double test2 = double.Parse(Test2TextBox.Text);
        double test3 = double.Parse(Test3TextBox.Text);

        // calc average        
        double average  = (test1 + test2 + test3) / 3;
       

        // Show result
        AverageTextBox.Text = average.ToString("n1");

        if (average < 70)
        {          
          MessageBox.Show("Você foi reprovado. Continue se esforçando.");
        }
        else
        {
          MessageBox.Show("Você foi aprovado. Congratulações!");
        }        

      }
      catch (Exception ex)
      {                
        MessageBox.Show(ex.ToString());
      }
    }
  }
}
