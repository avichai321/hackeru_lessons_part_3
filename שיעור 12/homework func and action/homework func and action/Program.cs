using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_func_and_action
{
    public class Program
    {
        #region 1
        static Func<int, int, int, string> SmallNumber = (num1, num2, num3) =>
           {
               if (num1 < num2 && num1 < num3) { return $"{num1} is the smallest number"; }
               else if (num2 < num3 && num2 < num1) { return $"{num2} is the smallest number"; }
               return $"{num3} is the smallest number";

           };
        #endregion

        #region 2
        static Action<int, int, int> Average = (num1, num2, num3) =>
           {
               Console.WriteLine((num1 + num2 + num3) / 3);
           };
        #endregion

        #region 3
        static Action<string> MiddleCha = (word) =>
        {
            if (word.Length % 2 == 1) { Console.WriteLine($"The middle character in the string:{word[((word.Length - 1) / 2)]}"); }
            else { Console.WriteLine($"The middle character in the string: {word[(word.Length / 2) - 1]}{word[(word.Length / 2)]}"); }
        };
        #endregion

        #region 4
        static Action<string> Vowels = (word) =>
        {
            int vol = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'A':
                    case 'e':
                    case 'E':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'u':
                    case 'U':
                        vol++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Number of  Vowels in the string: {vol}");
        };
        #endregion

        #region 5
        static Action<string> NumberOfWords = (sentence) =>
        {
            int words = 1;
            foreach (var letter in sentence)
            {
                switch (letter)
                {
                    case ' ':
                        words++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Number of words in the string: {words}");
        };
        #endregion

        #region 6
        static Action<int> NumberOfDigit = (number) =>
         {
             int digits = 0;
             foreach (var item in number.ToString())
             {
                 digits += Convert.ToInt32(item);
             }
             Console.WriteLine($"The sum is {digits}");
         };

        #endregion

        #region 7
        //static Action<int, int> FirstFifty = (First, Second) =>
        // {
        //     double number = First + Second;
        //     for (int i = 0; i < 50; i++)
        //     {
        //         if (i == 0) { Console.Write($"{First} "); }
        //         else if (i == 1) { Console.Write($"{Second} "); }
        //         else if (i == 2) { Console.Write($"{(First + Second)*2} "); }
        //         else
        //         {
        //             number = number * 2;
        //             if ((i + 1) % 10 == 0)
        //             {
        //                 Console.Write(number + " ");
        //                 Console.WriteLine();
        //             }
        //             else
        //             {
        //                 Console.Write(number + " ");
        //             }
        //         }


        //     }
        // };
        #endregion
        public static void Main(string[] args)
        {
            Console.WriteLine(SmallNumber(25, 37, 29));
            Average(25, 45, 65);
            MiddleCha("Naruto");
            Vowels("w3resource");
            NumberOfWords("or ganon sold daniel");
            NumberOfDigit(29);
            Console.WriteLine("******************");
            //FirstFifty(1, 5);
        }
    }
}