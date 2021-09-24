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
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
            dataGridView1.DataSource = MyDB.StudentList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
