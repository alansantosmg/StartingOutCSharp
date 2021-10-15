using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Change_form_colors
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {

      Form1.DefaultBackColor. = Color.Red;

      switch (switch_on)
      {
        default:
      }

    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
      PrimaryColorRedRadioButton.Checked = false;
      PrimaryColorGreenRadioButton.Checked = false;
      PrimaryColorBlueRadioButton.Checked = false;
      SecondaryColorRedRadioButton.Checked = false;
      SecondaryColorGreenRadioButton.Checked = false;
      SecondaryColorBlueRadioButton.Checked = false;
      PrimaryColorRedRadioButton.Focus();
    }
  }
}
