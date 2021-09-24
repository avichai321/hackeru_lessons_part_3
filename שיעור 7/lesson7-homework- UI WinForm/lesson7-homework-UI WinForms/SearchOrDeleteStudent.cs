using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lesson7.ClassLibrary.DB;

namespace lesson7_homework_UI_WinForms
{
    public partial class SearchOrDeleteStudent : UserControl
    {
        public SearchOrDeleteStudent()
        {
            InitializeComponent();
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            bool Exist=false;
            foreach (var student in MyDB.StudentList)
            {
                if (student.Id== searchStudentTextBox.Text||student.LastName== searchStudentTextBox.Text )
                {
                    StudentpropertyGrid.SelectedObject= student;
                    searchStudentTextBox.ReadOnly=true;
                    Exist = true;
                    break;
                }
            }
            if (!Exist)
            {
                MessageBox.Show("Student not Found");
            }
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            foreach (var student in MyDB.StudentList)
            {
                if (student.Id == searchStudentTextBox.Text || student.LastName == searchStudentTextBox.Text)
                {
                    MyDB.StudentList.Remove(student);
                    break;
                }
            }
            StudentpropertyGrid.SelectedObject= null;
            searchStudentTextBox.ReadOnly = false;
            MessageBox.Show("The Student has Deleated");
        }

        private void SaveChangesStudentButton_Click(object sender, EventArgs e)
        {
            StudentpropertyGrid.SelectedObject = null;
            searchStudentTextBox.ReadOnly = false;
            MessageBox.Show("The Student has Updated");
        }

       
    }
}
