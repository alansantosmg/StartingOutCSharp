using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
        


    private void CalculateButton_Click(object sender, EventArgs e)
    {

      double kmPrompt, litersPrompt, result; 

      if (double.TryParse(KmPromptTextBox.Text, out kmPrompt))
      {

        if(double.TryParse(LitersPromptTextBox.Text, out litersPrompt))
        {
          result = kmPrompt / litersPrompt;
          ResultTextBox.Text = result.ToString();
        }
        else
        {
          MessageBox.Show("Por favor, digite número de litros de combustível.");
        }

      }
      else 
      {
        MessageBox.Show("Por favor digite a quilometragem como número.");
      }           
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
