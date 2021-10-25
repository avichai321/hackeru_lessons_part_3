using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{

    public class Program
    {
        
        public static void Main(string[] args)
        {
            //string[] Name = new string[5] { "Avicii", "Naruto", "Goku", "Luffy", "Bamba" };

            //var query1 = from name in Name
            //             where name.Contains("A")
            //             select "BAMBA";
            //var listb= query1.ToList();

            //foreach (var item in listb) { Console.WriteLine(item); }
            #region numbers

            int[] numbers = new int[] { 10, 12, -53, 26, -15, 68, };
            #region 1
            var qurery1 = from num in numbers
                          where num < 0
                          select num;
            var delegate1 = numbers.Where(number => number < 0).ToList();

            foreach (var item in qurery1) { Console.WriteLine(item); }
            #endregion

            #region 2 
            var qurery2 = from num in numbers
                          orderby (num % 2 == 0) descending
                          select num;
            var delegate2 = numbers.Where(number => number % 2 == 1).ToList();

            foreach (var item in qurery2) { Console.WriteLine(item); }

            #endregion
            #region 3
            var qurery3 = from num in numbers
                          where num > 5 && num % 3 != 0
                          select num*3;

            var delegate3 = numbers.Where(number => number > 5 && number % 3 != 0).Select(number => number * 3).ToList();
            Console.WriteLine("*******************");
            foreach (var item in delegate3) {  Console.WriteLine(item); }

            #endregion
            #endregion


            #region citys
            List<string> Cityslist = new List<string>() { "Safed","Tokyo","Beit-Shean" ,"Beit-lid","Netanya","New-york","Xander"};

            #region 4
            Func<string, List<string>, List<string>> cityfilter1 = (city, cityslist) =>
              {
                  var querycity = (from citys in cityslist
                                   where citys == city
                                   select citys).ToList();
                  return querycity;
              };
            var list1 =cityfilter1("Safed", Cityslist);
            foreach (var item in list1)
            {
                Console.WriteLine(item);

            }

            #endregion

            #region 5
            Func<string, List<string>, List<string>> cityfilter2 = (city, cityslist) =>
            {
                var querycity = (from citys in cityslist
                                 where citys.Contains(city)
                                 select citys).ToList();
                return querycity;
            };
            var list2 = cityfilter2("a", Cityslist);
            foreach (var item in list2)
            {
                Console.WriteLine(item);

            }
            #endregion

            #region 6
            var query6 = from city in Cityslist
                         where city.Contains(city)
                         select city.Take(1);
            Console.WriteLine(query6);

            #endregion

            #region 7
            var query7 = from city in Cityslist
                         orderby city descending
                         select city.Take(3).ToList();
            foreach (var item in query7)
            {
                Console.WriteLine(item);
            }    

            #endregion
            #endregion



        }
    }
}
