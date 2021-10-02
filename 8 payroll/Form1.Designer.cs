
namespace _8_payroll
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
      this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
      this.HourlyPayRateTExtBox = new System.Windows.Forms.TextBox();
      this.CalculateButton = new System.Windows.Forms.Button();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.GrossPayTextBox = new System.Windows.Forms.TextBox();
      this.HoursWorkedLabel = new System.Windows.Forms.Label();
      this.HourlyPayRateLabel = new System.Windows.Forms.Label();
      this.GrossPayLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // HoursWorkedTextBox
      // 
      this.HoursWorkedTextBox.Location = new System.Drawing.Point(201, 50);
      this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
      this.HoursWorkedTextBox.Size = new System.Drawing.Size(136, 26);
      this.HoursWorkedTextBox.TabIndex = 0;
      this.HoursWorkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // HourlyPayRateTExtBox
      // 
      this.HourlyPayRateTExtBox.Location = new System.Drawing.Point(201, 99);
      this.HourlyPayRateTExtBox.Name = "HourlyPayRateTExtBox";
      this.HourlyPayRateTExtBox.Size = new System.Drawing.Size(136, 26);
      this.HourlyPayRateTExtBox.TabIndex = 1;
      this.HourlyPayRateTExtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // CalculateButton
      // 
      this.CalculateButton.Location = new System.Drawing.Point(41, 202);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(100, 57);
      this.CalculateButton.TabIndex = 2;
      this.CalculateButton.Text = "&Calcular salário bruto";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(158, 202);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(100, 56);
      this.ClearButton.TabIndex = 3;
      this.ClearButton.Text = "&Limpar";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(276, 203);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(100, 56);
      this.ExitButton.TabIndex = 4;
      this.ExitButton.Text = "&Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // GrossPayTextBox
      // 
      this.GrossPayTextBox.Location = new System.Drawing.Point(201, 149);
      this.GrossPayTextBox.Name = "GrossPayTextBox";
      this.GrossPayTextBox.ReadOnly = true;
      this.GrossPayTextBox.Size = new System.Drawing.Size(136, 26);
      this.GrossPayTextBox.TabIndex = 5;
      this.GrossPayTextBox.TabStop = false;
      this.GrossPayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // HoursWorkedLabel
      // 
      this.HoursWorkedLabel.AutoSize = true;
      this.HoursWorkedLabel.Location = new System.Drawing.Point(72, 57);
      this.HoursWorkedLabel.Name = "HoursWorkedLabel";
      this.HoursWorkedLabel.Size = new System.Drawing.Size(120, 19);
      this.HoursWorkedLabel.TabIndex = 6;
      this.HoursWorkedLabel.Text = "Horas trabalhadas";
      // 
      // HourlyPayRateLabel
      // 
      this.HourlyPayRateLabel.AutoSize = true;
      this.HourlyPayRateLabel.Location = new System.Drawing.Point(72, 105);
      this.HourlyPayRateLabel.Name = "HourlyPayRateLabel";
      this.HourlyPayRateLabel.Size = new System.Drawing.Size(100, 19);
      this.HourlyPayRateLabel.TabIndex = 7;
      this.HourlyPayRateLabel.Text = "Valor hora (hh)";
      // 
      // GrossPayLabel
      // 
      this.GrossPayLabel.AutoSize = true;
      this.GrossPayLabel.Location = new System.Drawing.Point(72, 155);
      this.GrossPayLabel.Name = "GrossPayLabel";
      this.GrossPayLabel.Size = new System.Drawing.Size(87, 19);
      this.GrossPayLabel.TabIndex = 8;
      this.GrossPayLabel.Text = "Salário Bruto";
      // 
      // Form1
      // 
      this.AcceptButton = this.CalculateButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.ExitButton;
      this.ClientSize = new System.Drawing.Size(419, 285);
      this.Controls.Add(this.GrossPayLabel);
      this.Controls.Add(this.HourlyPayRateLabel);
      this.Controls.Add(this.HoursWorkedLabel);
      this.Controls.Add(this.GrossPayTextBox);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.ClearButton);
      this.Controls.Add(this.CalculateButton);
      this.Controls.Add(this.HourlyPayRateTExtBox);
      this.Controls.Add(this.HoursWorkedTextBox);
      this.Name = "Form1";
      this.Text = "Salário bruto com hora extra";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox HoursWorkedTextBox;
    private System.Windows.Forms.TextBox HourlyPayRateTExtBox;
    private System.Windows.Forms.Button CalculateButton;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.TextBox GrossPayTextBox;
    private System.Windows.Forms.Label HoursWorkedLabel;
    private System.Windows.Forms.Label HourlyPayRateLabel;
    private System.Windows.Forms.Label GrossPayLabel;
  }
}

