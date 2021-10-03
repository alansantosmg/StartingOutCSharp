
namespace WinFormsApp6
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
      this.OriginalPricePromptLabel = new System.Windows.Forms.Label();
      this.DiscPercentPromptLabel = new System.Windows.Forms.Label();
      this.SalesPricePromptLabel = new System.Windows.Forms.Label();
      this.OriginalPriceTextBox = new System.Windows.Forms.TextBox();
      this.DiscPercentTextBox = new System.Windows.Forms.TextBox();
      this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
      this.CalculateButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // OriginalPricePromptLabel
      // 
      this.OriginalPricePromptLabel.AutoSize = true;
      this.OriginalPricePromptLabel.Location = new System.Drawing.Point(14, 38);
      this.OriginalPricePromptLabel.Name = "OriginalPricePromptLabel";
      this.OriginalPricePromptLabel.Size = new System.Drawing.Size(92, 19);
      this.OriginalPricePromptLabel.TabIndex = 0;
      this.OriginalPricePromptLabel.Text = "Preço original";
      // 
      // DiscPercentPromptLabel
      // 
      this.DiscPercentPromptLabel.AutoSize = true;
      this.DiscPercentPromptLabel.Location = new System.Drawing.Point(15, 93);
      this.DiscPercentPromptLabel.Name = "DiscPercentPromptLabel";
      this.DiscPercentPromptLabel.Size = new System.Drawing.Size(151, 19);
      this.DiscPercentPromptLabel.TabIndex = 0;
      this.DiscPercentPromptLabel.Text = "Percentual de desconto";
      // 
      // SalesPricePromptLabel
      // 
      this.SalesPricePromptLabel.AutoSize = true;
      this.SalesPricePromptLabel.Location = new System.Drawing.Point(15, 142);
      this.SalesPricePromptLabel.Name = "SalesPricePromptLabel";
      this.SalesPricePromptLabel.Size = new System.Drawing.Size(103, 19);
      this.SalesPricePromptLabel.TabIndex = 0;
      this.SalesPricePromptLabel.Text = "Preço de venda";
      // 
      // OriginalPriceTextBox
      // 
      this.OriginalPriceTextBox.Location = new System.Drawing.Point(200, 29);
      this.OriginalPriceTextBox.Name = "OriginalPriceTextBox";
      this.OriginalPriceTextBox.Size = new System.Drawing.Size(130, 26);
      this.OriginalPriceTextBox.TabIndex = 0;
      this.OriginalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // DiscPercentTextBox
      // 
      this.DiscPercentTextBox.Location = new System.Drawing.Point(200, 84);
      this.DiscPercentTextBox.Name = "DiscPercentTextBox";
      this.DiscPercentTextBox.Size = new System.Drawing.Size(130, 26);
      this.DiscPercentTextBox.TabIndex = 4;
      this.DiscPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // SalesPriceTextBox
      // 
      this.SalesPriceTextBox.Location = new System.Drawing.Point(200, 133);
      this.SalesPriceTextBox.Name = "SalesPriceTextBox";
      this.SalesPriceTextBox.ReadOnly = true;
      this.SalesPriceTextBox.Size = new System.Drawing.Size(130, 26);
      this.SalesPriceTextBox.TabIndex = 5;
      this.SalesPriceTextBox.TabStop = false;
      this.SalesPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // CalculateButton
      // 
      this.CalculateButton.Location = new System.Drawing.Point(15, 187);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(165, 26);
      this.CalculateButton.TabIndex = 6;
      this.CalculateButton.Text = "Calcular";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(200, 186);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(130, 26);
      this.ExitButton.TabIndex = 7;
      this.ExitButton.Text = "Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(362, 245);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.CalculateButton);
      this.Controls.Add(this.SalesPriceTextBox);
      this.Controls.Add(this.DiscPercentTextBox);
      this.Controls.Add(this.OriginalPriceTextBox);
      this.Controls.Add(this.SalesPricePromptLabel);
      this.Controls.Add(this.DiscPercentPromptLabel);
      this.Controls.Add(this.OriginalPricePromptLabel);
      this.Name = "Form1";
      this.Text = "Discount Calculator 1.0";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label OriginalPricePromptLabel;
    private System.Windows.Forms.Label DiscPercentPromptLabel;
    private System.Windows.Forms.Label SalesPricePromptLabel;
    private System.Windows.Forms.TextBox OriginalPriceTextBox;
    private System.Windows.Forms.TextBox DiscPercentTextBox;
    private System.Windows.Forms.TextBox SalesPriceTextBox;
    private System.Windows.Forms.Button CalculateButton;
    private System.Windows.Forms.Button ExitButton;
  }
}

