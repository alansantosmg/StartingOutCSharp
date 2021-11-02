using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_Name_List_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNamesButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Add("Alan");
            namesListBox.Items.Add("Hudson");
            namesListBox.Items.Add("Henrique");
            namesListBox.Items.Add("Alice");
        }


        private void clearNamesButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();
        }

        private void clearNumbersButton_Click(object sender, EventArgs e)
        {
            numbersListBox.Items.Clear();
        }

        private void addNumbersButton_Click_1(object sender, EventArgs e)
        {
            numbersListBox.Items.Add(10);
            numbersListBox.Items.Add(20);
            numbersListBox.Items.Add(30);

        }
    }
}
