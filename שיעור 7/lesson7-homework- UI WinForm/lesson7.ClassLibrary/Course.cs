using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.ClassLibrary.DB
{
   public class Courses
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfMeetings { get; set; }
        public int PriceForCourse { get; set; }
        public Courses()
        {

        }
        public Courses(string name,int priceForCourse)
        {
            Name = name;
            PriceForCourse = priceForCourse;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
