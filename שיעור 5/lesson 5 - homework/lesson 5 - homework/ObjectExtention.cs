using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5___homework
{
    public static class ObjectExtention
    {
        public static bool IsNull(this object ob)
        {
            if (ob== null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
