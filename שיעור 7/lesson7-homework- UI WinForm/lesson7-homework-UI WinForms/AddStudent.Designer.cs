
namespace lesson7_homework_UI_WinForms
{
    partial class AddStudent
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
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentCourseListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.priceWhoNeedtoPay = new System.Windows.Forms.Label();
            this.pricePay = new System.Windows.Forms.Label();
            this.priceToPayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceToPayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Safed",
            "Jerusalem",
            "Afula",
            "Beit-Shean",
            "Tel-aviv"});
            this.cityComboBox.Location = new System.Drawing.Point(143, 212);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(162, 23);
            this.cityComboBox.TabIndex = 45;
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dOBDateTimePicker.Location = new System.Drawing.Point(143, 169);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(162, 23);
            this.dOBDateTimePicker.TabIndex = 44;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(143, 255);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 23);
            this.emailTextBox.TabIndex = 43;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(143, 131);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(162, 23);
            this.phoneNumberTextBox.TabIndex = 42;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(143, 93);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(162, 23);
            this.lastNameTextBox.TabIndex = 41;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(143, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 23);
            this.firstNameTextBox.TabIndex = 40;
            // 
            // iDTextBox
            // 
            this.iDTextBox.Location = new System.Drawing.Point(143, 16);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(162, 23);
            this.iDTextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id:";
            // 
            // studentCourseListCheckedListBox
            // 
            this.studentCourseListCheckedListBox.FormattingEnabled = true;
            this.studentCourseListCheckedListBox.Location = new System.Drawing.Point(389, 16);
            this.studentCourseListCheckedListBox.Name = "studentCourseListCheckedListBox";
            this.studentCourseListCheckedListBox.Size = new System.Drawing.Size(301, 256);
            this.studentCourseListCheckedListBox.TabIndex = 46;
            this.studentCourseListCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // priceWhoNeedtoPay
            // 
            this.priceWhoNeedtoPay.AutoSize = true;
            this.priceWhoNeedtoPay.Location = new System.Drawing.Point(28, 331);
            this.priceWhoNeedtoPay.Name = "priceWhoNeedtoPay";
            this.priceWhoNeedtoPay.Size = new System.Drawing.Size(72, 15);
            this.priceWhoNeedtoPay.TabIndex = 48;
            this.priceWhoNeedtoPay.Text = "Price to pay:";
            // 
            // pricePay
            // 
            this.pricePay.AutoSize = true;
            this.pricePay.Location = new System.Drawing.Point(28, 297);
            this.pricePay.Name = "pricePay";
            this.pricePay.Size = new System.Drawing.Size(36, 15);
            this.pricePay.TabIndex = 49;
            this.pricePay.Text = "Price:";
            // 
            // priceToPayNumericUpDown
            // 
            this.priceToPayNumericUpDown.Location = new System.Drawing.Point(143, 330);
            this.priceToPayNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceToPayNumericUpDown.Name = "priceToPayNumericUpDown";
            this.priceToPayNumericUpDown.Size = new System.Drawing.Size(162, 23);
            this.priceToPayNumericUpDown.TabIndex = 50;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(143, 291);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(162, 23);
            this.priceTextBox.TabIndex = 51;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceToPayNumericUpDown);
            this.Controls.Add(this.pricePay);
            this.Controls.Add(this.priceWhoNeedtoPay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentCourseListCheckedListBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.dOBDateTimePicker);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(734, 429);
            ((System.ComponentModel.ISupportInitialize)(this.priceToPayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox studentCourseListCheckedListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label priceWhoNeedtoPay;
        private System.Windows.Forms.Label pricePay;
        private System.Windows.Forms.NumericUpDown priceToPayNumericUpDown;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}
