using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymos_methods_lamda_ex
{
    public delegate void MyFirstDelegate();
    public delegate void Greet(string name);
    public class Program
    {
        #region 1
        static MyFirstDelegate Shalom = delegate () { Console.WriteLine("Shalom"); };
        static MyFirstDelegate Print2 = delegate () { Console.WriteLine("Another function called with same delegate"); };
        static MyFirstDelegate Print3 =  () => { Console.WriteLine("Another function called with same delegate"); };
        static MyFirstDelegate Shalom1 =  () => { Console.WriteLine("Shalom"); };
        #endregion

        #region 2
        static Greet NShalom = delegate (string name) { Console.WriteLine($"Shalom {name}"); };
        static Greet NWelcome = delegate (string name) { Console.WriteLine($"Welcome {name}"); };
        static Greet NShalom1 = (string name) => { Console.WriteLine($"Shalom {name}"); };
        static Greet NWelcome1 =  (string name) => { Console.WriteLine($"Welcome {name}"); };
        #endregion
        public static void Main(string[] args)
        {
            #region 1
            //Shalom();
            //Shalom += Print2;
            //Shalom();
            //Print2();
            #endregion;

            #region 2
            //NShalom += NWelcome;
            //NShalom("Avicii");
            #endregion

            #region 3
            // לא יכול לקרות כי הם לא מקבלים את אותם פרמטרים
            #endregion
        }
    }
}