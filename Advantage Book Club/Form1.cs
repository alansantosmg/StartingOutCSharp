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

    }

    private void clearButton_Click(object sender, EventArgs e)
    {

      pointsTextBox.Clear();
      consumerTextBox.Clear();
      purchasedTextBox.Clear();
      consumerTextBox.Focus();

    }

    private void exitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
