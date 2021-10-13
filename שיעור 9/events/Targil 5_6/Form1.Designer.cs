
namespace Targil_5_6
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
            this.label2 = new System.Windows.Forms.Label();
            this.usernametextBox1 = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.Cashtouploadlabel3 = new System.Windows.Forms.Label();
            this.totalCashlabel4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.committinglabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalcashinthebanktextbox = new System.Windows.Forms.TextBox();
            this.Depositbutton1 = new System.Windows.Forms.Button();
            this.cashuploadnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Logoutbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cashuploadnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usernametextBox1
            // 
            this.usernametextBox1.Location = new System.Drawing.Point(135, 65);
            this.usernametextBox1.Name = "usernametextBox1";
            this.usernametextBox1.Size = new System.Drawing.Size(100, 23);
            this.usernametextBox1.TabIndex = 2;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(135, 98);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(100, 23);
            this.passwordtextBox2.TabIndex = 3;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(264, 65);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(100, 34);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(150, 137);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 15);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "loginLabel";
            this.loginLabel.Visible = false;
            // 
            // Cashtouploadlabel3
            // 
            this.Cashtouploadlabel3.AutoSize = true;
            this.Cashtouploadlabel3.Location = new System.Drawing.Point(35, 263);
            this.Cashtouploadlabel3.Name = "Cashtouploadlabel3";
            this.Cashtouploadlabel3.Size = new System.Drawing.Size(167, 15);
            this.Cashtouploadlabel3.TabIndex = 6;
            this.Cashtouploadlabel3.Text = "How much mouny to Deposit:";
            this.Cashtouploadlabel3.Visible = false;
            // 
            // totalCashlabel4
            // 
            this.totalCashlabel4.AutoSize = true;
            this.totalCashlabel4.Location = new System.Drawing.Point(35, 290);
            this.totalCashlabel4.Name = "totalCashlabel4";
            this.totalCashlabel4.Size = new System.Drawing.Size(90, 15);
            this.totalCashlabel4.TabIndex = 7;
            this.totalCashlabel4.Text = "User Total Cash:";
            this.totalCashlabel4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 23);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(544, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 334);
            this.listBox1.TabIndex = 10;
            // 
            // committinglabel3
            // 
            this.committinglabel3.AutoSize = true;
            this.committinglabel3.Location = new System.Drawing.Point(603, 55);
            this.committinglabel3.Name = "committinglabel3";
            this.committinglabel3.Size = new System.Drawing.Size(102, 15);
            this.committinglabel3.TabIndex = 11;
            this.committinglabel3.Text = "Committing Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Cash in the Bank:";
            // 
            // totalcashinthebanktextbox
            // 
            this.totalcashinthebanktextbox.Location = new System.Drawing.Point(664, 431);
            this.totalcashinthebanktextbox.Name = "totalcashinthebanktextbox";
            this.totalcashinthebanktextbox.ReadOnly = true;
            this.totalcashinthebanktextbox.Size = new System.Drawing.Size(116, 23);
            this.totalcashinthebanktextbox.TabIndex = 13;
            // 
            // Depositbutton1
            // 
            this.Depositbutton1.Location = new System.Drawing.Point(205, 334);
            this.Depositbutton1.Name = "Depositbutton1";
            this.Depositbutton1.Size = new System.Drawing.Size(116, 37);
            this.Depositbutton1.TabIndex = 14;
            this.Depositbutton1.Text = "Deposit";
            this.Depositbutton1.UseVisualStyleBackColor = true;
            this.Depositbutton1.Visible = false;
            this.Depositbutton1.Click += new System.EventHandler(this.Depositbutton1_Click);
            // 
            // cashuploadnumericUpDown1
            // 
            this.cashuploadnumericUpDown1.Location = new System.Drawing.Point(205, 261);
            this.cashuploadnumericUpDown1.Name = "cashuploadnumericUpDown1";
            this.cashuploadnumericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.cashuploadnumericUpDown1.TabIndex = 15;
            this.cashuploadnumericUpDown1.Visible = false;
            // 
            // Logoutbutton1
            // 
            this.Logoutbutton1.Location = new System.Drawing.Point(264, 118);
            this.Logoutbutton1.Name = "Logoutbutton1";
            this.Logoutbutton1.Size = new System.Drawing.Size(100, 34);
            this.Logoutbutton1.TabIndex = 16;
            this.Logoutbutton1.Text = "Logout";
            this.Logoutbutton1.UseVisualStyleBackColor = true;
            this.Logoutbutton1.Visible = false;
            this.Logoutbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 493);
            this.Controls.Add(this.Logoutbutton1);
            this.Controls.Add(this.cashuploadnumericUpDown1);
            this.Controls.Add(this.Depositbutton1);
            this.Controls.Add(this.totalcashinthebanktextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.committinglabel3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.totalCashlabel4);
            this.Controls.Add(this.Cashtouploadlabel3);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.usernametextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cashuploadnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametextBox1;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label Cashtouploadlabel3;
        private System.Windows.Forms.Label totalCashlabel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label committinglabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalcashinthebanktextbox;
        private System.Windows.Forms.Button Depositbutton1;
        private System.Windows.Forms.NumericUpDown cashuploadnumericUpDown1;
        private System.Windows.Forms.Button Logoutbutton1;
    }
}

