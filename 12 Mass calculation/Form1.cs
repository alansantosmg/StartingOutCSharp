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

    private void button2_Click(object sender, EventArgs e)
    {
      MassPromptTextBox.Text = "";
      ResultLabel.Text = "";
      MassPromptTextBox.Focus();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CalcButton_Click(object sender, EventArgs e)
    {
      if(double.TryParse(MassPromptTextBox.Text, out double mass))
      {

        const double MASS_CONSTANT = 9.8;
        double result = mass * MASS_CONSTANT;

        ResultLabel.Text = result.ToString();



        switch (result)
        {
          case > 1000:
            MessageBox.Show("Object is too heavy.");
            break;
          case < 10:
            MessageBox.Show("Object is too low");
            break;
        }


      }
      else 
      {
        MessageBox.Show("Enter a valid mass number");
      }
    }
  }
}
