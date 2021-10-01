using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lesson7_homework_UI_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentManagement studentAdd= new StudentManagement();
            studentAdd.Show(this);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(new StudentList());
        }
    }
}
