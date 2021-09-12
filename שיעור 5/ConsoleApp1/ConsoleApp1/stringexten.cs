using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   static class stringexten
    {
        public static bool IsValidIsraeliIdNumber(this string id)
        {
            int sum = 0;
            int count = 1;
            int tempnum;
            string NumGreatThenNine;
            if (id.Length <= 9)
            {
                id = id.PadLeft(9, '0');
                foreach (var numid in id)
                {
                    if (count == 1)
                    {
                        tempnum = 0;
                        tempnum = Convert.ToInt32(numid.ToString());
                        sum += tempnum;
                        count++;
                    }
                    else if (count == 2)
                    {

                        tempnum = Convert.ToInt32(numid.ToString()) * 2;
                        if (tempnum > 9)
                        {
                            NumGreatThenNine = tempnum.ToString();
                            tempnum = 0;
                            foreach (var num in NumGreatThenNine)
                            {
                                tempnum += Convert.ToInt32(num.ToString());
                            }
                        }
                        sum += tempnum;
                        count--;
                    }

                }
                if (sum % 10 == 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

