using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trolei!!!!! KKKKKKK");
            this.Close();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            fullNameResultLabel.Text = string.Concat(
                "seu primeiro nome"," ",
                "seu sobrenome");

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = ""; 
        }
    }
}
