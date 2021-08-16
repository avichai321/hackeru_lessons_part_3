using System;
using System.Collections.Generic;
using System.Text;

namespace lesson1_homework
{
    class Meassure
    {
        public string Location { get; set; }
        public int Date { get; set; }
        public double Temp { get; set; }
    }
    class MangageMessure
    {
        whather w2 = new whather(); 
        private Meassure[] m1 = new Meassure[28];

        public MangageMessure()
        {
        for (int i = 0,k=1; i<m1.Length; i++, k++)
			{
                m1[i].Date = k;
                m1[i].Location = $"L {k}";
                m1[i].Temp = w2.Tempertures[i, 0];
			}

        }


        public int this[int day]
        {
            get
            {
                return m1[day-1].Date;
            }
            set
            { 
                m1[day-1].Date = value;
            }
        }

        public double? this[string city]
        {
            get
            {
                for (int i = 0; i < m1.Length; i++)
                {
                    if (m1[i].Location == city)
                    {
                        return m1[i].Temp;

                    }
                }
                return null;
            }
        
        }

        public bool this[string city,int day]
        {
            get
            {
                for (int i = 0; i < m1.Length; i++)
                {
                    if (m1[i].Location == city && m1[i].Date==day)
                    {
                        return true;

                    }
                }
                return false;
            }
        }
    }
}
