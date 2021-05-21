
namespace Conversions
{
    partial class Conversion
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
            this.title = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.option4 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.choiceInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Tahoma", 16F);
            this.title.Location = new System.Drawing.Point(136, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(269, 39);
            this.title.TabIndex = 0;
            this.title.Text = "Linear Conversion";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(170, 83);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(182, 19);
            this.option1.TabIndex = 1;
            this.option1.Text = "1. Inches to Centimetres";
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(170, 159);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(138, 19);
            this.option3.TabIndex = 2;
            this.option3.Text = "3. Yards to Metres";
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Location = new System.Drawing.Point(170, 202);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(161, 19);
            this.option4.TabIndex = 3;
            this.option4.Text = "4. Miles to Kilometres";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(170, 120);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(165, 19);
            this.option2.TabIndex = 4;
            this.option2.Text = "2. Feet to Centimetres";
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.Location = new System.Drawing.Point(101, 261);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(217, 19);
            this.choiceLabel.TabIndex = 5;
            this.choiceLabel.Text = "Enter conversion choice (1-4)";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(101, 302);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(203, 19);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Enter value to be converted";
            // 
            // choiceInput
            // 
            this.choiceInput.Location = new System.Drawing.Point(345, 258);
            this.choiceInput.Name = "choiceInput";
            this.choiceInput.Size = new System.Drawing.Size(100, 27);
            this.choiceInput.TabIndex = 7;
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(345, 299);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 27);
            this.valueInput.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(105, 345);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(343, 28);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Lavender;
            this.outputLabel.Location = new System.Drawing.Point(105, 402);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(343, 48);
            this.outputLabel.TabIndex = 10;
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 476);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.choiceInput);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.title);
            this.Name = "Conversion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Label option4;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox choiceInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

