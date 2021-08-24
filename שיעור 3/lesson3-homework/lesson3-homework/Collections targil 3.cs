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
    class Collections<T,U,D,A> : collec<T>
    {

        public string gettype(T type)
        { 
            return type.GetType().ToString();
        }

        public string gettype(U type)
        {
            return type.GetType().ToString();
        }
        public string gettype(D type)
        {
            return type.GetType().ToString();
        }
        public string gettype(A type)
        {
            return type.GetType().ToString();
        }
    }
}
