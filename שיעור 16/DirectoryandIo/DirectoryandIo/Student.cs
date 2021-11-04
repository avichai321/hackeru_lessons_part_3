using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryandIo
{
    class Student
    {
        public static List<Student> students = new List<Student>();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        static Student()
        {

            students.Add(new Student { Id = 1, Name = "Naruto", Age = 32 });
            students.Add(new Student { Id = 2, Name = "Kurama", Age = 70 });
            students.Add(new Student { Id = 3, Name = "Sakura", Age = 27 });
        }

        public static void SaveStudentTojson()
        {
            var jsonvrr = JsonSerializer.Serialize(students);
            File.WriteAllText(@"D:\לימודים דוטנט האקריו\Object Oriented Programming- C# Net Core\hackeru_lessons_part_3\שיעור 16\DirectoryandIo\DirectoryandIo\Student.json", jsonvrr);
        }

        public static string ToFixedLength()
        {
            string str;
            str = string.Format("{0:3}{1:5}{2:2}", Id, Name, Age);
            return str;
        }
        public string ToCSV()
        {
            string str;
            str = string.Format("Id:{0},Name:{1},Age:{2}", Id, Name, Age);
            return str;
        }
        public static void SaveStudentToCSV()
        {
            var str = "";
            foreach (var item in students)
            {
                str += item.ToCSV() + Environment.NewLine;
            }
            File.WriteAllText(@"D:\לימודים דוטנט האקריו\Object Oriented Programming- C# Net Core\hackeru_lessons_part_3\שיעור 16\DirectoryandIo\DirectoryandIo\Student.csv", str);
        }

        public static void ReadStudentFromCSV()
        {
          var csvstr = File.ReadAllLines( @"D:\לימודים דוטנט האקריו\Object Oriented Programming- C# Net Core\hackeru_lessons_part_3\שיעור 16\DirectoryandIo\DirectoryandIo\Student.csv").ToList();
          
        }

    }
}
