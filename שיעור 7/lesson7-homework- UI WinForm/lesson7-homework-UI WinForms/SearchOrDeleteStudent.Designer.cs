
namespace lesson7_homework_UI_WinForms
{
    partial class SearchOrDeleteStudent
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
            this.StudentpropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.searchStudentTextBox = new System.Windows.Forms.TextBox();
            this.searchStudentButton = new System.Windows.Forms.Button();
            this.SaveChangesStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentpropertyGrid
            // 
            this.StudentpropertyGrid.Location = new System.Drawing.Point(443, 29);
            this.StudentpropertyGrid.Name = "StudentpropertyGrid";
            this.StudentpropertyGrid.Size = new System.Drawing.Size(247, 360);
            this.StudentpropertyGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Typing Last Name or Id";
            // 
            // searchStudentTextBox
            // 
            this.searchStudentTextBox.Location = new System.Drawing.Point(221, 98);
            this.searchStudentTextBox.Name = "searchStudentTextBox";
            this.searchStudentTextBox.Size = new System.Drawing.Size(164, 23);
            this.searchStudentTextBox.TabIndex = 2;
            // 
            // searchStudentButton
            // 
            this.searchStudentButton.Location = new System.Drawing.Point(221, 137);
            this.searchStudentButton.Name = "searchStudentButton";
            this.searchStudentButton.Size = new System.Drawing.Size(164, 73);
            this.searchStudentButton.TabIndex = 3;
            this.searchStudentButton.Text = "Serach And Edit Student";
            this.searchStudentButton.UseVisualStyleBackColor = true;
            this.searchStudentButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // SaveChangesStudentButton
            // 
            this.SaveChangesStudentButton.Location = new System.Drawing.Point(443, 332);
            this.SaveChangesStudentButton.Name = "SaveChangesStudentButton";
            this.SaveChangesStudentButton.Size = new System.Drawing.Size(126, 57);
            this.SaveChangesStudentButton.TabIndex = 4;
            this.SaveChangesStudentButton.Text = "Save Changes";
            this.SaveChangesStudentButton.UseVisualStyleBackColor = true;
            this.SaveChangesStudentButton.Click += new System.EventHandler(this.SaveChangesStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(568, 332);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(122, 57);
            this.DeleteStudentButton.TabIndex = 5;
            this.DeleteStudentButton.Text = "Delete Student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // SearchOrDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.SaveChangesStudentButton);
            this.Controls.Add(this.searchStudentButton);
            this.Controls.Add(this.searchStudentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentpropertyGrid);
            this.Name = "SearchOrDeleteStudent";
            this.Size = new System.Drawing.Size(766, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid StudentpropertyGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchStudentTextBox;
        private System.Windows.Forms.Button searchStudentButton;
        private System.Windows.Forms.Button SaveChangesStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
    }
}
