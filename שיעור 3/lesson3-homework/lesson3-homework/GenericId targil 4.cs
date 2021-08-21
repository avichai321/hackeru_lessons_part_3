using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_homework
{
    class Baseproper
    {
        public string Id { get; set; }
        
    }

    class Lecturer: Baseproper
    {
        public string TeachSubject { get; set; }

        public override string ToString()
        {
            return $"lecturer";
        }
    }
    class Stuclass: Baseproper
    {
        public int NumberOfStudents { get; set; }

        

        public override string ToString()
        {
            return $"class";
        }
    }
    class GenericId<T> where T : Baseproper
    {
        public int count { get; set; } = 1;
        T[] listid = new T[10]; 
        public void add(T data)
        {
            for (int i = 0; i < listid.Length; i++)
            {
                if(listid[i]== null)
                {
                    listid[i] = data;
                    listid[i].Id =$"{count}";
                    count++;
                    break;
                }
            }
        }
        public string Searchbyid(string id)
        {

            for (int i = 0; i < listid.Length; i++)
            {
                if (listid[i] != null)
                {
                    if (listid[i].Id == id)
                    {
                        return $"{listid[i].ToString()}";
                    }
                }
            }
            return $"not exist";
        }
        
    }
}
