using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class City
    {
        public City(int id, string name, double numberOfPopulation)
        {
            Id = id;
            Name = name;
            NumberOfPopulation = numberOfPopulation;
            if (numberOfPopulation > 25000)
            {
                IsCity = "City";
            }
            else
            {
                IsCity = "yeshuv";
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double NumberOfPopulation { get; set; }
        public string IsCity{ get; set; }


        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} NumberOfPopulation: {NumberOfPopulation}";
        }
    }
}
