using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_5___homework
{
    public partial class Form1 : Form
    {
        List<Student> liststudent = new List<Student>();
        List<Temperture> listTempertures = new List<Temperture>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                liststudent.Add(new Student(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text)));
                listBox1.Items.Add(liststudent[liststudent.Count - 1]);

            }
            catch
            {
                MessageBox.Show("Error, try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liststudent.Sort();
            listBox1.Items.Clear();
            foreach (var student in liststudent)
            {
                listBox1.Items.Add(student);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listTempertures.Add(new Temperture(textBox4.Text, new DateTime(int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text)), double.Parse(textBox8.Text), int.Parse(textBox9.Text)));
                listBox2.Items.Add(listTempertures[listTempertures.Count - 1]);
            }
            catch
            {
                MessageBox.Show("Error , try again");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listTempertures.Sort();
            listBox2.Items.Clear();
            foreach (var item in liststudent)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
