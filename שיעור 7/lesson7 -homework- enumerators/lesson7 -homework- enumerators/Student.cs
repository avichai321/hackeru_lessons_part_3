using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7__homework__enumerators
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public Student(string name,int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
