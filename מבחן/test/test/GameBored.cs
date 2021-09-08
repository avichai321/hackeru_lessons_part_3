using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class GameBored: Game//תוכנן בהתחלה אבל התגלה כמשבש זמן לא שומש במשחק בפועל
    {
        
        private char Limit { get; set; } = '&';

        public void WriteBored()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < GeneralPositionList.GetLength(0); i++)// יצירת גבולות הלוח
            {
                Console.SetCursorPosition(i, 25);
                Console.WriteLine(Limit);
                GeneralPositionList[i, 25] = true;// הצבת הגבולות במערך הצ'ארים הראשי
                Console.SetCursorPosition(i, 0);
                GeneralPositionList[i, 0] = true;
                Console.WriteLine(Limit);
            }
            for (int i = 0; i < GeneralPositionList.GetLength(1); i++)
            {
                Console.SetCursorPosition(80, i);
                Console.WriteLine(Limit);
                GeneralPositionList[80,i] = true;
                Console.SetCursorPosition(0, i);
                Console.WriteLine(Limit);
                GeneralPositionList[0,i] = true;
            }
        }
    }
}
