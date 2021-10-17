using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace targil_4
{
    public delegate int CalcDelegate (int x, int y);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public CalcDelegate Add =(int a, int b) => { return a + b; };
        public CalcDelegate sub = (int a, int b) => { return a - b; };
        public CalcDelegate Add1 = delegate (int a, int b) { return a + b; };
        public CalcDelegate sub1 = delegate (int a, int b) { return a - b; };


        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text= Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
