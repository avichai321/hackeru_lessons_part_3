using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_5_class
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 1
            List<Student> list = new List<Student>();
            list.Add(new Student("Luffy"));
            list.Add(new Student("Naruto"));
            list.Add(new Student("Goku"));
            list.Remove(list[1]);
            #endregion
            #region 2

            #endregion

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
