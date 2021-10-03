
namespace _11_Numeral_Converter
{
  partial class NumberToRomanForm
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
      this.ConvertGroupBox = new System.Windows.Forms.GroupBox();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ResultLabel = new System.Windows.Forms.Label();
      this.RomanLabel = new System.Windows.Forms.Label();
      this.NumeralLabel = new System.Windows.Forms.Label();
      this.ExitButton = new System.Windows.Forms.Button();
      this.ConvertButton = new System.Windows.Forms.Button();
      this.PromptNumeralTextBox = new System.Windows.Forms.TextBox();
      this.ConvertGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // ConvertGroupBox
      // 
      this.ConvertGroupBox.Controls.Add(this.ClearButton);
      this.ConvertGroupBox.Controls.Add(this.ResultLabel);
      this.ConvertGroupBox.Controls.Add(this.RomanLabel);
      this.ConvertGroupBox.Controls.Add(this.NumeralLabel);
      this.ConvertGroupBox.Controls.Add(this.ExitButton);
      this.ConvertGroupBox.Controls.Add(this.ConvertButton);
      this.ConvertGroupBox.Controls.Add(this.PromptNumeralTextBox);
      this.ConvertGroupBox.Location = new System.Drawing.Point(12, 12);
      this.ConvertGroupBox.Name = "ConvertGroupBox";
      this.ConvertGroupBox.Size = new System.Drawing.Size(319, 185);
      this.ConvertGroupBox.TabIndex = 0;
      this.ConvertGroupBox.TabStop = false;
      this.ConvertGroupBox.Text = "Type a number 1-10 to convert to Roman";
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(144, 122);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(75, 34);
      this.ClearButton.TabIndex = 2;
      this.ClearButton.Text = "Cl&ear";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // ResultLabel
      // 
      this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ResultLabel.Location = new System.Drawing.Point(138, 88);
      this.ResultLabel.Name = "ResultLabel";
      this.ResultLabel.Size = new System.Drawing.Size(49, 23);
      this.ResultLabel.TabIndex = 5;
      this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // RomanLabel
      // 
      this.RomanLabel.AutoSize = true;
      this.RomanLabel.Location = new System.Drawing.Point(62, 88);
      this.RomanLabel.Name = "RomanLabel";
      this.RomanLabel.Size = new System.Drawing.Size(52, 17);
      this.RomanLabel.TabIndex = 4;
      this.RomanLabel.Text = "Roman:";
      // 
      // NumeralLabel
      // 
      this.NumeralLabel.AutoSize = true;
      this.NumeralLabel.Location = new System.Drawing.Point(62, 51);
      this.NumeralLabel.Name = "NumeralLabel";
      this.NumeralLabel.Size = new System.Drawing.Size(61, 17);
      this.NumeralLabel.TabIndex = 3;
      this.NumeralLabel.Text = "Numeral:";
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(225, 123);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(75, 33);
      this.ExitButton.TabIndex = 3;
      this.ExitButton.Text = "E&xit";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // ConvertButton
      // 
      this.ConvertButton.Location = new System.Drawing.Point(62, 123);
      this.ConvertButton.Name = "ConvertButton";
      this.ConvertButton.Size = new System.Drawing.Size(75, 33);
      this.ConvertButton.TabIndex = 1;
      this.ConvertButton.Text = "&Convert";
      this.ConvertButton.UseVisualStyleBackColor = true;
      this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
      // 
      // PromptNumeralTextBox
      // 
      this.PromptNumeralTextBox.Location = new System.Drawing.Point(138, 43);
      this.PromptNumeralTextBox.Name = "PromptNumeralTextBox";
      this.PromptNumeralTextBox.Size = new System.Drawing.Size(49, 25);
      this.PromptNumeralTextBox.TabIndex = 0;
      this.PromptNumeralTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // NumberToRomanForm
      // 
      this.AcceptButton = this.ConvertButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.CancelButton = this.ExitButton;
      this.ClientSize = new System.Drawing.Size(346, 216);
      this.Controls.Add(this.ConvertGroupBox);
      this.Name = "NumberToRomanForm";
      this.Text = "Roman converter";
      this.ConvertGroupBox.ResumeLayout(false);
      this.ConvertGroupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox ConvertGroupBox;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.Label ResultLabel;
    private System.Windows.Forms.Label RomanLabel;
    private System.Windows.Forms.Label NumeralLabel;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.Button ConvertButton;
    private System.Windows.Forms.TextBox PromptNumeralTextBox;
  }
}

