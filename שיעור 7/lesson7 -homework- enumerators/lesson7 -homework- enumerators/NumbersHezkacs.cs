using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7__homework__enumerators
{
    class NumbersHezkacs : IEnumerable<double>
    {

        public double Num { get;  set; }
        public int Tempnum { get; set; }

        public NumbersHezkacs(int num)
        {
            Num = num;
            Tempnum = num;
        }

        public IEnumerator<double> GetEnumerator()
        {
            
            for (int i = 0; i <10; i++)
            {
                
                Num = Num * Tempnum;
                yield return Num;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
