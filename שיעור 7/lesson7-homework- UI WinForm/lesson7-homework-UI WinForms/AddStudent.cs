using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using lesson7.ClassLibrary.DB;

namespace lesson7_homework_UI_WinForms
{
    public partial class AddStudent : UserControl
    {
        

        public AddStudent()
        {
            InitializeComponent();
            foreach (var course in MyDB.CourseList)
            {
                studentCourseListCheckedListBox.Items.Add(course);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;
            foreach (var course in studentCourseListCheckedListBox.CheckedItems)
            {
                foreach (var typeofcourse in MyDB.CourseList)
                {
                    if (course.ToString() == typeofcourse.Name)
                    {
                        price += Convert.ToInt32(typeofcourse.PriceForCourse);
                    }
                }
            }
            priceTextBox.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var mailCheck= new Regex(@"^([\w\.]+)@([\w\-]+)((\.(\w){2,3})+)$");
                bool pass = mailCheck.IsMatch(emailTextBox.Text);
                if (!pass)
                {
                    throw new MailNotGoodException();
                }

                MyDB.StudentList.Add(new Student(iDTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, dOBDateTimePicker.Value.Date, emailTextBox.Text, cityComboBox.Text,int.Parse(priceTextBox.Text), Convert.ToInt32(priceToPayNumericUpDown.Value)));
                foreach (var course in studentCourseListCheckedListBox.CheckedItems)
                {
                    foreach (var typeofcourse in MyDB.CourseList)
                    {
                        if (course.ToString() == typeofcourse.Name)
                        {
                            MyDB.StudentList[MyDB.StudentList.Count - 1].CoursesWhoParticipant.Add(typeofcourse);
                        }
                    }
                }
                
                MessageBox.Show("Student added Successfully");
            }
            catch (MailNotGoodException)
            {
                MessageBox.Show("Mail not in standarts we know");
            }
            catch
            {
                MessageBox.Show("Somthing Wrong try again");
            }
        }
    }
}
