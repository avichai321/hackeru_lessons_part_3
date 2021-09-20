using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7.ClassLibrary.DB
{
    public class Student
    {

        public string Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName {  get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string City {  get; set; }
        public int PriceToPay { get; set; }
        public int PriceWhoPaid { get; set; }
        public List<Courses> CoursesWhoParticipant { get; set; }= new List<Courses>();
        public Student(string id, string firstName, string lastName, string phoneNumber, DateTime dOB, string email, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DOB = dOB;
            Email = email;
            City = city;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
