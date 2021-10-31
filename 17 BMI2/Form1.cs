using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_BMI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //clear form
        private void clearButton_Click(object sender, EventArgs e)
        {
            weightTextBox.Clear();
            heightTextBox.Clear();
            bmiResultLabel.Text = "";
            diagnosisResultLabel.Text = "";

        }

        // close app
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmiCalcButton_Click(object sender, EventArgs e)
        {
            // BMI factor
            // const int BMI_FACTOR = 703;            

            if(double.TryParse(weightTextBox.Text, out double weight))
            {
                if(double.TryParse(heightTextBox.Text, out double height))
                {
                    // check if height and weight are valid
                    if(height > 0 && weight > 0)
                    {
                        // calc bmi
                        // double bmi = weight * BMI_FACTOR / 

                        double bmi = weight / (height * height); 
                        bmiResultLabel.Text = bmi.ToString("N2");

                        // calc diagnosis
                        switch (bmi)
                        {
                            case var n when (n > 25.0):
                                diagnosisResultLabel.Text = "Overweight";
                                break;

                            case var n when (n  < 18.5):
                                diagnosisResultLabel.Text = "Underweight";
                                break;
                            default:
                                diagnosisResultLabel.Text = "Optimal";
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Weight and height cannot be zero nor negative!");
                    }
                }
                else
                {
                    MessageBox.Show("Input the height as valid number");
                }
            }
            else
            {
                MessageBox.Show("Input the weight as valid number");
            }
        }
    }
}
