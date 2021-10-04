using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Mass_calculation
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    // clear form
    private void button2_Click(object sender, EventArgs e)
    {
      MassPromptTextBox.Text = "";
      ResultLabel.Text = "";
      MassPromptTextBox.Focus();
    }

    // close app
    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CalcButton_Click(object sender, EventArgs e)
    {
      // get masss
      if(double.TryParse(MassPromptTextBox.Text, out double mass))
      {

        //calculate weight
        const double MASS_CONSTANT = 9.8;
        double result = mass * MASS_CONSTANT;

        // show result
        ResultLabel.Text = result.ToString("N2");

        // if object < 10 si or > 1000 si show message 
        switch (result)
        {
          case > 1000:
            ResultLabel.ForeColor = Color.Navy;
            MessageBox.Show("Object is too heavy.");
            
            break;
          case < 10:
            ResultLabel.ForeColor = Color.Red;
            MessageBox.Show("Object is too low");
            break;
        }     
      }
      else 
      {
        // catch exception
        MessageBox.Show("Enter a valid mass number");
      }
    }
  }
}
