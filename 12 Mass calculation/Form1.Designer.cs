
namespace _12_Mass_calculation
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
      this.MassPromptTextBox = new System.Windows.Forms.TextBox();
      this.CalcButton = new System.Windows.Forms.Button();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.MassPromptLabel = new System.Windows.Forms.Label();
      this.WeightResultLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.ResultLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // MassPromptTextBox
      // 
      this.MassPromptTextBox.Location = new System.Drawing.Point(272, 55);
      this.MassPromptTextBox.Name = "MassPromptTextBox";
      this.MassPromptTextBox.Size = new System.Drawing.Size(100, 25);
      this.MassPromptTextBox.TabIndex = 0;
      // 
      // CalcButton
      // 
      this.CalcButton.Location = new System.Drawing.Point(125, 143);
      this.CalcButton.Name = "CalcButton";
      this.CalcButton.Size = new System.Drawing.Size(75, 37);
      this.CalcButton.TabIndex = 1;
      this.CalcButton.Text = "&Calculate";
      this.CalcButton.UseVisualStyleBackColor = true;
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(206, 143);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(75, 37);
      this.ClearButton.TabIndex = 2;
      this.ClearButton.Text = "Cl&ear";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(287, 143);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(75, 37);
      this.ExitButton.TabIndex = 3;
      this.ExitButton.Text = "&Exit";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // MassPromptLabel
      // 
      this.MassPromptLabel.AutoSize = true;
      this.MassPromptLabel.Location = new System.Drawing.Point(124, 62);
      this.MassPromptLabel.Name = "MassPromptLabel";
      this.MassPromptLabel.Size = new System.Drawing.Size(65, 17);
      this.MassPromptLabel.TabIndex = 4;
      this.MassPromptLabel.Text = "Mass (kg)";
      // 
      // WeightResultLabel
      // 
      this.WeightResultLabel.AutoSize = true;
      this.WeightResultLabel.Location = new System.Drawing.Point(124, 102);
      this.WeightResultLabel.Name = "WeightResultLabel";
      this.WeightResultLabel.Size = new System.Drawing.Size(137, 17);
      this.WeightResultLabel.TabIndex = 5;
      this.WeightResultLabel.Text = "Weight (SI - Newtons):";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(124, 22);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(247, 17);
      this.label3.TabIndex = 6;
      this.label3.Text = "Enter the object mass and get the weight";
      // 
      // ResultLabel
      // 
      this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ResultLabel.Location = new System.Drawing.Point(272, 102);
      this.ResultLabel.Name = "ResultLabel";
      this.ResultLabel.Size = new System.Drawing.Size(100, 23);
      this.ResultLabel.TabIndex = 7;
      // 
      // Form1
      // 
      this.AcceptButton = this.CalcButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ExitButton;
      this.ClientSize = new System.Drawing.Size(490, 221);
      this.Controls.Add(this.ResultLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.WeightResultLabel);
      this.Controls.Add(this.MassPromptLabel);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.ClearButton);
      this.Controls.Add(this.CalcButton);
      this.Controls.Add(this.MassPromptTextBox);
      this.Name = "Form1";
      this.Text = "Mass x Weight";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox MassPromptTextBox;
    private System.Windows.Forms.Button CalcButton;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.Label MassPromptLabel;
    private System.Windows.Forms.Label WeightResultLabel;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label ResultLabel;
  }
}

