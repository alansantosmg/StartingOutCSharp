
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.fullNameLabel = new System.Windows.Forms.Label();
      this.fullNameResultLabel = new System.Windows.Forms.Label();
      this.showNameButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Location = new System.Drawing.Point(31, 70);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(160, 17);
      this.firstNameLabel.TabIndex = 0;
      this.firstNameLabel.Text = "Digite seu primeiro nome:";
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Location = new System.Drawing.Point(30, 101);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(140, 17);
      this.lastNameLabel.TabIndex = 1;
      this.lastNameLabel.Text = "Digite seu sobrenome:";
      // 
      // fullNameLabel
      // 
      this.fullNameLabel.AutoSize = true;
      this.fullNameLabel.Location = new System.Drawing.Point(31, 146);
      this.fullNameLabel.Name = "fullNameLabel";
      this.fullNameLabel.Size = new System.Drawing.Size(69, 17);
      this.fullNameLabel.TabIndex = 2;
      this.fullNameLabel.Text = "Resultado:";
      // 
      // fullNameResultLabel
      // 
      this.fullNameResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.fullNameResultLabel.Location = new System.Drawing.Point(206, 145);
      this.fullNameResultLabel.Name = "fullNameResultLabel";
      this.fullNameResultLabel.Size = new System.Drawing.Size(322, 26);
      this.fullNameResultLabel.TabIndex = 3;
      // 
      // showNameButton
      // 
      this.showNameButton.Location = new System.Drawing.Point(206, 203);
      this.showNameButton.Name = "showNameButton";
      this.showNameButton.Size = new System.Drawing.Size(101, 26);
      this.showNameButton.TabIndex = 4;
      this.showNameButton.Text = "Mostrar";
      this.showNameButton.UseVisualStyleBackColor = true;
      this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Location = new System.Drawing.Point(324, 203);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(107, 26);
      this.exitButton.TabIndex = 5;
      this.exitButton.Text = "Sair";
      this.exitButton.UseVisualStyleBackColor = true;
      this.exitButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(206, 67);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(322, 25);
      this.firstNameTextBox.TabIndex = 6;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(206, 98);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(322, 25);
      this.lastNameTextBox.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(170, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(225, 25);
      this.label1.TabIndex = 8;
      this.label1.Text = "Concatenador de textos";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(571, 257);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.showNameButton);
      this.Controls.Add(this.fullNameResultLabel);
      this.Controls.Add(this.fullNameLabel);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.firstNameLabel);
      this.Name = "Form1";
      this.Text = "Concatenador de textos";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label fullNameResultLabel;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.Label label1;
  }
}

