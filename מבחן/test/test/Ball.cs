using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Ball
    {
        public char Thechar { get; set; } = '*';
        public int Y { get; set; }
        public int X { get; set; }
        public Ball()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            //X = Randlocation.Next(0, 80);
            //Y = Randlocation.Next(0, 25);

        }
        public void Writeball()
        {
            Console.Write(Thechar);
        }




    }
}
