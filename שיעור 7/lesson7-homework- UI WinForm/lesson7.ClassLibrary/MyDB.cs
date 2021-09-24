using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lesson7.ClassLibrary.DB
{
    public static class MyDB
    {
        public static List<Student> StudentList { get; set; } =new List<Student>();

        public static List<Courses> CourseList { get; set; }= new List<Courses>() {new Courses(".NET Basic",100) , new Courses("OOP",50) , new Courses("Core",150),new Courses("CSS",50) , new Courses("HTML",120)};
    }
}
