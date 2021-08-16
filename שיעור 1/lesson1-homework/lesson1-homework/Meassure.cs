using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1_homework
{
    class Meassure
    {
        whather w1 = new whather();
        public string Location { get; set; }
        int[] date = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
        public double Temp;
        private Meassure[] m1 = new Meassure[6]; 

        public Meassure(string location,  double temp)
        {
            Location = location;
            
            Temp = temp;
        }

        public Meassure this [int i]
        {
            get { return m1[i]; }
            set { m1[i] = value; }
        }
        public int this [int day]
        {
            get { return date[day - 1]; }
            set { date[day-1] = value; }
        }
    }
}
