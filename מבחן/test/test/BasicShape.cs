using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    interface BasicShape
    {
        Random Rand { get; set; }// המשתנה שמשמש לקבוע אקראיות 
        char Thechar { get; set; }// התו שיודפס
        int LocationLeftTop { get; set; }// מיקום התחלת הדפסת הצורה
        bool[,] Shapeposition { get; set; }//מערך דו מימדי השומר את מיקום הצורה לאחר שהודפסה 
        void GenerateShapes();// פונקציה הגורמת ליצירת הצורה ולהדפסתה על מסך הקונסול

    }
    
    class Rectangle :  BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[81, 26];


        public void GenerateShapes()
        {
            Shapeposition.CleanBoolArray();// לוודא שהמערך הפנימי נקי מערכים לפני בניית הצורה
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = (ConsoleColor)Rand.Next(7, 14);// מגריל צבעים לצורות
            int Rlength = Rand.Next(3, 10);//אורך המלבן
            int Rwidth = Rand.Next(2, 10);//רוחב המלבן
            LocationLeftTop = Rand.Next(1, 80);//מיקום תחילת הדפסת הצורה ציר האיקס 
            int shapepositiontop = Rand.Next(1, 25);//מיקום תחילת הדפסת הצורה ציר הוואי
            for (int i = 0; i < Rlength; i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);// מיקום אקראי להדפסה
                for (int k = 0; k < Rwidth; k++)
                {
                    if (LocationLeftTop + k>= 80 || shapepositiontop + i >= 25)// הגבלת הדפסת הצורה בתוך מתחם המשחק
                    {
                        LocationLeftTop = LocationLeftTop + k;
                        break;
                    }
                    Console.Write(Thechar);
                    Shapeposition[LocationLeftTop + k, shapepositiontop + i] = true;// שמירת המיקום במערך    
                }
                if (LocationLeftTop>= 80 || shapepositiontop + i >= 25)
                { 
                    break;
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return "Rectangle";
        }

    }
    
    class Line :  BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[81, 26];

        public void GenerateShapes()
        {
            Shapeposition.CleanBoolArray();// לוודא שהמערך הפנימי מערכים לפני בניית הצורה
            Console.ForegroundColor = (ConsoleColor)Rand.Next(7, 14);
            LocationLeftTop = Rand.Next(1, 79);
            int shapepositiontop = Rand.Next(1, 24);

            Console.SetCursorPosition(LocationLeftTop, shapepositiontop);
            for (int i = 0; i < Rand.Next(2, 10); i++)
            {               
                if (LocationLeftTop + i >= 80 || shapepositiontop >= 25)
                {
                    break;
                }
                Console.Write(Thechar);
                Shapeposition[LocationLeftTop + i, shapepositiontop] = true;// שמירת המיקום במערך    
                
                
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Line";
        }

    }
    
    class Square :  BasicShape
    {
        public Random Rand { get; set; } = new Random();
        public char Thechar { get; set; } = '#';
        public int LocationLeftTop { get; set; }
        public bool[,] Shapeposition { get; set; } = new bool[81, 26];

        public void GenerateShapes()
        {
            Shapeposition.CleanBoolArray();
            Console.ForegroundColor = (ConsoleColor)Rand.Next(7, 14);
            int SquareSize = Rand.Next(3, 10);
            LocationLeftTop = Rand.Next(1, 79);
            int shapepositiontop = Rand.Next(1, 24);
            for (int i = 0; i < SquareSize; i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);
                for (int k = 0; k < SquareSize; k++)
                {
                    if (LocationLeftTop + k >= 80 || shapepositiontop + i>= 25)
                    {
                        LocationLeftTop = LocationLeftTop + k;
                        break;
                    }
                    Console.Write(Thechar);
                    Shapeposition[LocationLeftTop + k, shapepositiontop + i] = true;// שמירת המיקום במערך    

                }
                    if (LocationLeftTop >= 80 || shapepositiontop + i >= 25)
                    {
                        break;
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
        public bool[,] Shapeposition { get; set; } = new bool[81, 26];

        public void GenerateShapes()
        {
            Shapeposition.CleanBoolArray();
            Console.ForegroundColor = (ConsoleColor)Rand.Next(7, 14);
            LocationLeftTop = Rand.Next(1, 79);
            int shapepositiontop = Rand.Next(1, 24);
            for (int i = 0; i < Rand.Next(2, 9); i++)
            {
                Console.SetCursorPosition(LocationLeftTop, shapepositiontop + i);
                for (int k = 0; k < i + 1; k++)
                {
                    if (LocationLeftTop + k >= 80 || shapepositiontop + i >= 25)
                    {
                        LocationLeftTop= LocationLeftTop + k;
                        break;
                    }
                    Console.Write(Thechar);
                    Shapeposition[LocationLeftTop + k, shapepositiontop + i] = true;// שמירת המיקום במערך    
                }
                if (LocationLeftTop >= 80 || shapepositiontop + i >= 25)
                {
                    break;
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







