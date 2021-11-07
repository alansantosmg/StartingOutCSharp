namespace _23_south_America
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.countrieslistBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countrieslistBox
            // 
            this.countrieslistBox.FormattingEnabled = true;
            this.countrieslistBox.Location = new System.Drawing.Point(32, 46);
            this.countrieslistBox.Name = "countrieslistBox";
            this.countrieslistBox.Size = new System.Drawing.Size(176, 121);
            this.countrieslistBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(232, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "The countries of South America";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Location = new System.Drawing.Point(32, 187);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(75, 47);
            this.getCountriesButton.TabIndex = 2;
            this.getCountriesButton.Text = "&Get Countries";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(133, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 47);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.countrieslistBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox countrieslistBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

