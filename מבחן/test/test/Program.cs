using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //bool[,] PositionList = new bool[80, 25];
            //Random Rand = new Random();
            //List<BasicShape> shapelist = new List<BasicShape>();
            //shapelist.Add(new Rectangle());
            //shapelist.Add(new Line());
            //shapelist.Add(new Square());
            //shapelist.Add(new Triangle());
            //for (int i = 0; i < 4; i++)
            //{
            //shapelist[Rand.Next(0,4)].GenerateShapes();
            //}
            //Ball ball = new Ball();
            //ball.Writeball();
            Game startGame = new Game();
            startGame.Gamestart();

           
            

                    //BasicShape nha = new BasicShape();
                    //nha.printshape();
            }
    }
}
