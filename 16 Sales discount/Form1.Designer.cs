namespace _16_Sales_discount
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
            this.label1 = new System.Windows.Forms.Label();
            this.totalWdiscountLabel = new System.Windows.Forms.Label();
            this.resultTotalwDiscount = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.resultDiscount = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.resultTotal = new System.Windows.Forms.Label();
            this.packagesTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.salesGroupBox = new System.Windows.Forms.GroupBox();
            this.salesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Packages purchased";
            // 
            // totalWdiscountLabel
            // 
            this.totalWdiscountLabel.AutoSize = true;
            this.totalWdiscountLabel.Location = new System.Drawing.Point(24, 42);
            this.totalWdiscountLabel.Name = "totalWdiscountLabel";
            this.totalWdiscountLabel.Size = new System.Drawing.Size(111, 13);
            this.totalWdiscountLabel.TabIndex = 1;
            this.totalWdiscountLabel.Text = "Total without discount";
            // 
            // resultTotalwDiscount
            // 
            this.resultTotalwDiscount.Location = new System.Drawing.Point(144, 42);
            this.resultTotalwDiscount.Name = "resultTotalwDiscount";
            this.resultTotalwDiscount.Size = new System.Drawing.Size(100, 23);
            this.resultTotalwDiscount.TabIndex = 2;
            this.resultTotalwDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(26, 80);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(49, 13);
            this.discountLabel.TabIndex = 3;
            this.discountLabel.Text = "Discount";
            // 
            // resultDiscount
            // 
            this.resultDiscount.Location = new System.Drawing.Point(144, 80);
            this.resultDiscount.Name = "resultDiscount";
            this.resultDiscount.Size = new System.Drawing.Size(100, 23);
            this.resultDiscount.TabIndex = 4;
            this.resultDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(24, 127);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total";
            // 
            // resultTotal
            // 
            this.resultTotal.Location = new System.Drawing.Point(161, 127);
            this.resultTotal.Name = "resultTotal";
            this.resultTotal.Size = new System.Drawing.Size(83, 23);
            this.resultTotal.TabIndex = 6;
            this.resultTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // packagesTextBox
            // 
            this.packagesTextBox.Location = new System.Drawing.Point(156, 20);
            this.packagesTextBox.Name = "packagesTextBox";
            this.packagesTextBox.Size = new System.Drawing.Size(147, 20);
            this.packagesTextBox.TabIndex = 1;
            this.packagesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(33, 268);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(127, 268);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(228, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // salesGroupBox
            // 
            this.salesGroupBox.Controls.Add(this.totalWdiscountLabel);
            this.salesGroupBox.Controls.Add(this.resultTotalwDiscount);
            this.salesGroupBox.Controls.Add(this.discountLabel);
            this.salesGroupBox.Controls.Add(this.resultDiscount);
            this.salesGroupBox.Controls.Add(this.totalLabel);
            this.salesGroupBox.Controls.Add(this.resultTotal);
            this.salesGroupBox.Location = new System.Drawing.Point(33, 56);
            this.salesGroupBox.Name = "salesGroupBox";
            this.salesGroupBox.Size = new System.Drawing.Size(270, 164);
            this.salesGroupBox.TabIndex = 11;
            this.salesGroupBox.TabStop = false;
            this.salesGroupBox.Text = "Sales Resume";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 325);
            this.Controls.Add(this.salesGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.packagesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sales Discount calc";
            this.salesGroupBox.ResumeLayout(false);
            this.salesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalWdiscountLabel;
        private System.Windows.Forms.Label resultTotalwDiscount;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label resultDiscount;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label resultTotal;
        private System.Windows.Forms.TextBox packagesTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox salesGroupBox;
    }
}

