﻿namespace _22_Friend_file
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
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appendFriendLabel
            // 
            this.appendFriendLabel.AutoSize = true;
            this.appendFriendLabel.Location = new System.Drawing.Point(22, 22);
            this.appendFriendLabel.Name = "appendFriendLabel";
            this.appendFriendLabel.Size = new System.Drawing.Size(109, 13);
            this.appendFriendLabel.TabIndex = 0;
            this.appendFriendLabel.Text = "Write a friend\'s name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 19);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // writeNameButton
            // 
            this.writeNameButton.Location = new System.Drawing.Point(137, 57);
            this.writeNameButton.Name = "writeNameButton";
            this.writeNameButton.Size = new System.Drawing.Size(95, 23);
            this.writeNameButton.TabIndex = 2;
            this.writeNameButton.Text = "&Write name";
            this.writeNameButton.UseVisualStyleBackColor = true;
            this.writeNameButton.Click += new System.EventHandler(this.writeNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(251, 57);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 120);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.writeNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.appendFriendLabel);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appendFriendLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button writeNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

