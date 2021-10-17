namespace _14_Distance_Converter
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
      this.PromptTitleLabel = new System.Windows.Forms.Label();
      this.PromptDistanceTextBox = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FromListBox = new System.Windows.Forms.ListBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.ToListBox = new System.Windows.Forms.ListBox();
      this.ResultTitleLabel = new System.Windows.Forms.Label();
      this.ResultLabel = new System.Windows.Forms.Label();
      this.ConvertButton = new System.Windows.Forms.Button();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ExitButton = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // PromptTitleLabel
      // 
      this.PromptTitleLabel.AutoSize = true;
      this.PromptTitleLabel.Location = new System.Drawing.Point(40, 33);
      this.PromptTitleLabel.Name = "PromptTitleLabel";
      this.PromptTitleLabel.Size = new System.Drawing.Size(160, 13);
      this.PromptTitleLabel.TabIndex = 0;
      this.PromptTitleLabel.Text = "Entre com distância a converter:";
      // 
      // PromptDistanceTextBox
      // 
      this.PromptDistanceTextBox.Location = new System.Drawing.Point(261, 30);
      this.PromptDistanceTextBox.Name = "PromptDistanceTextBox";
      this.PromptDistanceTextBox.Size = new System.Drawing.Size(74, 20);
      this.PromptDistanceTextBox.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.FromListBox);
      this.groupBox1.Location = new System.Drawing.Point(43, 70);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(140, 96);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "De";
      // 
      // FromListBox
      // 
      this.FromListBox.FormattingEnabled = true;
      this.FromListBox.Items.AddRange(new object[] {
            "Polegadas",
            "Pés",
            "Jardas"});
      this.FromListBox.Location = new System.Drawing.Point(28, 29);
      this.FromListBox.Name = "FromListBox";
      this.FromListBox.Size = new System.Drawing.Size(73, 43);
      this.FromListBox.TabIndex = 2;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.ToListBox);
      this.groupBox2.Location = new System.Drawing.Point(195, 70);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(140, 96);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Para";
      // 
      // ToListBox
      // 
      this.ToListBox.FormattingEnabled = true;
      this.ToListBox.Items.AddRange(new object[] {
            "Polegadas",
            "Pés",
            "Jardas"});
      this.ToListBox.Location = new System.Drawing.Point(29, 29);
      this.ToListBox.Name = "ToListBox";
      this.ToListBox.Size = new System.Drawing.Size(76, 43);
      this.ToListBox.TabIndex = 3;
      // 
      // ResultTitleLabel
      // 
      this.ResultTitleLabel.AutoSize = true;
      this.ResultTitleLabel.Location = new System.Drawing.Point(68, 183);
      this.ResultTitleLabel.Name = "ResultTitleLabel";
      this.ResultTitleLabel.Size = new System.Drawing.Size(107, 13);
      this.ResultTitleLabel.TabIndex = 4;
      this.ResultTitleLabel.Text = "Distância convertida:";
      // 
      // ResultLabel
      // 
      this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ResultLabel.Location = new System.Drawing.Point(224, 182);
      this.ResultLabel.Name = "ResultLabel";
      this.ResultLabel.Size = new System.Drawing.Size(74, 20);
      this.ResultLabel.TabIndex = 5;
      this.ResultLabel.Text = "label3";
      // 
      // ConvertButton
      // 
      this.ConvertButton.Location = new System.Drawing.Point(71, 217);
      this.ConvertButton.Name = "ConvertButton";
      this.ConvertButton.Size = new System.Drawing.Size(75, 23);
      this.ConvertButton.TabIndex = 4;
      this.ConvertButton.Text = "&Converter";
      this.ConvertButton.UseVisualStyleBackColor = true;
      this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
      // 
      // ClearButton
      // 
      this.ClearButton.Location = new System.Drawing.Point(152, 217);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(75, 23);
      this.ClearButton.TabIndex = 5;
      this.ClearButton.Text = "&Limpar";
      this.ClearButton.UseVisualStyleBackColor = true;
      this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // ExitButton
      // 
      this.ExitButton.Location = new System.Drawing.Point(233, 217);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(75, 23);
      this.ExitButton.TabIndex = 6;
      this.ExitButton.Text = "&Sair";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(379, 281);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.ClearButton);
      this.Controls.Add(this.ConvertButton);
      this.Controls.Add(this.ResultLabel);
      this.Controls.Add(this.ResultTitleLabel);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.PromptDistanceTextBox);
      this.Controls.Add(this.PromptTitleLabel);
      this.Name = "Form1";
      this.Text = "Conversor de distância";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptTitleLabel;
        private System.Windows.Forms.TextBox PromptDistanceTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox FromListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ToListBox;
        private System.Windows.Forms.Label ResultTitleLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

