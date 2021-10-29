
namespace Week_6_Activity_14
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.fontSize = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Black = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.RadioButton();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.checkUnder = new System.Windows.Forms.CheckBox();
            this.checkItalic = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter any text here:";
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 39);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(557, 241);
            this.textBox.TabIndex = 2;
            // 
            // fontSize
            // 
            this.fontSize.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSize.FormattingEnabled = true;
            this.fontSize.ItemHeight = 20;
            this.fontSize.Items.AddRange(new object[] {
            "   10",
            "   12",
            "   14",
            "   16",
            "   18",
            "   20"});
            this.fontSize.Location = new System.Drawing.Point(19, 323);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(61, 124);
            this.fontSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Font Size";
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Black.Location = new System.Drawing.Point(155, 323);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(60, 20);
            this.Black.TabIndex = 6;
            this.Black.TabStop = true;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue.Location = new System.Drawing.Point(155, 375);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(53, 20);
            this.Blue.TabIndex = 6;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green.Location = new System.Drawing.Point(155, 401);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(63, 20);
            this.Green.TabIndex = 6;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red.Location = new System.Drawing.Point(155, 349);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(52, 20);
            this.Red.TabIndex = 6;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBold.Location = new System.Drawing.Point(282, 326);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(59, 20);
            this.checkBold.TabIndex = 8;
            this.checkBold.Text = "Bold";
            this.checkBold.UseVisualStyleBackColor = true;
            // 
            // checkUnder
            // 
            this.checkUnder.AutoSize = true;
            this.checkUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUnder.Location = new System.Drawing.Point(282, 352);
            this.checkUnder.Name = "checkUnder";
            this.checkUnder.Size = new System.Drawing.Size(93, 20);
            this.checkUnder.TabIndex = 8;
            this.checkUnder.Text = "Underlined";
            this.checkUnder.UseVisualStyleBackColor = true;
            // 
            // checkItalic
            // 
            this.checkItalic.AutoSize = true;
            this.checkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkItalic.Location = new System.Drawing.Point(282, 378);
            this.checkItalic.Name = "checkItalic";
            this.checkItalic.Size = new System.Drawing.Size(54, 20);
            this.checkItalic.TabIndex = 8;
            this.checkItalic.Text = "Italic";
            this.checkItalic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Effect";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(469, 294);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 39);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Go";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(469, 349);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 39);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(593, 473);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkItalic);
            this.Controls.Add(this.checkUnder);
            this.Controls.Add(this.checkBold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Visual Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox fontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.CheckBox checkUnder;
        private System.Windows.Forms.CheckBox checkItalic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

