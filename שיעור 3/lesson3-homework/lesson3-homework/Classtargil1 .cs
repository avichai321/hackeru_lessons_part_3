using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_homework
{
    class Classtargil1<T>
    {
        public string Combine(T[] a , T[] b)
        {
            int i = 0;
            T[] newarray1 = new T [a.Length + b.Length];
            foreach (var item in a)
            {
                newarray1[i++] = item;
            }
            foreach (var item in b)
            {
                newarray1[i++] = item;
            }
            return newarray1.Length.ToString();
        }
    }
}
