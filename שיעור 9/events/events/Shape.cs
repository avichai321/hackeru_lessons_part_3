using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate void Shapeoutch();
    public class Shape
    {
        public static void Hit()
        {
            Console.WriteLine("Outch you touch in the shapes");
        }
        public static void Miss()
        {
            Console.WriteLine("You are ok!");
        }
        public virtual int Location { get; set; }
        public static bool Shapechecker(Shape shape, int location)
        {
            if (shape is Square)
            {
                if (shape.Location >= location) { Outch=Hit; Outch(); return true; }
            }
            else
            {
                if (shape.Location == location) { Outch = Hit; Outch(); return true; }
            }
            Outch= Miss;
            Outch();
            return false;
        }
        public static event Shapeoutch ?Outch;
    }

    public class Point : Shape
    {
        public override int Location { get; set; }
        public Point(int location)
        {
            Location = location;
        }


    }
    public class Square : Shape

    {
        public override int Location { get; set; }
        public Square(int lengthAndWIdth)
        {
            Location = lengthAndWIdth * lengthAndWIdth;
        }

    }
}
