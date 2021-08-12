using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class StudentManagement
    {

        Students[] students = new Students[10000];
        public int Count { get; set; }

        public void Add(Students students)
        {
            this.students[Count] = students;
            Count++;
        }

        public Students GetStudentsById(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        public Students GetStudentsByIndex(int index)
        {

            return this.students[index];
        }
    }
}
