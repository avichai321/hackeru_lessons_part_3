using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Game
    {
        public bool[,] GeneralPositionList { get; private set; } = new bool[81, 26];//  מערך המשחק השלם
        private Random Rand1 { get; set; } = new Random();// יצירת ההגרלה במשחק
        private List<BasicShape> ShapelistStart = new List<BasicShape>(4);
        public List<BasicShape> Shapelistgame { get; set; } = new List<BasicShape>(15); // רשימה שמרכזת את הצורות במשחק
        public int Countshapes { get; set; }// מספר הצורות במשחק
        public int Trys { get; set; } = 0;//נסיונות לבניית לוח
        public bool CheckShape { get; set; }// מאפיין שבודק אם הצורות חופפות או לא
        public int Points { get; set; }// מספר הנקודות שהשחקן מרוויח במשחק

        public Game()
        {
            Countshapes = Rand1.Next(3, 6);
            ShapelistStart.Add(new Rectangle());
            ShapelistStart.Add(new Triangle());
            ShapelistStart.Add(new Line());
            ShapelistStart.Add(new Square());
        }


        public void Gamestart()
        {
            Console.SetWindowSize(81, 26);
            int XBall, YBall;

            Ball ball = new Ball();
            while (Countshapes != 15 && Trys != 30)// תנאי סף להמשך המשחק
            {
                GeneralPositionList.CleanBoolArray();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                for (int i = 0; i < Countshapes; i++)// יצירת הצורות
                {
                    int rollShape = Rand1.Next(0, 3);
                    Shapelistgame.Add(ShapelistStart[rollShape]);
                }
                foreach (var shape in Shapelistgame)// תהליך יצירת המורות במשחק
                {
                    shape.GenerateShapes();
                    CheckShape = GeneralPositionList.AddInnerArrayToMainArray(shape.Shapeposition);// בדיקה אם הצורות חופפות
                    if (CheckShape == false)// במקרה והצורות חופפות
                    {
                        Console.Clear();
                        Shapelistgame.Clear();
                        GeneralPositionList.CleanBoolArray();
                        Trys++;
                        break;
                    }
                }
                if (CheckShape == true)// תנאי להצבת הכדור אם הצורות לא חופפות
                {
                    try// ווידוי שהכדור לא עובר את הגבולות 
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        XBall = Rand1.Next(1, 79);// הגרלת מיקום הכדור על ציר האיקס
                        YBall = Rand1.Next(1, 24);// הגרלת מיקום הכדור על ציר הוואי
                        Console.SetCursorPosition(XBall, YBall);
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(ball.Thechar);
                        while (GeneralPositionList[XBall, YBall] != true)// ווידוי שהכדור לא נופל על צורה 
                        {
                            GeneralPositionList[XBall, YBall] = true;
                            ball.Writeball(ref XBall, ref YBall);
                            Points++;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;// הפיכת צבע המסך חזרה לשחור קונסול
                        Countshapes++;
                        Trys = 0;
                    }
                    catch// במידה ועבר את הגבולות
                    {
                        Countshapes++;
                        Trys = 0;
                        continue;
                    }
                }
            }
            if (Countshapes >= 15 || Trys >= 30)/// לאחר סיום המשחק הצגה והדפסת הנקודות על המסך
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"This is the of the game\ncongratulation your points is:{Points}");
            }
        }
    }
}

