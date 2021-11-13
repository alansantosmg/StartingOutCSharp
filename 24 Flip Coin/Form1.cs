using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Flip_Coin
{


    
    public partial class Form1 : Form
    {
        private int coinfFliped = 3;

        public Form1()
        {                      
            InitializeComponent();
            faceResultPictureBox.Visible = false;
            tailResultPictureBox.Visible = false;
            facePromptBWPictureBox.Visible = false;
            tailPromptBWPictureBox.Visible = false;
            
        }

     
     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void facePromptPictureBox_Click(object sender, EventArgs e)
        {
            facePromptPictureBox.Visible = true;
            facePromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            facePromptBWPictureBox.Visible = false;

            tailPromptPictureBox.Visible = false;
            tailPromptBWPictureBox.Visible = true;
            tailPromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 0;
        }


        private void tailPromptPictureBox2_Click(object sender, EventArgs e)
        {

            tailPromptPictureBox.Visible = true;
            tailPromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            tailPromptBWPictureBox.Visible = false;


            facePromptPictureBox.Visible = false;
            facePromptBWPictureBox.Visible = true;
            facePromptBWPictureBox.BorderStyle = BorderStyle.None;
            
            coinfFliped = 1;

        }

        private void facePromptBWPictureBox_Click(object sender, EventArgs e)
        {
            facePromptPictureBox.Visible = true;
            facePromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            facePromptBWPictureBox.Visible = false;

            tailPromptPictureBox.Visible = false;
            tailPromptBWPictureBox.Visible = true;
            tailPromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 0;

        }

        private void tailPromptBWPictureBox_Click(object sender, EventArgs e)
        {
            tailPromptPictureBox.Visible = true;
            tailPromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            tailPromptBWPictureBox.Visible = false;


            facePromptPictureBox.Visible = false;
            facePromptBWPictureBox.Visible = true;
            facePromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 1;
        }
    }
}
