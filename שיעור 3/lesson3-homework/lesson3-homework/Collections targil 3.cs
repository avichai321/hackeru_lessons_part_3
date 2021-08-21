using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lesson3_homework
{
    interface collec<T>
    {
        public string gettype(T type);
    }
    class Collections<T> : collec<T>
    {

        public string gettype(T type)
        { 
            return type.GetType().ToString();
        }
    }
}
