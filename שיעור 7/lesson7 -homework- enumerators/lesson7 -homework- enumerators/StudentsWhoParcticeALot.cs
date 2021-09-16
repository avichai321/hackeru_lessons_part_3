using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7__homework__enumerators
{
    class StudentsWhoParcticeALot : IEnumerable<string>

    {
        public StudentsWhoParcticeALot(List<Student> students)
        {
            Students = students;
        }

        public List<Student> Students { get; set; }




        public IEnumerator<string> GetEnumerator()
        {
            foreach (var student in Students)
            {
                if (student.Grade > 100)
                { 
                    yield return student.Name;
                }

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
