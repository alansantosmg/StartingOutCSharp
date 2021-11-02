namespace _22_Friend_file
{
    partial class Form2
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
            this.appendNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.appendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appendNameLabel
            // 
            this.appendNameLabel.AutoSize = true;
            this.appendNameLabel.Location = new System.Drawing.Point(12, 20);
            this.appendNameLabel.Name = "appendNameLabel";
            this.appendNameLabel.Size = new System.Drawing.Size(129, 13);
            this.appendNameLabel.TabIndex = 0;
            this.appendNameLabel.Text = "Add new friend (append): ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(137, 53);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(75, 23);
            this.appendButton.TabIndex = 2;
            this.appendButton.Text = "&Append file";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 53);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 100);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.appendButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.appendNameLabel);
            this.Name = "Form2";
            this.Text = "Append friend";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appendNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.Button exitButton;
    }
}