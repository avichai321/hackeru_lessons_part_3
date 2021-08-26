using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_homework
{
    interface IBaseName
    {
        public string Name { get; set; }
    }

    class Classwithname : IBaseName
    {
        public string Name { get; set; } = "classic";

        public string printname()
        {
            return Name;
        }
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
