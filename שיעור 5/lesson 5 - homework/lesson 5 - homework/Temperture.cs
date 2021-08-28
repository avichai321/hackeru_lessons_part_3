using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5___homework
{
    class Temperture : IComparable<Temperture>
    {
        public Temperture(string city, DateTime date, double temp, int humidity)
        {
            City = city;
            Date = date;
            Temp = temp;
            Humidity = humidity;
        }

        public string City { get; set; }
        public DateTime Date { get; set; }
        public double Temp { get; set; }
        public int Humidity { get; set; }

        public int CompareTo(Temperture other)
        {
            if (City == other.City)
            {
                if (Date == other.Date)
                {
                    if (Temp == other.Temp)
                    {

                        return Humidity.CompareTo(other.Humidity) * -1;
                    }
                    return Temp.CompareTo(other.Temp) * -1;
                }
                return Date.CompareTo(other.Date);
            }
            return City.CompareTo(other.City);
        }
        public override string ToString()
        {
            return $"CIty: {City}, {Date.Day}/{Date.Month}/{Date.Year}, temp: {Temp}c humidity level: {Humidity}";
        }
    }
}
