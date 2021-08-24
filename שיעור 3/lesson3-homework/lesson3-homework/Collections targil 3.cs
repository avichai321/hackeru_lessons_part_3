using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lesson3_homework
{
    class Collections<T> 
    {
    T[] arr = new T[10];  

        public string gettype(T type)
        { 
            return type.GetType().ToString();
        }
        public string Add(T data)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == null)
                {
                    arr[i] = data;
                    break;
                }
            }
             Array.Sort(arr);
            return $"added succesfully to {data.GetType().Name} array";
            
        }

    }
}
