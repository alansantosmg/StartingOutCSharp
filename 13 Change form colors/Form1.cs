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

            

      if (PrimaryColorBlueRadioButton.Checked && SecondaryColorBlueRadioButton.Checked) 
            {

                this.BackColor = Color.Blue;


            }else if(PrimaryColorYellowRadioButton.Checked && SecondaryColorYellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;

            }else if(PrimaryColorRedRadioButton.Checked && SecondaryColorRedRadioButton.Checked)
            {
                this.BackColor = Color.Red;

            }else if(PrimaryColorBlueRadioButton.Checked && SecondaryColorRedRadioButton.Checked)
            {
                this.BackColor = Color.Purple;

            }else if(PrimaryColorRedRadioButton.Checked && SecondaryColorBlueRadioButton.Checked)
            {
                this.BackColor = Color.Purple;

            }else if(PrimaryColorRedRadioButton.Checked && SecondaryColorYellowRadioButton.Checked)
            {
                this.BackColor= Color.Orange;

            }else if(PrimaryColorYellowRadioButton.Checked && SecondaryColorRedRadioButton.Checked)
            {
                this.BackColor = Color.Orange;

            }else if(PrimaryColorBlueRadioButton.Checked && SecondaryColorYellowRadioButton.Checked)
            {
                this.BackColor = Color.Green;

            }else if(PrimaryColorYellowRadioButton.Checked && SecondaryColorBlueRadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }else
            {
                this.BackColor = DefaultBackColor;
            }


      /*
            caso verde verde  = verde 
            caso  red blue = purple
            caso  red yellow = orange
            caso  red red = red 
            caso  blue blue = blue
            caso  blue yellow = green
            false

      */


    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
      PrimaryColorRedRadioButton.Checked = false;
      PrimaryColorYellowRadioButton.Checked = false;
      PrimaryColorBlueRadioButton.Checked = false;
      SecondaryColorRedRadioButton.Checked = false;
      SecondaryColorYellowRadioButton.Checked = false;
      SecondaryColorBlueRadioButton.Checked = false;
      PrimaryColorRedRadioButton.Focus();
    }
  }
}
