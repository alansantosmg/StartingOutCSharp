
namespace Teste_Score_Average_form
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
      this.TestGroupBox = new System.Windows.Forms.GroupBox();
      this.Test4Label = new System.Windows.Forms.Label();
      this.Test3Label = new System.Windows.Forms.Label();
      this.Test2Label = new System.Windows.Forms.Label();
      this.Test1Label = new System.Windows.Forms.Label();
      this.AverageTextBox = new System.Windows.Forms.TextBox();
      this.Test3TextBox = new System.Windows.Forms.TextBox();
      this.Test2TextBox = new System.Windows.Forms.TextBox();
      this.Test1TextBox = new System.Windows.Forms.TextBox();
      this.CalculateAverageButton = new System.Windows.Forms.Button();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.TestGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // TestGroupBox
      // 
      this.TestGroupBox.Controls.Add(this.Test4Label);
      this.TestGroupBox.Controls.Add(this.Test3Label);
      this.TestGroupBox.Controls.Add(this.Test2Label);
      this.TestGroupBox.Controls.Add(this.Test1Label);
      this.TestGroupBox.Controls.Add(this.AverageTextBox);
      this.TestGroupBox.Controls.Add(this.Test3TextBox);
      this.TestGroupBox.Controls.Add(this.Test2TextBox);
      this.TestGroupBox.Controls.Add(this.Test1TextBox);
      this.TestGroupBox.Location = new System.Drawing.Point(12, 26);
      this.TestGroupBox.Name = "TestGroupBox";
      this.TestGroupBox.Size = new System.Drawing.Size(301, 240);
      this.TestGroupBox.TabIndex = 0;
      this.TestGroupBox.TabStop = false;
      this.TestGroupBox.Text = "Entre com as notas das avaliações";
      // 
      // Test4Label
      // 
      this.Test4Label.AutoSize = true;
      this.Test4Label.Location = new System.Drawing.Point(72, 199);
      this.Test4Label.Name = "Test4Label";
      this.Test4Label.Size = new System.Drawing.Size(80, 19);
      this.Test4Label.TabIndex = 7;
      this.Test4Label.Text = "Nota média";
      // 
      // Test3Label
      // 
      this.Test3Label.AutoSize = true;
      this.Test3Label.Location = new System.Drawing.Point(23, 148);
      this.Test3Label.Name = "Test3Label";
      this.Test3Label.Size = new System.Drawing.Size(129, 19);
      this.Test3Label.TabIndex = 6;
      this.Test3Label.Text = "Nota da avaliação 3";
      // 
      // Test2Label
      // 
      this.Test2Label.AutoSize = true;
      this.Test2Label.Location = new System.Drawing.Point(23, 93);
      this.Test2Label.Name = "Test2Label";
      this.Test2Label.Size = new System.Drawing.Size(129, 19);
      this.Test2Label.TabIndex = 5;
      this.Test2Label.Text = "Nota da avaliação 2";
      // 
      // Test1Label
      // 
      this.Test1Label.AutoSize = true;
      this.Test1Label.Location = new System.Drawing.Point(23, 42);
      this.Test1Label.Name = "Test1Label";
      this.Test1Label.Size = new System.Drawing.Size(129, 19);
      this.Test1Label.TabIndex = 4;
      this.Test1Label.Text = "Nota da avaliação 1";
      // 
      // AverageTextBox
      // 
      this.AverageTextBox.Location = new System.Drawing.Point(174, 192);
      this.AverageTextBox.Name = "AverageTextBox";
      this.AverageTextBox.ReadOnly = true;
      this.AverageTextBox.Size = new System.Drawing.Size(80, 26);
      this.AverageTextBox.TabIndex = 3;
      this.AverageTextBox.TabStop = false;
      this.AverageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Test3TextBox
      // 
      this.Test3TextBox.Location = new System.Drawing.Point(174, 141);
      this.Test3TextBox.Name = "Test3TextBox";
      this.Test3TextBox.Size = new System.Drawing.Size(80, 26);
      this.Test3TextBox.TabIndex = 2;
      this.Test3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Test2TextBox
      // 
      this.Test2TextBox.Location = new System.Drawing.Point(174, 86);
      this.Test2TextBox.Name = "Test2TextBox";
      this.Test2TextBox.Size = new System.Drawing.Size(80, 26);
      this.Test2TextBox.TabIndex = 1;
      this.Test2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Test1TextBox
      // 
      this.Test1TextBox.Location = new System.Drawing.Point(174, 39);
      this.Test1TextBox.Name = "Test1TextBox";
      this.Test1TextBox.Size = new System.Drawing.Size(80, 26);
      this.Test1TextBox.TabIndex = 0;
      this.Test1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // CalculateAverageButton
      // 
      this.CalculateAverageButton.Location = new System.Drawing.Point(35, 283);
      this.CalculateAverageButton.Name = "CalculateAverageButton";
      this.CalculateAverageButton.Size = new System.Drawing.Size(106, 90);
      this.CalculateAverageButton.TabIndex = 4;
      this.CalculateAverageButton.Text = "&Calcular Média";
      this.CalculateAverageButton.UseVisualStyleBackColor = true;
      this.CalculateAverageButton.Click += new System.EventHandler(this.CalculateAverageButton_Click);
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(173, 283);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(107, 38);
      this.ClearButton.TabIndex = 5;
      this.ClearButton.Text = "&Limpar";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(173, 335);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(107, 38);
      this.ExitButton.TabIndex = 6;
      this.ExitButton.Text = "&Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.CalculateAverageButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ExitButton;
      this.ClientSize = new System.Drawing.Size(325, 395);
      this.Controls.Add(this.CalculateAverageButton);
      this.Controls.Add(this.ClearButton);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.TestGroupBox);
      this.Name = "Form1";
      this.Text = "Cálculo de média";
      this.TestGroupBox.ResumeLayout(false);
      this.TestGroupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox TestGroupBox;
    private System.Windows.Forms.Label Test4Label;
    private System.Windows.Forms.Label Test3Label;
    private System.Windows.Forms.Label Test2Label;
    private System.Windows.Forms.Label Test1Label;
    private System.Windows.Forms.TextBox AverageTextBox;
    private System.Windows.Forms.TextBox Test3TextBox;
    private System.Windows.Forms.TextBox Test2TextBox;
    private System.Windows.Forms.TextBox Test1TextBox;
    private System.Windows.Forms.Button CalculateAverageButton;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.Button ExitButton;
  }
}

