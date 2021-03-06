namespace Advantage_Book_Club
{
  partial class PointsAwardedForm
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
      this.purchasedLabel = new System.Windows.Forms.Label();
      this.purchasedTextBox = new System.Windows.Forms.TextBox();
      this.pointsLabel = new System.Windows.Forms.Label();
      this.pointsTextBox = new System.Windows.Forms.TextBox();
      this.calcButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.exitButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // purchasedLabel
      // 
      this.purchasedLabel.AutoSize = true;
      this.purchasedLabel.Location = new System.Drawing.Point(34, 61);
      this.purchasedLabel.Name = "purchasedLabel";
      this.purchasedLabel.Size = new System.Drawing.Size(90, 13);
      this.purchasedLabel.TabIndex = 2;
      this.purchasedLabel.Text = "Books purchased";
      // 
      // purchasedTextBox
      // 
      this.purchasedTextBox.Location = new System.Drawing.Point(136, 58);
      this.purchasedTextBox.Name = "purchasedTextBox";
      this.purchasedTextBox.Size = new System.Drawing.Size(100, 20);
      this.purchasedTextBox.TabIndex = 1;
      this.purchasedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // pointsLabel
      // 
      this.pointsLabel.AutoSize = true;
      this.pointsLabel.Location = new System.Drawing.Point(253, 61);
      this.pointsLabel.Name = "pointsLabel";
      this.pointsLabel.Size = new System.Drawing.Size(80, 13);
      this.pointsLabel.TabIndex = 4;
      this.pointsLabel.Text = "Points awarded";
      // 
      // pointsTextBox
      // 
      this.pointsTextBox.Location = new System.Drawing.Point(355, 58);
      this.pointsTextBox.Name = "pointsTextBox";
      this.pointsTextBox.ReadOnly = true;
      this.pointsTextBox.Size = new System.Drawing.Size(100, 20);
      this.pointsTextBox.TabIndex = 0;
      this.pointsTextBox.TabStop = false;
      this.pointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.pointsTextBox.TextChanged += new System.EventHandler(this.pointsTextBox_TextChanged);
      // 
      // calcButton
      // 
      this.calcButton.Location = new System.Drawing.Point(37, 91);
      this.calcButton.Name = "calcButton";
      this.calcButton.Size = new System.Drawing.Size(199, 42);
      this.calcButton.TabIndex = 2;
      this.calcButton.Text = "&Calculate Points";
      this.calcButton.UseVisualStyleBackColor = true;
      this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.Location = new System.Drawing.Point(282, 90);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 43);
      this.clearButton.TabIndex = 3;
      this.clearButton.Text = "Cl&ear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // exitButton
      // 
      this.exitButton.Location = new System.Drawing.Point(380, 90);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(75, 43);
      this.exitButton.TabIndex = 4;
      this.exitButton.Text = "E&xit";
      this.exitButton.UseVisualStyleBackColor = true;
      this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
      // 
      // PointsAwardedForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(495, 185);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.calcButton);
      this.Controls.Add(this.pointsTextBox);
      this.Controls.Add(this.pointsLabel);
      this.Controls.Add(this.purchasedTextBox);
      this.Controls.Add(this.purchasedLabel);
      this.Name = "PointsAwardedForm";
      this.Text = "Points awarded";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label purchasedLabel;
    private System.Windows.Forms.TextBox purchasedTextBox;
    private System.Windows.Forms.Label pointsLabel;
    private System.Windows.Forms.TextBox pointsTextBox;
    private System.Windows.Forms.Button calcButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button exitButton;
  }
}

