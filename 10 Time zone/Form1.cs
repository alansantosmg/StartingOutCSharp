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

    // Method to close app
    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

   
    // Method to clear the selection
    private void OkButton_Click(object sender, EventArgs e)
    {
      CityListBox.SelectedIndex = -1;
      TzoneResultLabel.Text = ""; 
    }

    // Select city and shows the timezone
    private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
    {

      // Only do a selection if exists a selected item
      if (CityListBox.SelectedIndex != -1)
      {
        
        // show timezone for a clicked list box option
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
    }
  }
}
