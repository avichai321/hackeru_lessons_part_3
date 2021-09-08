using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Ball
    {
        public char Thechar { get; private set; } = '*';
        
       
        public void Writeball(ref int X ,ref int Y)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleKeyInfo Move;
            Move = Console.ReadKey(true);
            switch (Move.Key)
            {
                case ConsoleKey.UpArrow:
                    Y--;
                    break;
                case ConsoleKey.DownArrow:
                    Y++;
                    break;
                case ConsoleKey.LeftArrow:
                    X--;
                    break;
                case ConsoleKey.RightArrow:
                    X++;
                    break;

            }
            Console.SetCursorPosition(X, Y);
            Console.Write(Thechar);

        }




    }
}
