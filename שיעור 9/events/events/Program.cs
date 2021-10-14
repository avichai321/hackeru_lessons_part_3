﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace events
{
    public delegate void myDelegateEvent();
    public delegate void LuckyStudent();
    public delegate void lucky2();

    public class Program
    {
        #region 1 
        public static void PrintWrong()
        {
            Console.WriteLine("Somthing the name is too long");
        }
        public static void PrintWrite()
        {
            Console.WriteLine("The name is ok");
        }


        public static event myDelegateEvent TooLongNameEvent = PrintWrong;

        public static event myDelegateEvent NameIsOK = PrintWrite;

        #endregion

        #region 2

        public  static void PrintLucky() { Console.WriteLine("Lucky Number Was Entered");  }
        
        public static event lucky2 LuckyNumberWasEntered= PrintLucky;
        public static void Ex2()
        {
            Console.WriteLine("Enter Number: ");

            var number = int.Parse(Console.ReadLine());
            while (number != 999)
            {
                Console.WriteLine("Enter Number: ");
                number = int.Parse(Console.ReadLine());
            }
            LuckyNumberWasEntered();


        }
        #endregion

        #region 3
        public static void LuckyDisStudent() { Console.WriteLine("You Get 5% Discount"); }
        public static event LuckyStudent Discount = LuckyDisStudent;
        #endregion
        public static void Main(string[] args)
        {
            #region 1
            //Student student = new Student("Luffy");
            //if (student.Name.Length >= 8)
            //{
            //    TooLongNameEvent();
            //}
            //else
            //{
            //    NameIsOK();
            //}
            #endregion

            #region 2
            //Ex2();
            #endregion

            #region 3
            //while (StudentList.liststudent.Count != 15)
            //{
            //    Console.WriteLine("Enter Name: ");
            //    StudentList.liststudent.Add(new Student(Console.ReadLine()));
            //    if (StudentList.liststudent.Count % 5 == 0)
            //    {
            //        Discount();
            //    }
            //}


            #endregion

            #region 4
            //var point = new Point(8);
            //var square = new Square(5);

            //Console.WriteLine("Enter location you want to check");
            //Shape.Shapechecker(square, int.Parse(Console.ReadLine()));
            #endregion

            #region 7

            LuckyNumber luckyNumber = new LuckyNumber();
            luckyNumber.LuckyNumberWasEntered += MainTimes;
            luckyNumber.Ex2();
            #endregion

        }
        public static void MainTimes(object sender , int a)
        {
            Console.WriteLine($"your trys until now is: {a+1}");
        }
    }
}