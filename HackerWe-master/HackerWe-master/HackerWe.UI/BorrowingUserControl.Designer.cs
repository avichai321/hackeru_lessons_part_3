namespace HackerWe.UI
{
    partial class BorrowingUserControl
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
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDueReturningdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBorrowinDateValidationMessage = new System.Windows.Forms.Label();
            this.lblClientValidMessage = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.Location = new System.Drawing.Point(147, 44);
            this.dtpBorrowingDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(219, 23);
            this.dtpBorrowingDate.TabIndex = 0;
            this.dtpBorrowingDate.ValueChanged += new System.EventHandler(this.dtpBorrowingDate_ValueChanged);
            this.dtpBorrowingDate.Enter += new System.EventHandler(this.dtpBorrowingDate_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowing Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(147, 112);
            this.cmbBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(219, 23);
            this.cmbBooks.TabIndex = 3;
            this.cmbBooks.Enter += new System.EventHandler(this.dtpBorrowingDate_Enter);
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(147, 79);
            this.cmbClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(219, 23);
            this.cmbClients.TabIndex = 5;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            this.cmbClients.Enter += new System.EventHandler(this.dtpBorrowingDate_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book";
            // 
            // lblDueReturningdate
            // 
            this.lblDueReturningdate.AutoSize = true;
            this.lblDueReturningdate.Location = new System.Drawing.Point(161, 160);
            this.lblDueReturningdate.Name = "lblDueReturningdate";
            this.lblDueReturningdate.Size = new System.Drawing.Size(113, 15);
            this.lblDueReturningdate.TabIndex = 6;
            this.lblDueReturningdate.Text = "Due Returning Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Returning Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBorrowinDateValidationMessage
            // 
            this.lblBorrowinDateValidationMessage.AutoSize = true;
            this.lblBorrowinDateValidationMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBorrowinDateValidationMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblBorrowinDateValidationMessage.Location = new System.Drawing.Point(381, 45);
            this.lblBorrowinDateValidationMessage.Name = "lblBorrowinDateValidationMessage";
            this.lblBorrowinDateValidationMessage.Size = new System.Drawing.Size(0, 15);
            this.lblBorrowinDateValidationMessage.TabIndex = 9;
            // 
            // lblClientValidMessage
            // 
            this.lblClientValidMessage.AutoSize = true;
            this.lblClientValidMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblClientValidMessage.ForeColor = System.Drawing.Color.IndianRed;
            this.lblClientValidMessage.Location = new System.Drawing.Point(381, 81);
            this.lblClientValidMessage.Name = "lblClientValidMessage";
            this.lblClientValidMessage.Size = new System.Drawing.Size(107, 15);
            this.lblClientValidMessage.TabIndex = 10;
            this.lblClientValidMessage.Text = "clientValidMessage";
            // 
            // lblMessages
            // 
            this.lblMessages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMessages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessages.Location = new System.Drawing.Point(17, 274);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(558, 83);
            this.lblMessages.TabIndex = 11;
            // 
            // BorrowingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblClientValidMessage);
            this.Controls.Add(this.lblBorrowinDateValidationMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDueReturningdate);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BorrowingUserControl";
            this.Size = new System.Drawing.Size(738, 457);
            this.Load += new System.EventHandler(this.BorrowingUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBorrowingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDueReturningdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBorrowinDateValidationMessage;
        private System.Windows.Forms.Label lblClientValidMessage;
        private System.Windows.Forms.Label lblMessages;
    }
}
