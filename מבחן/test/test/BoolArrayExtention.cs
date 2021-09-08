using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    static class BoolArrayExtention
    {
        public static void CleanBoolArray(this bool[,] charArr)//הרחבה המנקה מערך בוליאני דו מימדי
        {
            for (int i = 0; i < charArr.GetLength(0); i++)// איפוס מיקומים על הלוח
            {
                for (int k = 0; k < charArr.GetLength(1); k++)
                {
                    charArr[i, k] = false; 
                }
            }
        }

        public static bool AddInnerArrayToMainArray(this bool[,] mainArray, bool[,] innerArray)// הרחבה שמעתיקה את המערך הפנימי למערך הגדול יותר ובודקת אם הכל עבר בשלמות
        {
            for (int i = 0; i < innerArray.GetLength(0); i++)
            {
                for (int j = 0; j < innerArray.GetLength(1); j++)
                {
                    if (innerArray[i, j] == true && mainArray[i,j] == false)
                    {
                        mainArray[i, j] = true;
                    }
                    else if (innerArray[i, j] == true && mainArray[i, j] == true)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }

}
