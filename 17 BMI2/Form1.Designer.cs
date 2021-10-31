namespace _17_BMI2
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.personGroupBox = new System.Windows.Forms.GroupBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.bmiCalcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.bmiResultLabel = new System.Windows.Forms.Label();
            this.diagnosisResultLabel = new System.Windows.Forms.Label();
            this.personGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(17, 27);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(17, 63);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height";
            // 
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.heightTextBox);
            this.personGroupBox.Controls.Add(this.weightTextBox);
            this.personGroupBox.Controls.Add(this.weightLabel);
            this.personGroupBox.Controls.Add(this.heightLabel);
            this.personGroupBox.Location = new System.Drawing.Point(36, 27);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Size = new System.Drawing.Size(237, 100);
            this.personGroupBox.TabIndex = 2;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "Person Information";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(94, 63);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 2;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(94, 27);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 1;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bmiCalcButton
            // 
            this.bmiCalcButton.Location = new System.Drawing.Point(36, 206);
            this.bmiCalcButton.Name = "bmiCalcButton";
            this.bmiCalcButton.Size = new System.Drawing.Size(75, 23);
            this.bmiCalcButton.TabIndex = 3;
            this.bmiCalcButton.Text = "&BMI Calc";
            this.bmiCalcButton.UseVisualStyleBackColor = true;
            this.bmiCalcButton.Click += new System.EventHandler(this.bmiCalcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(117, 206);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(198, 206);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(53, 145);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(29, 13);
            this.bmiLabel.TabIndex = 6;
            this.bmiLabel.Text = "BMI:";
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Location = new System.Drawing.Point(53, 173);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            this.diagnosisLabel.TabIndex = 7;
            this.diagnosisLabel.Text = "Diagnosis:";
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.Location = new System.Drawing.Point(130, 145);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(100, 23);
            this.bmiResultLabel.TabIndex = 8;
            this.bmiResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // diagnosisResultLabel
            // 
            this.diagnosisResultLabel.Location = new System.Drawing.Point(130, 173);
            this.diagnosisResultLabel.Name = "diagnosisResultLabel";
            this.diagnosisResultLabel.Size = new System.Drawing.Size(100, 23);
            this.diagnosisResultLabel.TabIndex = 9;
            this.diagnosisResultLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 268);
            this.Controls.Add(this.diagnosisResultLabel);
            this.Controls.Add(this.bmiResultLabel);
            this.Controls.Add(this.diagnosisLabel);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.bmiCalcButton);
            this.Controls.Add(this.personGroupBox);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.GroupBox personGroupBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button bmiCalcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label bmiResultLabel;
        private System.Windows.Forms.Label diagnosisResultLabel;
    }
}

