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
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StudentManagePanel.Controls.Clear();
            StudentManagePanel.Controls.Add(new AddStudent());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StudentManagePanel.Controls.Clear();
            StudentManagePanel.Controls.Add(new SearchOrDeleteStudent());
        }
    }
}
