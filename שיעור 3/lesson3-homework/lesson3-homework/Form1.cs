using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson3_homework
{
    public partial class Form1 : Form
    {
        #region 2
        ReadOnlyGeneric<Student> studentsmanage = new ReadOnlyGeneric<Student>();
        ReadOnlyGeneric<Course> coursemanage = new ReadOnlyGeneric<Course>();
        #endregion
        #region 3
        Collections<int> Typeint = new Collections<int>();
        Collections<double> Typedouble = new Collections<double>();
        Collections<char> Typechar = new Collections<char>();
        Collections<string> Typestring = new Collections<string>();
        #endregion
        #region 4
        GenericId<Lecturer> listlec = new GenericId<Lecturer>();
        GenericId<Stuclass> listclass = new GenericId<Stuclass>();
        Stuclass examclass = new Stuclass();
        Lecturer examlecturer = new Lecturer();
        #endregion
        #region 7
        Classwithname basename = new Classwithname();
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentsmanage.ChangeReadOnly();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //courselist.AddToList(textBox1.Text, int.Parse(textBox2.Text));
            coursemanage.AddToList(new Course());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //studentslist.AddToList(textBox1.Text, int.Parse(textBox2.Text));
            studentsmanage.AddToList(new Student());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { 
            textBox1.Text = studentsmanage.SearchById(int.Parse(textBox2.Text));
            }
            catch
            {
                textBox1.Text = "something wrong";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text=Typeint.gettype(int.Parse(textBox3.Text));
            }
            catch
            {
                try
                {
                    textBox4.Text = Typedouble.gettype(double.Parse(textBox3.Text));
                }
                catch
                {
                    try
                    {

                    textBox4.Text = Typechar.gettype(char.Parse(textBox3.Text));
                    }
                    catch
                    {
                        textBox4.Text = Typestring.gettype(textBox3.Text);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == examclass.ToString())
            {
                listclass.add(new Stuclass());
            }
            else if(textBox7.Text == examlecturer.ToString())
             {
                listlec.add(new Lecturer());
            }
            else
            {
                textBox7.Text = "Write choise here";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Text =listlec.Searchbyid(textBox5.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = listclass.Searchbyid(textBox5.Text);
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox8.Text = basename.Name;
            textBox9.Text = basename.ToString();
        }
    }
}
