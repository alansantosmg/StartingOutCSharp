using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Distance_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // close app
        private void button3_Click(object sender, EventArgs e)
        {
          this.Close();
        }

      


    private void ConvertButton_Click(object sender, EventArgs e)
    {


      // catch exception if there's no unit selected
      try
      {
        if (double.TryParse(PromptDistanceTextBox.Text, out double distance))
        {




          // select item to convert
          switch (FromListBox.SelectedItem.ToString())

          {

            // convert inches
            case "Polegadas":
              switch (ToListBox.SelectedItem.ToString())
              {
                case "Pés":
                  distance /= 12;
                  break;
                case "Jardas":
                  distance = (distance / 12) / 3;
                  break;
                case "Polegadas":
                  MessageBox.Show("Selecione uma medida diferente para conversão.");
                  break;
              }
              break;

            // convert foot
            case "Pés":
              switch (ToListBox.SelectedItem.ToString())
              {
                case "Polegadas":
                  distance /= 12;
                  break;
                case "Jardas":
                  distance /= 3;
                  break;
                case "Pés":
                  MessageBox.Show("Selecione uma medida diferente para conversão.");
                  break;
              }
              break;

            // convert yards
            case "Jardas":
              switch (ToListBox.SelectedItem.ToString())
              {
                case "Polegadas":
                  distance = (distance * 3 * 12);
                  break;
                case "Pés":
                  distance *= 3;
                  break;
                case "Jardas":
                  MessageBox.Show("Selecione uma medida diferente para conversão.");
                  break;
              }
              break;






          }

          // Show result
          ResultLabel.Text = distance.ToString();

        }
        else
        {
          // catch exceptions
          MessageBox.Show("Please, enter a valid number");
        }
      }
      catch
      {
        MessageBox.Show("Selecione as unidades para conversão.");
        
      }






      

    }
    // clear the form
    private void ClearButton_Click(object sender, EventArgs e)
    {
      ToListBox.SelectedItem = null;
      FromListBox.SelectedItem = null;
      ResultLabel.Text = "";
      PromptDistanceTextBox.Text = "";
      PromptDistanceTextBox.Focus();
    }
  }
}
