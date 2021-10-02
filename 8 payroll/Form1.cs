using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_payroll
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {

      try
      {
        const decimal WEEKHOURS = 40M;
        const decimal OVERTIMEPAYRATE = 1.5M;

        decimal hoursWorked = decimal.Parse(HoursWorkedTextBox.Text);
        decimal hourlyPayRate = decimal.Parse(HourlyPayRateTExtBox.Text);
       
        decimal grossPay;
        decimal basePay;
        decimal overTimeHours;
        decimal overTimePay;


        if (hoursWorked > 40)
        {
           basePay = hourlyPayRate * WEEKHOURS;
           overTimeHours = hoursWorked - WEEKHOURS;
           overTimePay = overTimeHours * hourlyPayRate * OVERTIMEPAYRATE;

           grossPay = basePay + overTimePay;
        }
        else
        {
           grossPay = hoursWorked * hourlyPayRate;
        }

        GrossPayTextBox.Text = grossPay.ToString("c");


      }
      catch (Exception ex)
      {

        MessageBox.Show($"Digite dados válidos.\n {ex}");
      }

    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
      HourlyPayRateTExtBox.Text = "";
      HoursWorkedTextBox.Text = "";
      GrossPayTextBox.Text = "";
      HoursWorkedTextBox.Focus();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
