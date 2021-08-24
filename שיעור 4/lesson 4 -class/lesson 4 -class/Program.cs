using System;

namespace lesson_4__class
{
    class chishuv
    {

        public void Swap<T> (ref T a ,ref  T b)
        {
            T num3 = a;
            a = b;
            b = num3;
            
        }

        public void print(int a , int b)
        {
            Console.WriteLine($"num1={a} num2={b}");
        }
             
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            chishuv v = new chishuv();
            v.print(a, b);
            v.Swap<int>(ref a , ref b);
            v.print(a, b);
        }
    }
}
