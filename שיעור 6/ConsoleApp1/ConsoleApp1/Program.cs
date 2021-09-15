using System;
using System.Text.RegularExpressions;

namespace lesson6_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Regex reg1 = new Regex(@"^[D]");
            string print1 = "Davar";
            Console.WriteLine(reg1.IsMatch(print1));
            #endregion

            #region 2
            Regex reg2 = new Regex(@"^[JFD]");
            string print2 = "Jafar";
            Console.WriteLine(reg2.IsMatch(print2));
            #endregion

            #region 3
            Regex reg3 = new Regex(@"^[JFD]\d{6}[-]\D{2}");
            string print3 = "F123456-DD";
            Console.WriteLine(reg3.IsMatch(print3));
            #endregion
            #region 4
            string reg4 = @"([y{3}|z{5}])";
            string print4 = "yyybfzzzzz";
            print4 = Regex.Replace(print4, reg4, "");
            Console.WriteLine(print4);
            #endregion
            #region 5
            Regex reg5 = new Regex(@"^[A-Z]");
            string print5 = "Dacv";
            Console.WriteLine(reg5.IsMatch(print5));
            #endregion

            #region 6 
            Regex reg6 = new Regex(@"[ABC|abc]");
            string print6 = "abc";
            Console.WriteLine(reg6.IsMatch(print6));
            #endregion

            #region 7
            Regex reg7 = new Regex(@"\D{2,18} \D{2,18}");
            string print7 = "avichai dahan";
            Console.WriteLine(reg7.IsMatch(print7));
            #endregion

            #region 8
            Regex reg8 = new Regex(@"\d$");
            string print8 = "47";
            Console.WriteLine(reg8.IsMatch(print8));
            
            #endregion
            #region 9
            Regex reg9 = new Regex(@"^\d[.]\d{3}");
            string print9 = "3.251";
            Console.WriteLine(reg9.IsMatch(print9));
            #endregion

            #region 10
            Regex reg10 = new Regex(@"^([\w\.]+)@([gmail|yahoo]+)((\.(\w){2,3})+)$");
            string print10 = "basd213@gmail.com";
            Console.WriteLine(reg10.IsMatch(print10));
            #endregion
        }
    }
}
