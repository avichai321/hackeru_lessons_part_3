
namespace HackerWe.UI
{
    partial class BooksUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksUserControl));
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BookIdtextBox1 = new System.Windows.Forms.TextBox();
            this.IdentityNumbertextBox2 = new System.Windows.Forms.TextBox();
            this.Authortextbox = new System.Windows.Forms.TextBox();
            this.BookNametextBox4 = new System.Windows.Forms.TextBox();
            this.NumberOfPagestextBox5 = new System.Windows.Forms.TextBox();
            this.NumberofcopiestextBox6 = new System.Windows.Forms.TextBox();
            this.publisheddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBookBtn.Location = new System.Drawing.Point(199, 300);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(169, 69);
            this.AddBookBtn.TabIndex = 1;
            this.AddBookBtn.Text = "Add book";
            this.AddBookBtn.UseVisualStyleBackColor = true;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdentityNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "NumberOfPages";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "NumberOfCopies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "DatePublished";
            // 
            // BookIdtextBox1
            // 
            this.BookIdtextBox1.Location = new System.Drawing.Point(184, 51);
            this.BookIdtextBox1.Name = "BookIdtextBox1";
            this.BookIdtextBox1.Size = new System.Drawing.Size(167, 23);
            this.BookIdtextBox1.TabIndex = 9;
            // 
            // IdentityNumbertextBox2
            // 
            this.IdentityNumbertextBox2.Location = new System.Drawing.Point(184, 81);
            this.IdentityNumbertextBox2.Name = "IdentityNumbertextBox2";
            this.IdentityNumbertextBox2.Size = new System.Drawing.Size(167, 23);
            this.IdentityNumbertextBox2.TabIndex = 10;
            // 
            // Authortextbox
            // 
            this.Authortextbox.Location = new System.Drawing.Point(184, 115);
            this.Authortextbox.Name = "Authortextbox";
            this.Authortextbox.Size = new System.Drawing.Size(167, 23);
            this.Authortextbox.TabIndex = 11;
            // 
            // BookNametextBox4
            // 
            this.BookNametextBox4.Location = new System.Drawing.Point(184, 154);
            this.BookNametextBox4.Name = "BookNametextBox4";
            this.BookNametextBox4.Size = new System.Drawing.Size(167, 23);
            this.BookNametextBox4.TabIndex = 12;
            // 
            // NumberOfPagestextBox5
            // 
            this.NumberOfPagestextBox5.Location = new System.Drawing.Point(184, 192);
            this.NumberOfPagestextBox5.Name = "NumberOfPagestextBox5";
            this.NumberOfPagestextBox5.Size = new System.Drawing.Size(167, 23);
            this.NumberOfPagestextBox5.TabIndex = 13;
            // 
            // NumberofcopiestextBox6
            // 
            this.NumberofcopiestextBox6.Location = new System.Drawing.Point(184, 226);
            this.NumberofcopiestextBox6.Name = "NumberofcopiestextBox6";
            this.NumberofcopiestextBox6.Size = new System.Drawing.Size(167, 23);
            this.NumberofcopiestextBox6.TabIndex = 14;
            // 
            // publisheddateTimePicker1
            // 
            this.publisheddateTimePicker1.Location = new System.Drawing.Point(184, 262);
            this.publisheddateTimePicker1.Name = "publisheddateTimePicker1";
            this.publisheddateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.publisheddateTimePicker1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(429, 300);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 69);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // BooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.publisheddateTimePicker1);
            this.Controls.Add(this.NumberofcopiestextBox6);
            this.Controls.Add(this.NumberOfPagestextBox5);
            this.Controls.Add(this.BookNametextBox4);
            this.Controls.Add(this.Authortextbox);
            this.Controls.Add(this.IdentityNumbertextBox2);
            this.Controls.Add(this.BookIdtextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBookBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BooksUserControl";
            this.Size = new System.Drawing.Size(944, 452);
            this.Load += new System.EventHandler(this.BooksUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBookBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BookIdtextBox1;
        private System.Windows.Forms.TextBox IdentityNumbertextBox2;
        private System.Windows.Forms.TextBox Authortextbox;
        private System.Windows.Forms.TextBox BookNametextBox4;
        private System.Windows.Forms.TextBox NumberOfPagestextBox5;
        private System.Windows.Forms.TextBox NumberofcopiestextBox6;
        private System.Windows.Forms.DateTimePicker publisheddateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
