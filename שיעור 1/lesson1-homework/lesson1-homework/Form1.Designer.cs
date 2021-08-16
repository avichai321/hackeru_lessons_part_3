
using System;

namespace lesson1_homework
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxwhether = new System.Windows.Forms.TextBox();
            this.textBoxday = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "whther";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxwhether
            // 
            this.textBoxwhether.Location = new System.Drawing.Point(779, 271);
            this.textBoxwhether.Name = "textBoxwhether";
            this.textBoxwhether.Size = new System.Drawing.Size(100, 23);
            this.textBoxwhether.TabIndex = 1;
            // 
            // textBoxday
            // 
            this.textBoxday.Location = new System.Drawing.Point(779, 242);
            this.textBoxday.Name = "textBoxday";
            this.textBoxday.Size = new System.Drawing.Size(100, 23);
            this.textBoxday.TabIndex = 2;
            this.textBoxday.TextChanged += new System.EventHandler(this.textBoxday_TextChanged);
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(891, 245);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(26, 15);
            this.Day.TabIndex = 3;
            this.Day.Text = "day";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 127);
            this.button1.TabIndex = 4;
            this.button1.Text = "get wheather";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.textBoxday);
            this.Controls.Add(this.textBoxwhether);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBoxday_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxday;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxwhether;
    }
}

