
namespace _10_Time_zone
{
  partial class TzoneForm
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
      this.CityListBox = new System.Windows.Forms.ListBox();
      this.OkButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.PromptLabel = new System.Windows.Forms.Label();
      this.Tzonelabel = new System.Windows.Forms.Label();
      this.TzoneResultLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CityListBox
      // 
      this.CityListBox.FormattingEnabled = true;
      this.CityListBox.ItemHeight = 17;
      this.CityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
      this.CityListBox.Location = new System.Drawing.Point(49, 56);
      this.CityListBox.Name = "CityListBox";
      this.CityListBox.Size = new System.Drawing.Size(178, 89);
      this.CityListBox.TabIndex = 0;
      this.CityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
      // 
      // OkButton
      // 
      this.OkButton.Location = new System.Drawing.Point(49, 203);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(76, 40);
      this.OkButton.TabIndex = 1;
      this.OkButton.Text = "&Clear";
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(151, 203);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(76, 40);
      this.ExitButton.TabIndex = 2;
      this.ExitButton.Text = "&Exit";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // PromptLabel
      // 
      this.PromptLabel.AutoSize = true;
      this.PromptLabel.Location = new System.Drawing.Point(12, 22);
      this.PromptLabel.Name = "PromptLabel";
      this.PromptLabel.Size = new System.Drawing.Size(270, 17);
      this.PromptLabel.TabIndex = 3;
      this.PromptLabel.Text = "Select a city and I will give you the time zone.";
      // 
      // Tzonelabel
      // 
      this.Tzonelabel.AutoSize = true;
      this.Tzonelabel.Location = new System.Drawing.Point(49, 166);
      this.Tzonelabel.Name = "Tzonelabel";
      this.Tzonelabel.Size = new System.Drawing.Size(72, 17);
      this.Tzonelabel.TabIndex = 4;
      this.Tzonelabel.Text = "Time Zone:";
      // 
      // TzoneResultLabel
      // 
      this.TzoneResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.TzoneResultLabel.Location = new System.Drawing.Point(127, 166);
      this.TzoneResultLabel.Name = "TzoneResultLabel";
      this.TzoneResultLabel.Size = new System.Drawing.Size(100, 19);
      this.TzoneResultLabel.TabIndex = 5;
      // 
      // TzoneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(309, 273);
      this.Controls.Add(this.TzoneResultLabel);
      this.Controls.Add(this.Tzonelabel);
      this.Controls.Add(this.PromptLabel);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.CityListBox);
      this.Name = "TzoneForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox CityListBox;
    private System.Windows.Forms.Button OkButton;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.Label PromptLabel;
    private System.Windows.Forms.Label Tzonelabel;
    private System.Windows.Forms.Label TzoneResultLabel;
  }
}

