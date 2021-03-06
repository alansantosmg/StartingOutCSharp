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
            faceResultBWPictureBox.Visible = false;
            tailResultBWPictureBox.Visible = false;

        }

     
     

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void facePromptPictureBox_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
            facePromptPictureBox.Visible = true;
            facePromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            facePromptBWPictureBox.Visible = false;

            tailPromptPictureBox.Visible = false;
            tailPromptBWPictureBox.Visible = true;
            tailPromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 0;
            questionResultLabel.Visible = true;
            tailResultPictureBox.Visible = false;
            faceResultPictureBox.Visible = false;
            faceResultBWPictureBox.Visible = false;
            tailResultBWPictureBox.Visible = false;
        }


        private void tailPromptPictureBox2_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
            tailPromptPictureBox.Visible = true;
            tailPromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            tailPromptBWPictureBox.Visible = false;


            facePromptPictureBox.Visible = false;
            facePromptBWPictureBox.Visible = true;
            facePromptBWPictureBox.BorderStyle = BorderStyle.None;
            
            coinfFliped = 1;
            questionResultLabel.Visible = true;
            tailResultPictureBox.Visible = false;
            faceResultPictureBox.Visible = false;
            faceResultBWPictureBox.Visible = false;
            tailResultBWPictureBox.Visible = false;

        }

        private void facePromptBWPictureBox_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
            facePromptPictureBox.Visible = true;
            facePromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            facePromptBWPictureBox.Visible = false;

            tailPromptPictureBox.Visible = false;
            tailPromptBWPictureBox.Visible = true;
            tailPromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 0;
            questionResultLabel.Visible = true;
            tailResultPictureBox.Visible = false;
            faceResultPictureBox.Visible = false;
            faceResultBWPictureBox.Visible = false;
            tailResultBWPictureBox.Visible = false;

        }

        private void tailPromptBWPictureBox_Click(object sender, EventArgs e)
        {
            Resultlabel.Text = "";
            tailPromptPictureBox.Visible = true;
            tailPromptPictureBox.BorderStyle = BorderStyle.Fixed3D;
            tailPromptBWPictureBox.Visible = false;


            facePromptPictureBox.Visible = false;
            facePromptBWPictureBox.Visible = true;
            facePromptBWPictureBox.BorderStyle = BorderStyle.None;

            coinfFliped = 1;
            questionResultLabel.Visible = true;
            tailResultPictureBox.Visible = false;
            faceResultPictureBox.Visible = false;
            faceResultBWPictureBox.Visible = false;
            tailResultBWPictureBox.Visible = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
         
           int computerChoice = rand.Next(2);

            if (computerChoice == coinfFliped)
            {
                questionResultLabel.Visible = false;
                Resultlabel.ForeColor = Color.Blue;
                Resultlabel.Text = "Você ganhou!";

                faceResultBWPictureBox.Visible = false;
                tailResultBWPictureBox.Visible= false;

                switch (computerChoice)
                {
                    case 0:
                        faceResultPictureBox.Visible = true;
                        break;
                    case 1:
                        tailResultPictureBox.Visible = true;
                        break;
                }


            }
            else
            {
                Resultlabel.ForeColor = Color.Red;
                Resultlabel.Text = "Você perdeu";
                tailResultPictureBox.Visible = false;
                faceResultPictureBox.Visible = false;

                switch (computerChoice)
                {
                    case 0:
                        faceResultBWPictureBox.Visible = true;
                        break;
                    case 1:
                        tailResultBWPictureBox.Visible = true;
                        break;
                }
            }

            
            
        
        }

      
    }
}
