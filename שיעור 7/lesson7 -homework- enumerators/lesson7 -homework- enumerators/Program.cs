using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson7__homework__enumerators
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            #region 1
            for (int i = 1; i <=10; i++)
            {
                Console.Write($"{i*10} ");
            }
            Console.WriteLine("----------");
            #endregion

            #region 2
            List<int> numlist = new List<int>() { 10,20,30,40,50,60,70,80,90,100};
            foreach (var item in numlist)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("----------");
            #endregion

            #region 3 
            foreach (var item in new NumbersHezkacs(3))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("----------");
            #endregion

            #region 4
            List<Student> studentlist = new List<Student>() { new Student("avi",50), new Student("bobi", 5), new Student("naruto",90) };
            foreach (var studentGrade in new StudentsWhoParcticeALot(studentlist))
            {
                Console.WriteLine(studentGrade);
            }
            #endregion
        }
    }
}