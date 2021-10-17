using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_5_10
{
    public delegate bool FilterStudent(Student student);
    public delegate int Filtersums(Student student);
    public delegate double FilterAverage(Student student);
    public class Student
    {
        public Student(string id, string firstName, string lastName, int age, int grade, int cost, int paid)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            Cost = cost;
            Paid = paid;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public int Cost { get; set; }
        public int Paid { get; set; }



        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
    public class StudentManage
    {

        public static List<Student> StudentsList { get; set; } = new List<Student>();

        public static void Add(string id, string firstname, string lastname, int age, int grade, int cost, int paid)
        {
            StudentsList.Add(new Student(id, firstname, lastname, age, grade, cost, paid));
        }

        public static bool Remove(string firstname, string lastname)
        {
            foreach (var student in StudentsList)
            {
                if (student.FirstName == firstname && student.LastName == lastname)
                {
                    StudentsList.Remove(student);
                    return true;
                }
            }
            return false;
        }

        public static List<Student> Filter(FilterStudent filter)
        {
            List<Student> filterstudents = new List<Student>();
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (filter(StudentsList[i]))
                {
                    filterstudents.Add(StudentsList[i]);
                }
            }
            return filterstudents;
        }
        public static bool Contains(FilterStudent filter)
        {
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (filter(StudentsList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static int Sum(Filtersums filter)
        {
            int sum = 0;
            foreach (var student in StudentsList)
            {
                sum += filter(student);
            }
            return sum;

        }
        public static double Average(FilterAverage filter)
        {
            int count = 0;
            double sum = 0;
            foreach (var student in StudentsList)
            {
                sum += filter(student);
                count++;
            }
            return sum / count;
        }
    }
    
}
