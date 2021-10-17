using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace targil_5_10
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Filtersums PaidSums = (Student student) =>{return student.Paid;};
        public Filtersums CostSums = (Student student) => { return student.Cost;};
        public FilterAverage AgeAverage = (Student student) => { return student.Age; };
        public FilterAverage GradeAverage = (Student student) => { return student.Grade; };
        public FilterStudent CheckSimilarStartFnameAndLname = (Student student) =>
         {
            if (student.FirstName[0] == student.LastName[0])
            {
                return true;
            }
            return false;
        };
        public FilterStudent Studentgrade = (Student student) =>
        {
            if (student.Grade < 50)
            {
                return true;
            }
            return false;
        };
        private void button1_Click(object sender, EventArgs e)
        {

            StudentManage.Add(idtextBox1.Text, FirstnametextBox2.Text, lastnametextBox1.Text, int.Parse(agetextBox1.Text), int.Parse(gradetextBox3.Text), int.Parse(costtextBox1.Text), int.Parse(paidtextBox2.Text));
            listBox1.Items.Clear();
            foreach (var student in StudentManage.StudentsList)
            {
                listBox1.Items.Add(student.ToString());
            }
            totalpaidtextBox1.Text = StudentManage.Sum(PaidSums).ToString();
            totalremaintopaytextBox2.Text = StudentManage.Sum(CostSums).ToString();
            totalageAveragetextBox3.Text = StudentManage.Average(AgeAverage).ToString();
            totalGradeAveragetextBox4.Text = StudentManage.Average(GradeAverage).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool remove = StudentManage.Remove(FirstnametextBox2.Text, lastnametextBox1.Text);
                if (!remove)
                {
                    MessageBox.Show("Student not found");
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (var student in StudentManage.StudentsList)
                    {
                        listBox1.Items.Add(student.ToString());
                    }
                    totalpaidtextBox1.Text = StudentManage.Sum(PaidSums).ToString();
                    totalremaintopaytextBox2.Text = StudentManage.Sum(CostSums).ToString();
                    totalageAveragetextBox3.Text = StudentManage.Average(AgeAverage).ToString();
                    totalGradeAveragetextBox4.Text = StudentManage.Average(GradeAverage).ToString();
                    MessageBox.Show("Student removed succesfully");
                }
            }
            catch
            {
                MessageBox.Show("Enter name in name text box");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudentManage.Contains(Studentgrade))
            {
                MessageBox.Show("Yes there are grades lower then 50");
            }
            else
            {
                MessageBox.Show("there are not grades lower then 50");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (StudentManage.Contains(CheckSimilarStartFnameAndLname))
            {
                MessageBox.Show("True,there are student who has similar starting letter");
            }
            else
            {
                MessageBox.Show("False,there are not student who has similar starting letter");
            }
        }
    }
}
