using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5___homework
{
    static class StringExtenstion
    {
        public static bool HasLowerChars(this string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString()== word[i].ToString().ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        public static string ReverseCase(this string exword)
        {
            string revword = "";
            for (int i = 0; i < exword.Length; i++)
            {
                if (exword[i].ToString() == exword[i].ToString().ToLower())
                {
                    revword+= exword[i].ToString().ToUpper();
                }
                else
                {
                    revword += exword[i].ToString().ToLower();
                }
            }
            return revword;
        }

        public static bool IsValidIsraeliIdNumber(this string id)
        {
            int sum = 0;
            int count=1;
            int tempnum;
            string NumGreatThenNine;
            if (id.Length == 9)
            {
                foreach (var numid in id)
                {
                    if (count == 1)
                    {
                        tempnum = Convert.ToInt32(numid);
                        sum += tempnum;
                        count++;
                    }
                    else if (count == 2)
                    {
                        tempnum = Convert.ToInt32(numid)*2;
                        if (tempnum < 9)
                        {
                            NumGreatThenNine = tempnum.ToString();
                            tempnum = 0;
                            foreach (var num in NumGreatThenNine)
                            {
                                tempnum += Convert.ToInt32(num);
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
