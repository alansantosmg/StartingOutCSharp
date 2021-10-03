using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    // Get price and discount and calculate the sales price
    private void CalculateButton_Click(object sender, EventArgs e)
    {

      try
      {
        decimal originalPrice = decimal.Parse(OriginalPriceTextBox.Text);
        decimal discPercent = decimal.Parse(DiscPercentTextBox.Text);

        decimal salesPrice = originalPrice - (originalPrice * (discPercent / 100));

        SalesPriceTextBox.Text = salesPrice.ToString("c");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

     
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}

