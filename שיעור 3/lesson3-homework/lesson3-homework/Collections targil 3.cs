using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lesson3_homework
{
    class Collections<T>
    {
        T[] arr = new T[10];
        public int count { get; set; } = 0;

        public string gettype(T type)
        {
            return type.GetType().ToString();
        }
        public string Add(T data)
        {
            if (count != arr.Length)
            {
                arr[count] = data;
                count++;
                Array.Sort(arr);
                return $"added succesfully to {data.GetType().Name} array";
            }
            else
            {
                return $"{data.GetType().Name} array is full";
            }





        }


    }
}
