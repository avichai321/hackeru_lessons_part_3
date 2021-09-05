using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Game
    {
        public bool[,] GeneralPositionList { get; private set; } = new bool[80, 25];
        Random Rand = new Random();// יצירת ההגרלה במשחק
        private List<BasicShape> ShapelistStart = new List<BasicShape>(4);
        public List<BasicShape> Shapelistgame { get; set; } = new List<BasicShape>(15); // מספר הצורות במשחק
        public int Countshapes { get; set; }
        public int Round { get; set; }

        public Game()
        {
            Countshapes = Rand.Next(3, 6);
            ShapelistStart.Add(new Rectangle());
            ShapelistStart.Add(new Line());
            ShapelistStart.Add(new Square());
            ShapelistStart.Add(new Triangle());
        }


        public void Gamestart()
        {
            int XBall, YBall;
            Ball ball = new Ball();
            while (Countshapes != 15)// תנאי סף להמשך המשחק
            {
                Console.SetWindowSize(80, 25);
                if (Round == 0)
                {
                    for (int i = 0; i < Countshapes; i++)// יצירת הצורות
                    {
                        Console.Clear();
                        int rollShape = Rand.Next(0, 3);
                        Shapelistgame.Add(ShapelistStart[rollShape]);
                        Shapelistgame[i].GenerateShapes();
                        for (int k = 0; k < Shapelistgame[i].Shapeposition.GetLength(0); k++)
                        {
                            for (int j = 0; j < Shapelistgame[i].Shapeposition.GetLength(1); j++)
                            {
                                if (Shapelistgame[i].Shapeposition[k, j] == true)
                                {
                                    GeneralPositionList[k, j] = true;
                                }

                            }
                        }


                    }
                    try
                    {

                        XBall = Rand.Next(0, 80);
                        YBall = Rand.Next(0, 25);
                        do
                        {
                            ConsoleKeyInfo Move;
                            Console.SetCursorPosition(XBall, YBall);
                            Move = Console.ReadKey(true);
                            switch (Move.Key)
                            {
                                case ConsoleKey.UpArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                YBall--;
                                    Console.SetCursorPosition(XBall, YBall);
                                    break;
                                case ConsoleKey.DownArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                YBall++;
                                    Console.SetCursorPosition(XBall, YBall);
                                    break;
                                case ConsoleKey.LeftArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                XBall--;
                                    Console.SetCursorPosition(XBall, YBall);
                                    break;
                                case ConsoleKey.RightArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                XBall++;
                                    Console.SetCursorPosition(XBall, YBall);
                                    break;
                            }
                            ball.Writeball();

                        }
                        while (GeneralPositionList[XBall, YBall] != true);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                        Console.Clear();
                }
                else // בכל סיבוב שהוא לא הסיבוב הראשון
                {
                    for (int i = 0; i < GeneralPositionList.GetLength(0); i++)// איפוס מיקומים על הלוח
                    {
                        for (int k = 0; k < GeneralPositionList.GetLength(1); k++)
                        {
                            GeneralPositionList[i, k] = false;
                        }
                    }
                    int rollShape = Rand.Next(0, 3);
                    Shapelistgame.Add(ShapelistStart[rollShape]);
                    Countshapes++;
                    foreach (var shape in Shapelistgame)
                    {
                        shape.GenerateShapes();
                        for (int k = 0; k < shape.Shapeposition.GetLength(0); k++)
                        {
                            for (int j = 0; j < shape.Shapeposition.GetLength(1); j++)
                            {
                                if (shape.Shapeposition[k, j] == true)
                                {
                                    GeneralPositionList[k, j] = true;
                                }

                            }
                        }
                    }
                    XBall = Rand.Next(0, 80);
                    YBall = Rand.Next(0, 25);

                    do
                    {
                        ConsoleKeyInfo Move;
                        Console.SetCursorPosition(XBall, YBall);
                        ball.Writeball();
                        Move = Console.ReadKey(true);
                        switch (Move.Key)
                        {
                            case ConsoleKey.UpArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                YBall--;
                                Console.SetCursorPosition(XBall, YBall);
                                break;
                            case ConsoleKey.DownArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                YBall++;
                                Console.SetCursorPosition(XBall, YBall);
                                break;
                            case ConsoleKey.LeftArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                XBall--;
                                Console.SetCursorPosition(XBall, YBall);
                                break;
                            case ConsoleKey.RightArrow:
                                GeneralPositionList[XBall, YBall] = true;
                                XBall++;
                                Console.SetCursorPosition(XBall, YBall);
                                break;

                        }
                        ball.Writeball();

                    }
                    while (GeneralPositionList[XBall, YBall] != true);
                    Console.Clear();
                }
                Round++;
            }
        }
    }
}
