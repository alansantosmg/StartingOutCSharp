using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
  public partial class BirthDateString : Form
  {
    public BirthDateString()
    {
      InitializeComponent();
    }

  
    // Show bith date in human format
    private void ShowDateButton_Click(object sender, EventArgs e)
    {

      try 
      {
        string result = string.Concat(DayOfWeekTextBox.Text, ", ",
                              DayOfMonthTextBox.Text, " de ",
                              MonthTextBox.Text, " de ",
                              yearTextBox.Text);

        resultTextBox.Text = result;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    // Clear boxes
    private void ClearButton_Click(object sender, EventArgs e)
    {
      
      DayOfWeekTextBox.Text = "";
      DayOfMonthTextBox.Text = "";
      MonthTextBox.Text = "";
      yearTextBox.Text = "";
      resultTextBox.Text = "";

      DayOfWeekTextBox.Focus();


    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
