namespace _18_Name_List_application
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
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.addNamesButton = new System.Windows.Forms.Button();
            this.addNumbersButton = new System.Windows.Forms.Button();
            this.clearNamesButton = new System.Windows.Forms.Button();
            this.clearNumbersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.Location = new System.Drawing.Point(12, 12);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(120, 95);
            this.namesListBox.TabIndex = 0;
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(162, 12);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(120, 95);
            this.numbersListBox.TabIndex = 1;
            // 
            // addNamesButton
            // 
            this.addNamesButton.Location = new System.Drawing.Point(33, 125);
            this.addNamesButton.Name = "addNamesButton";
            this.addNamesButton.Size = new System.Drawing.Size(75, 23);
            this.addNamesButton.TabIndex = 2;
            this.addNamesButton.Text = "Add";
            this.addNamesButton.UseVisualStyleBackColor = true;
            this.addNamesButton.Click += new System.EventHandler(this.addNamesButton_Click);
            // 
            // addNumbersButton
            // 
            this.addNumbersButton.Location = new System.Drawing.Point(188, 125);
            this.addNumbersButton.Name = "addNumbersButton";
            this.addNumbersButton.Size = new System.Drawing.Size(75, 23);
            this.addNumbersButton.TabIndex = 3;
            this.addNumbersButton.Text = "Add";
            this.addNumbersButton.UseVisualStyleBackColor = true;
            this.addNumbersButton.Click += new System.EventHandler(this.addNumbersButton_Click_1);
            // 
            // clearNamesButton
            // 
            this.clearNamesButton.Location = new System.Drawing.Point(33, 165);
            this.clearNamesButton.Name = "clearNamesButton";
            this.clearNamesButton.Size = new System.Drawing.Size(75, 23);
            this.clearNamesButton.TabIndex = 4;
            this.clearNamesButton.Text = "Clear";
            this.clearNamesButton.UseVisualStyleBackColor = true;
            this.clearNamesButton.Click += new System.EventHandler(this.clearNamesButton_Click);
            // 
            // clearNumbersButton
            // 
            this.clearNumbersButton.Location = new System.Drawing.Point(188, 165);
            this.clearNumbersButton.Name = "clearNumbersButton";
            this.clearNumbersButton.Size = new System.Drawing.Size(75, 23);
            this.clearNumbersButton.TabIndex = 5;
            this.clearNumbersButton.Text = "Clear";
            this.clearNumbersButton.UseVisualStyleBackColor = true;
            this.clearNumbersButton.Click += new System.EventHandler(this.clearNumbersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 201);
            this.Controls.Add(this.clearNumbersButton);
            this.Controls.Add(this.clearNamesButton);
            this.Controls.Add(this.addNumbersButton);
            this.Controls.Add(this.addNamesButton);
            this.Controls.Add(this.numbersListBox);
            this.Controls.Add(this.namesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button addNamesButton;
        private System.Windows.Forms.Button addNumbersButton;
        private System.Windows.Forms.Button clearNamesButton;
        private System.Windows.Forms.Button clearNumbersButton;
    }
}

