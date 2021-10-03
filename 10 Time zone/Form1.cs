using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Time_zone
{
  public partial class TzoneForm : Form
  {
    public TzoneForm()
    {
      InitializeComponent();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

   

    private void OkButton_Click(object sender, EventArgs e)
    {


      if (CityListBox.SelectedIndex != -1)
      
      {
        
        switch (CityListBox.SelectedItem.ToString())
        {
          case "Honolulu":
            TzoneResultLabel.Text = "Hawaii Aleutian";
            break;
          case "San Francisco":
            TzoneResultLabel.Text = "Pacific";
            break;
          case "Denver":
            TzoneResultLabel.Text = "Mountain";
            break;
          case "Minneapolis":
            TzoneResultLabel.Text = "Central";
            break;
          case "New York":
            TzoneResultLabel.Text = "Eastern";
            break;

        }


      }
      else
      {
        MessageBox.Show("Select a city in the box.");
      }



    }

  
  }
}
