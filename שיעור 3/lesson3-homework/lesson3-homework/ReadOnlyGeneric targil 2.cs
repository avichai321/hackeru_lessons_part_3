using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3_homework
{

    class BasicProp
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Course : BasicProp
    {
        public int StudenstWasRegistered { get; set; }

        public override string ToString()
        {
            return $"course";
        }

    }
    class Student : BasicProp
    {
        public int Grade { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"student";
        }

    }
    class ReadOnlyGeneric<T> where T : BasicProp
    {
        T[] list = new T[1000];
        public bool IsReadOnly { get; set; }
        public int count { get; set; } = 1;

        public void AddToList(T data)
        {
            if (!IsReadOnly)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == null)
                    {
                        list[i] =  data;
                        list[i].Id = count;
                        list[i].Name = $"{data.ToString()}{count}";
                        count++;
                        break;
                    }


                }
                
            }
            else
            {
               throw new InvalidOperationException("can't add beacuse the list is read only");
            }
        }


        public string SearchById(int id)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Id == id)
                {
                    return list[i].Name;
                }
            }
            return null;
        }

        public void ChangeReadOnly()
        {
            if (!IsReadOnly)
            {
                IsReadOnly = true;
            }
            else
            {
                IsReadOnly = false;
            }
        }
    }

}
