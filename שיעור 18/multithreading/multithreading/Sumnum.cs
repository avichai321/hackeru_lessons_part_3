using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading
{
    internal class Sumnum
    {
        public double start { get; set; } =0;
        public double end { get; set; } = 0;
        public double sum { get; set; } = 0;
        static object lockobject = new object();
       

        public Sumnum(double startnumber, double endnumber)
        {
            start = startnumber;
            end = endnumber;
        }

        public void SumNumbers(double num)
        {
            lock (lockobject)
            {
                sum = sum + num;
            }
        }
      
        public void Sumto200k()
        {
            
            for (int i = 0; i < 200000; i++)
            {
                SumNumbers(start);
                start++;
                
            }
            Console.WriteLine(sum);
            //Thread.Sleep(2000);
            Task.Delay(2000);
        }
    }
}
