namespace _22_Friend_file
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
            this.appendFriendLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.writeNameButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.appendButton = new System.Windows.Forms.Button();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.appendNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // appendFriendLabel
            // 
            this.appendFriendLabel.AutoSize = true;
            this.appendFriendLabel.Location = new System.Drawing.Point(16, 20);
            this.appendFriendLabel.Name = "appendFriendLabel";
            this.appendFriendLabel.Size = new System.Drawing.Size(109, 13);
            this.appendFriendLabel.TabIndex = 0;
            this.appendFriendLabel.Text = "Write a friend\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(131, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(109, 53);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(90, 34);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "&Write name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 128);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.appendFriendLabel);
            this.tabPage1.Controls.Add(this.nameTextBox);
            this.tabPage1.Controls.Add(this.writeNameButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(312, 102);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Write to new file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.appendButton);
            this.tabPage2.Controls.Add(this.nameTextBox1);
            this.tabPage2.Controls.Add(this.appendNameLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(312, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Append to new file";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(104, 52);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(98, 33);
            this.appendButton.TabIndex = 6;
            this.appendButton.Text = "&Append file";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Location = new System.Drawing.Point(141, 17);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox1.TabIndex = 5;
            // 
            // appendNameLabel
            // 
            this.appendNameLabel.AutoSize = true;
            this.appendNameLabel.Location = new System.Drawing.Point(6, 20);
            this.appendNameLabel.Name = "appendNameLabel";
            this.appendNameLabel.Size = new System.Drawing.Size(129, 13);
            this.appendNameLabel.TabIndex = 4;
            this.appendNameLabel.Text = "Add new friend (append): ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 160);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label appendFriendLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label appendNameLabel;
    }
}

