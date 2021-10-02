
namespace WinFormsApp4
{
  partial class BirthDateString
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
      this.DayOfWeekPromptLabel = new System.Windows.Forms.Label();
      this.MonthPromptLabel = new System.Windows.Forms.Label();
      this.DayOfMonthPromptLabel = new System.Windows.Forms.Label();
      this.YearPromptLabel = new System.Windows.Forms.Label();
      this.ShowDateButton = new System.Windows.Forms.Button();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.DayOfWeekTextBox = new System.Windows.Forms.TextBox();
      this.MonthTextBox = new System.Windows.Forms.TextBox();
      this.DayOfMonthTextBox = new System.Windows.Forms.TextBox();
      this.yearTextBox = new System.Windows.Forms.TextBox();
      this.resultTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // DayOfWeekPromptLabel
      // 
      this.DayOfWeekPromptLabel.AutoSize = true;
      this.DayOfWeekPromptLabel.Location = new System.Drawing.Point(60, 45);
      this.DayOfWeekPromptLabel.Name = "DayOfWeekPromptLabel";
      this.DayOfWeekPromptLabel.Size = new System.Drawing.Size(96, 17);
      this.DayOfWeekPromptLabel.TabIndex = 0;
      this.DayOfWeekPromptLabel.Text = "Dia da Semana";
      // 
      // MonthPromptLabel
      // 
      this.MonthPromptLabel.AutoSize = true;
      this.MonthPromptLabel.Location = new System.Drawing.Point(60, 80);
      this.MonthPromptLabel.Name = "MonthPromptLabel";
      this.MonthPromptLabel.Size = new System.Drawing.Size(33, 17);
      this.MonthPromptLabel.TabIndex = 0;
      this.MonthPromptLabel.Text = "Mês";
      // 
      // DayOfMonthPromptLabel
      // 
      this.DayOfMonthPromptLabel.AutoSize = true;
      this.DayOfMonthPromptLabel.Location = new System.Drawing.Point(60, 118);
      this.DayOfMonthPromptLabel.Name = "DayOfMonthPromptLabel";
      this.DayOfMonthPromptLabel.Size = new System.Drawing.Size(75, 17);
      this.DayOfMonthPromptLabel.TabIndex = 0;
      this.DayOfMonthPromptLabel.Text = "Dia do mês";
      // 
      // YearPromptLabel
      // 
      this.YearPromptLabel.AutoSize = true;
      this.YearPromptLabel.Location = new System.Drawing.Point(60, 152);
      this.YearPromptLabel.Name = "YearPromptLabel";
      this.YearPromptLabel.Size = new System.Drawing.Size(31, 17);
      this.YearPromptLabel.TabIndex = 0;
      this.YearPromptLabel.Text = "Ano";
      // 
      // ShowDateButton
      // 
      this.ShowDateButton.Location = new System.Drawing.Point(60, 246);
      this.ShowDateButton.Name = "ShowDateButton";
      this.ShowDateButton.Size = new System.Drawing.Size(96, 23);
      this.ShowDateButton.TabIndex = 5;
      this.ShowDateButton.Text = "Mostrar data";
      this.ShowDateButton.UseVisualStyleBackColor = true;
      this.ShowDateButton.Click += new System.EventHandler(this.ShowDateButton_Click);
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(162, 246);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(96, 23);
      this.ClearButton.TabIndex = 6;
      this.ClearButton.Text = "Limpar";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(264, 246);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(96, 23);
      this.ExitButton.TabIndex = 7;
      this.ExitButton.Text = "Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // DayOfWeekTextBox
      // 
      this.DayOfWeekTextBox.Location = new System.Drawing.Point(162, 42);
      this.DayOfWeekTextBox.Name = "DayOfWeekTextBox";
      this.DayOfWeekTextBox.Size = new System.Drawing.Size(198, 25);
      this.DayOfWeekTextBox.TabIndex = 1;
      // 
      // MonthTextBox
      // 
      this.MonthTextBox.Location = new System.Drawing.Point(162, 77);
      this.MonthTextBox.Name = "MonthTextBox";
      this.MonthTextBox.Size = new System.Drawing.Size(198, 25);
      this.MonthTextBox.TabIndex = 2;
      // 
      // DayOfMonthTextBox
      // 
      this.DayOfMonthTextBox.Location = new System.Drawing.Point(162, 115);
      this.DayOfMonthTextBox.Name = "DayOfMonthTextBox";
      this.DayOfMonthTextBox.Size = new System.Drawing.Size(198, 25);
      this.DayOfMonthTextBox.TabIndex = 3;
      // 
      // yearTextBox
      // 
      this.yearTextBox.Location = new System.Drawing.Point(162, 149);
      this.yearTextBox.Name = "yearTextBox";
      this.yearTextBox.Size = new System.Drawing.Size(198, 25);
      this.yearTextBox.TabIndex = 4;
      // 
      // resultTextBox
      // 
      this.resultTextBox.Location = new System.Drawing.Point(60, 199);
      this.resultTextBox.Name = "resultTextBox";
      this.resultTextBox.ReadOnly = true;
      this.resultTextBox.Size = new System.Drawing.Size(300, 25);
      this.resultTextBox.TabIndex = 0;
      this.resultTextBox.TabStop = false;
      // 
      // BirthDateString
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(425, 309);
      this.Controls.Add(this.resultTextBox);
      this.Controls.Add(this.yearTextBox);
      this.Controls.Add(this.DayOfMonthTextBox);
      this.Controls.Add(this.MonthTextBox);
      this.Controls.Add(this.DayOfWeekTextBox);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.ClearButton);
      this.Controls.Add(this.ShowDateButton);
      this.Controls.Add(this.YearPromptLabel);
      this.Controls.Add(this.DayOfMonthPromptLabel);
      this.Controls.Add(this.MonthPromptLabel);
      this.Controls.Add(this.DayOfWeekPromptLabel);
      this.Name = "BirthDateString";
      this.Text = "Birth Date String";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label DayOfWeekPromptLabel;
    private System.Windows.Forms.Label MonthPromptLabel;
    private System.Windows.Forms.Label DayOfMonthPromptLabel;
    private System.Windows.Forms.Label YearPromptLabel;
    private System.Windows.Forms.Button ShowDateButton;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.TextBox DayOfWeekTextBox;
    private System.Windows.Forms.TextBox MonthTextBox;
    private System.Windows.Forms.TextBox DayOfMonthTextBox;
    private System.Windows.Forms.TextBox yearTextBox;
    private System.Windows.Forms.TextBox resultTextBox;
  }
}

