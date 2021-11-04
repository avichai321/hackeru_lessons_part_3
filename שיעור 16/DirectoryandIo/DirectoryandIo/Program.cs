using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace DirectoryandIo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region 1
            var a = Directory.GetDirectories(@"C:");
            foreach (var file in a.Take(10))
            {
                Console.WriteLine(file);
            }
            #endregion
            #region 2
            var directoryinfo = new DirectoryInfo(@"D:");
            var file1 = directoryinfo.GetFiles().OrderByDescending(f => f.Length).Take(3);
            foreach (var item in file1)
            {
                Console.WriteLine(item.Name + "" + item.LastWriteTime);
            }
            #endregion

            #region 3
            Student.SaveStudentTojson();
            #endregion

            #region 4
            Student.ListOfFixedlength();
            #endregion
            #region 5
            Student.SaveStudentToCSV();
            #endregion
            #region 6
            Student.ReadStudentFromCSV();
            #endregion
            #region 7
            // בכללי פורמט fixed length הוא יותר חסכוני 
            #endregion
            #region 8
            // הוא מגביל אותנו 
            #endregion
            #region 9
            // הרבה יותר קצר ומסודר מבחינת כתיבה והוא רק ב0ו1
            #endregion
        }
    }
}






