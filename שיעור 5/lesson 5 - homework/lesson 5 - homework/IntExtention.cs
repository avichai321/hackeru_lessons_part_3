using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5___homework
{
   public static class IntExtention
    {
        public static string Print(this int number)
        {
            string[] numberaha = {"" ,"zero", "one", "tow", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] numbersasa = { "teen", "twenty", "thirty", "fourty", "fivty", "sixty", "siventy", "eighty", "Ninety" };
            if (number>=0 && number <= 10)
            {
                return numberaha[number + 1];
            }
            if (number == 100)
            {
                return "One-Hundrend";
            }
            if (number== 11)
            {
                return "Eleven";
            }
            if (number == 12)
            {
                return "Twelve";
            }
            if (number == 13)
            {
                return "Thirteen";
            }
            if (number == 15)
            {
                return "fifthteen";
            }
            if (number > 20)
            {
                return $"{numberaha[number - 9]} {numbersasa[0]}";
            }
            if (number <= 100 && number % 10 == 0)
            {
                return $"{numbersasa[number / 10 - 1]}";
            }
            if (number <= 100)
            {
                return $"{numbersasa[number / 10 - 1]} {numberaha[number % 10 + 1]}";
            }
            return "Ad Kan";



        }
        public static double MultipleBy(this int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
