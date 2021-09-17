using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_homework_UI_WinForms
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber {  get; set; }
        public string City {  get; set; }
        public int PriceToPay { get; set; }
        public int PriceWhoPaid { get; set; }
        public List<Courses> CoursesWhoParticipant { get; set; }
    }
}
