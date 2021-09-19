using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lesson7.ClassLibrary.DB
{
    public class MyDB
    {
        public static List<Student> StudentList { get; set; }

        public static List<Courses> CourseList { get; set; }= new List<Courses>() {new Courses(".NET Basic") , new Courses("OOP") , new Courses("Core"),new Courses("CSS") , new Courses("HTML")};
    }
}
