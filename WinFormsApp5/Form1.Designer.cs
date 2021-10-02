
namespace WinFormsApp5
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
      this.CalculateButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.KmPromptTextBox = new System.Windows.Forms.TextBox();
      this.LitersPromptTextBox = new System.Windows.Forms.TextBox();
      this.ResultTextBox = new System.Windows.Forms.TextBox();
      this.LitersPromptLabel = new System.Windows.Forms.Label();
      this.ResultLabel = new System.Windows.Forms.Label();
      this.KmPromptLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CalculateButton
      // 
      this.CalculateButton.Location = new System.Drawing.Point(121, 178);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(86, 26);
      this.CalculateButton.TabIndex = 0;
      this.CalculateButton.Text = "Calcular";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(224, 178);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(86, 26);
      this.ExitButton.TabIndex = 1;
      this.ExitButton.Text = "Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // KmPromptTextBox
      // 
      this.KmPromptTextBox.Location = new System.Drawing.Point(224, 27);
      this.KmPromptTextBox.Name = "KmPromptTextBox";
      this.KmPromptTextBox.Size = new System.Drawing.Size(114, 26);
      this.KmPromptTextBox.TabIndex = 2;
      this.KmPromptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LitersPromptTextBox
      // 
      this.LitersPromptTextBox.Location = new System.Drawing.Point(224, 76);
      this.LitersPromptTextBox.Name = "LitersPromptTextBox";
      this.LitersPromptTextBox.Size = new System.Drawing.Size(114, 26);
      this.LitersPromptTextBox.TabIndex = 3;
      this.LitersPromptTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // ResultTextBox
      // 
      this.ResultTextBox.Location = new System.Drawing.Point(224, 124);
      this.ResultTextBox.Name = "ResultTextBox";
      this.ResultTextBox.ReadOnly = true;
      this.ResultTextBox.Size = new System.Drawing.Size(114, 26);
      this.ResultTextBox.TabIndex = 4;
      this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // LitersPromptLabel
      // 
      this.LitersPromptLabel.AutoSize = true;
      this.LitersPromptLabel.Location = new System.Drawing.Point(14, 85);
      this.LitersPromptLabel.Name = "LitersPromptLabel";
      this.LitersPromptLabel.Size = new System.Drawing.Size(175, 19);
      this.LitersPromptLabel.TabIndex = 6;
      this.LitersPromptLabel.Text = "Combustível consumido (L)";
      // 
      // ResultLabel
      // 
      this.ResultLabel.AutoSize = true;
      this.ResultLabel.Location = new System.Drawing.Point(14, 133);
      this.ResultLabel.Name = "ResultLabel";
      this.ResultLabel.Size = new System.Drawing.Size(125, 19);
      this.ResultLabel.TabIndex = 7;
      this.ResultLabel.Text = "Km por litro (km/L)";
      // 
      // KmPromptLabel
      // 
      this.KmPromptLabel.AutoSize = true;
      this.KmPromptLabel.Location = new System.Drawing.Point(14, 36);
      this.KmPromptLabel.Name = "KmPromptLabel";
      this.KmPromptLabel.Size = new System.Drawing.Size(161, 19);
      this.KmPromptLabel.TabIndex = 8;
      this.KmPromptLabel.Text = "Distância percorrida (km)";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 225);
      this.Controls.Add(this.KmPromptLabel);
      this.Controls.Add(this.ResultLabel);
      this.Controls.Add(this.LitersPromptLabel);
      this.Controls.Add(this.ResultTextBox);
      this.Controls.Add(this.LitersPromptTextBox);
      this.Controls.Add(this.KmPromptTextBox);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.CalculateButton);
      this.Name = "Form1";
      this.Text = "Consumo combústivel 1.0";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CalculateButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.TextBox KmPromptTextBox;
    private System.Windows.Forms.TextBox LitersPromptTextBox;
    private System.Windows.Forms.TextBox ResultTextBox;
    private System.Windows.Forms.Label LitersPromptLabel;
    private System.Windows.Forms.Label ResultLabel;
    private System.Windows.Forms.Label KmPromptLabel;
  }
}

