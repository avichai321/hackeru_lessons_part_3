using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5___homework
{
    class Student : IComparable<Student>
    {
        public Student(string firstname, string lastname, int grade)
        {
            Firstname = firstname;
            Lastname = lastname;
            Grade = grade;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Grade { get; set; }

        public int CompareTo(Student? other)
        {
            if (Lastname == other.Lastname)
            {
                if (Firstname == other.Firstname)
                {
                    return Grade.CompareTo(other.Grade) * -1;
                }
                return Firstname.CompareTo(other.Firstname);
            }
            return Lastname.CompareTo(other.Lastname);
        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname} Grade: {Grade}";
        }
    }
}
