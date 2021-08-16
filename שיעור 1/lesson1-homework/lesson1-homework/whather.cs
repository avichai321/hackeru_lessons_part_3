using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1_homework
{
    class whather
    {
        public double[,] Tempertures { get; set; } = new double[28,1];
       
        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        public whather()
        {
            for (int i = 0;  i<Tempertures.Length; i++)
            {

                Tempertures[i, 0] = Math.Round(RandomNumberBetween(24, 40), 2);
            }

        }


        public double GetWhetherByIndex(string index)
        {
            try
            {
                int num = int.Parse(index);
                return Tempertures[num-1, 0];
            }
            catch
            {
                return 0000;
            } 
        }


      
    }
}
