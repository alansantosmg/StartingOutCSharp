using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LanguageTranslatorForm : Form
    {
        public LanguageTranslatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
      this.InstructionLabel = new System.Windows.Forms.Label();
      this.translationLabel = new System.Windows.Forms.Label();
      this.italianButton = new System.Windows.Forms.Button();
      this.spanishButton = new System.Windows.Forms.Button();
      this.germanButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // InstructionLabel
      // 
      this.InstructionLabel.AutoSize = true;
      this.InstructionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.InstructionLabel.Location = new System.Drawing.Point(12, 9);
      this.InstructionLabel.Name = "InstructionLabel";
      this.InstructionLabel.Size = new System.Drawing.Size(291, 21);
      this.InstructionLabel.TabIndex = 0;
      this.InstructionLabel.Text = "Selecione o idioma e eu direi  \"Bom Dia\".";
      // 
      // translationLabel
      // 
      this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.translationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.translationLabel.Location = new System.Drawing.Point(12, 41);
      this.translationLabel.Name = "translationLabel";
      this.translationLabel.Size = new System.Drawing.Size(291, 30);
      this.translationLabel.TabIndex = 1;
      this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // italianButton
      // 
      this.italianButton.Location = new System.Drawing.Point(12, 78);
      this.italianButton.Name = "italianButton";
      this.italianButton.Size = new System.Drawing.Size(75, 23);
      this.italianButton.TabIndex = 0;
      this.italianButton.Text = "&Italiano";
      this.italianButton.UseVisualStyleBackColor = true;
      this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
      // 
      // spanishButton
      // 
      this.spanishButton.Location = new System.Drawing.Point(118, 78);
      this.spanishButton.Name = "spanishButton";
      this.spanishButton.Size = new System.Drawing.Size(75, 23);
      this.spanishButton.TabIndex = 2;
      this.spanishButton.Text = "&Espanhol";
      this.spanishButton.UseVisualStyleBackColor = true;
      this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
      // 
      // germanButton
      // 
      this.germanButton.Location = new System.Drawing.Point(228, 78);
      this.germanButton.Name = "germanButton";
      this.germanButton.Size = new System.Drawing.Size(75, 23);
      this.germanButton.TabIndex = 3;
      this.germanButton.Text = "&Alemão";
      this.germanButton.UseVisualStyleBackColor = true;
      this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
      // 
      // LanguageTranslatorForm
      // 
      this.ClientSize = new System.Drawing.Size(320, 113);
      this.Controls.Add(this.germanButton);
      this.Controls.Add(this.spanishButton);
      this.Controls.Add(this.italianButton);
      this.Controls.Add(this.translationLabel);
      this.Controls.Add(this.InstructionLabel);
      this.MaximumSize = new System.Drawing.Size(336, 152);
      this.MinimumSize = new System.Drawing.Size(336, 152);
      this.Name = "LanguageTranslatorForm";
      this.Text = "Translator 1.0";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buongiorno";
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Buenos Dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationLabel.Text = "Guten Morgen";
        }
    }
}
