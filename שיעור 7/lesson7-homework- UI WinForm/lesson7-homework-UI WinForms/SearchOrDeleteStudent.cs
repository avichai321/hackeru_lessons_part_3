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
            foreach (var course in MyDB.CourseList)
            {
                coursesAddCheckboxlist.Items.Add(course);
            }
        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            bool Exist = false;
            foreach (var student in MyDB.StudentList)
            {
                if (student.Id == searchStudentTextBox.Text || student.LastName == searchStudentTextBox.Text)
                {
                    StudentpropertyGrid.SelectedObject = student;
                    searchStudentTextBox.ReadOnly = true;
                    label2.Visible = true;
                    coursesAddCheckboxlist.Visible = true;
                    Exist = true;
                    foreach (var item in student.CoursesWhoParticipant)
                    {
                        int count = 0;
                        foreach (var item1 in coursesAddCheckboxlist.Items)
                        {
                            if (item.Name == item1.ToString())
                            {
                                coursesAddCheckboxlist.GetItemChecked(count);
                            }
                            count++;
                        }
                    }
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
            StudentpropertyGrid.SelectedObject = null;
            searchStudentTextBox.ReadOnly = false;
            coursesAddCheckboxlist.Visible = false;
            label2.Visible = false;
            MessageBox.Show("The Student has Deleated");
        }

        private void SaveChangesStudentButton_Click(object sender, EventArgs e)
        {
            foreach (var student in MyDB.StudentList)
            {
                if (student.Id == searchStudentTextBox.Text || student.LastName == searchStudentTextBox.Text)
                {
                    student.CoursesWhoParticipant.Clear();
                    foreach (var course in coursesAddCheckboxlist.CheckedItems)
                    {
                        foreach (var typeofcourse in MyDB.CourseList)
                        {
                            if (course.ToString() == typeofcourse.Name)
                            {

                                student.CoursesWhoParticipant.Add(typeofcourse);
                            }
                        }
                    }
                }
            }
            coursesAddCheckboxlist.Visible = false;
            label2.Visible = false;
            StudentpropertyGrid.SelectedObject = null;
            searchStudentTextBox.ReadOnly = false;
            MessageBox.Show("The Student has Updated");
        }

        private void StudentpropertyGrid_Click(object sender, EventArgs e)
        {

        }

        private void StudentpropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void coursesAddCheckboxlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var student in MyDB.StudentList)
            {
                if (student.Id == searchStudentTextBox.Text || student.LastName == searchStudentTextBox.Text)
                {
                    int price = 0;
                    foreach (var course in coursesAddCheckboxlist.CheckedItems)
                    {
                        foreach (var typeofcourse in MyDB.CourseList)

                        {
                            if (course.ToString() == typeofcourse.Name)
                            {
                                price += Convert.ToInt32(typeofcourse.PriceForCourse);
                            }
                        }
                    }
                    student.PriceToPay = price;
                    break;
                }

            }
        }
    }
}
