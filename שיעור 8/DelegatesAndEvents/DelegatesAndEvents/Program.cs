using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesAndEvents
{
    public class Program
    {
        public static void Print2()
        {
            Console.WriteLine("Another function called with same delegate");
        }
        public static void shalom()
        {
            Console.WriteLine("Shalom");
        }

        public static void shalom(string name)
        {
            Console.WriteLine($"Shalom {name}");
        }
        public static void Welcome(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyFirstDelegate myFirstDelegate= new MyFirstDelegate(shalom);
            myFirstDelegate();
            MyFirstDelegate mySecondDelegate = new MyFirstDelegate(Print2);
            mySecondDelegate();
            Greet greet = new Greet(shalom);
            greet("Avicii");
            Greet greet2 = new Greet(Welcome);
            greet2("Naruto");
        }
    }
}