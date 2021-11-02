namespace _20_Ending_Balance_Form
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
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.endingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startingBalanceLabel = new System.Windows.Forms.Label();
            this.numberMonthsLabel = new System.Windows.Forms.Label();
            this.endingBalancelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(199, 43);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(169, 20);
            this.startingBalTextBox.TabIndex = 1;
            this.startingBalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(199, 87);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(169, 20);
            this.monthsTextBox.TabIndex = 2;
            this.monthsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // endingBalanceTextBox
            // 
            this.endingBalanceTextBox.Location = new System.Drawing.Point(199, 133);
            this.endingBalanceTextBox.Name = "endingBalanceTextBox";
            this.endingBalanceTextBox.ReadOnly = true;
            this.endingBalanceTextBox.Size = new System.Drawing.Size(169, 20);
            this.endingBalanceTextBox.TabIndex = 3;
            this.endingBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(91, 171);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(190, 171);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(293, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startingBalanceLabel
            // 
            this.startingBalanceLabel.AutoSize = true;
            this.startingBalanceLabel.Location = new System.Drawing.Point(88, 43);
            this.startingBalanceLabel.Name = "startingBalanceLabel";
            this.startingBalanceLabel.Size = new System.Drawing.Size(85, 13);
            this.startingBalanceLabel.TabIndex = 6;
            this.startingBalanceLabel.Text = "Starting Balance";
            // 
            // numberMonthsLabel
            // 
            this.numberMonthsLabel.AutoSize = true;
            this.numberMonthsLabel.Location = new System.Drawing.Point(88, 87);
            this.numberMonthsLabel.Name = "numberMonthsLabel";
            this.numberMonthsLabel.Size = new System.Drawing.Size(94, 13);
            this.numberMonthsLabel.TabIndex = 7;
            this.numberMonthsLabel.Text = "Number of Months";
            // 
            // endingBalancelabel
            // 
            this.endingBalancelabel.AutoSize = true;
            this.endingBalancelabel.Location = new System.Drawing.Point(91, 133);
            this.endingBalancelabel.Name = "endingBalancelabel";
            this.endingBalancelabel.Size = new System.Drawing.Size(82, 13);
            this.endingBalancelabel.TabIndex = 8;
            this.endingBalancelabel.Text = "Ending Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 237);
            this.Controls.Add(this.endingBalancelabel);
            this.Controls.Add(this.numberMonthsLabel);
            this.Controls.Add(this.startingBalanceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.endingBalanceTextBox);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Name = "Form1";
            this.Text = "Ending Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.TextBox endingBalanceTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label startingBalanceLabel;
        private System.Windows.Forms.Label numberMonthsLabel;
        private System.Windows.Forms.Label endingBalancelabel;
    }
}

