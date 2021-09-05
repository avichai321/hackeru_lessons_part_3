using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    interface BasicShape
    {
        public Random Rand { get; set; }// המשתנה שמשמש לקבוע אקראיות 
        public char Thechar { get; set; }// התו שיודפס
        public int LocationLeftTop { get; set; }// מיקום התחלת הדפסת הצורה
        public bool[,] Shapeposition { get; set; }//מערך דו מימדי השומר את מיקום הצורה לאחר שהודפסה 
        public void GenerateShapes();// פונקציה הגורמת ליצירת הצורה ולהדפסתה על מסך הקונסול

    }

    class Rectangle : BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[80,25];


        public void GenerateShapes()
        {
            Console.ForegroundColor = (ConsoleColor)Rand.Next(1, 16);
            int Rlength = Rand.Next(3, 10);
            int Rwidth = Rand.Next(2, 10);
            LocationLeftTop = Rand.Next(0,80);
            int shapepositiontop = Rand.Next(0,25);
            for (int i = 0; i < Rlength; i++)
            {
                Console.SetCursorPosition(LocationLeftTop , shapepositiontop+i);// מיקום אקראי להדפסה
                for (int k = 0; k < Rwidth; k++)
                {
                    Console.Write(Thechar);
                    try
                    {
                    Shapeposition[LocationLeftTop+k, shapepositiontop + i] = true;// שמירת המיקום במערך    
                    }
                    catch
                    {
                        break;
                    }
                }
                Console.WriteLine();

            }
        }

        public override string ToString()
        {
            return "Rectangle";
        }

    }
    class Line : BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '=';
        public int LocationLeftTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[80, 25];

        public void GenerateShapes()
        {
            Console.ForegroundColor = (ConsoleColor)Rand.Next(1, 16);
            LocationLeftTop = Rand.Next(0, 79);
            int shapepositiontop = Rand.Next(0, 24);

            Console.SetCursorPosition(LocationLeftTop, shapepositiontop);
            for (int i = 0; i < Rand.Next(2,10); i++)
            {
                Console.Write(Thechar);
                Console.Write(Thechar);
                try
                {
                    Shapeposition[LocationLeftTop + i, shapepositiontop] = true;// שמירת המיקום במערך    
                }
                catch
                {
                    break;
                }
                
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Line";
        }

    }
    class Square : BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public int LocationTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[80, 25];

        public void GenerateShapes()
        {
            Console.ForegroundColor = (ConsoleColor)Rand.Next(1, 16);
            int SquareSize = Rand.Next(3, 10);
            LocationLeftTop = Rand.Next(1, 80);
            int shapepositiontop = Rand.Next(1, 25);
            for (int i = 0; i < SquareSize; i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);
                for (int k = 0; k < SquareSize; k++)
                {
                    Console.Write(Thechar);
                    try
                    {
                        Shapeposition[LocationLeftTop + k, shapepositiontop + i] = true;// שמירת המיקום במערך    
                    }
                    catch
                    {
                        break;
                    }
                    
                }
                Console.WriteLine();
            }
            
        }

        public override string ToString()
        {
            return "Square";
        }


    }
    class Triangle : BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public int LocationTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[80, 25];

        public void GenerateShapes()
        {
            Console.ForegroundColor = (ConsoleColor)Rand.Next(1, 16);
            LocationLeftTop = Rand.Next(1, 80);
            int shapepositiontop = Rand.Next(1, 25);
            for (int i = 0; i < Rand.Next(2,9); i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write(Thechar);
                    try
                    {
                        Shapeposition[LocationLeftTop + k, shapepositiontop + i] = true;// שמירת המיקום במערך    
                    }
                    catch
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return "Triangle";
        }

    }




}


