using System;
using System.Collections.Generic;
using System.Linq;

namespace multithreading
{
    public class Program
    {
        public static async void Main(string[] args)
        {

            #region 1
            //Thread thread = new Thread(() =>
            //{
            //    for (int i = 1; i <= 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //thread.Start();

            // Task task1 = new Task(() =>
            //{
            //    for (int i = 1; i <= 5000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            // task1.Start();
            #endregion

            #region 2

            //Thread thread1 = new Thread(() =>
            //{
            //    var filename = ex2(@"C:\");
            //});
            //thread1.Start();

            //Task task2 = new Task(() =>
            //{
            //    var filename = ex2(@"C:\");
            //});
            //task2.Start();
            #endregion

            #region 3

            //NumNum numNum = new NumNum("bamba");
            //NumNum numNum2 = new NumNum("Naruto");
            //NumNum numNum1 = new NumNum("Luffy");
            //NumNum numNum3 = new NumNum("Goku");
            //Console.WriteLine("Starting threads");
            //numNum.sleep();
            //numNum1.sleep();
            //numNum2.sleep();
            //numNum3.sleep();
            //Console.WriteLine("Threads started");
            #endregion

            #region 4 
            //Sumnum sumT = new Sumnum(1, 1000000);

            //double divnum = sumT.end / 200000;

            //for (int i = 0; i < divnum; i++)
            //{
            //    var t1 = new Thread(sumT.Sumto200k);
            //    t1.Start();
            //    t1.Join();

            //}

            //double sum1 = 0;
            //for (int i = 1; i <= 1000000; i++)
            //{
            //    sum1 = sum1 + i;
            //}
            //Console.WriteLine("\n" + sum1);

            Sumnum sumT1 = new Sumnum(1, 1000000);

            double divnum = sumT1.end / 200000;

            for (int i = 0; i < divnum; i++)
            {
                var t1 = new Task(sumT1.Sumto200k);
                t1.Start();
                t1.Wait();

            }

            double sum2 = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                sum2 = sum2 + i;
            }
            Console.WriteLine("\n" + sum2);
            #endregion

        }

        public static string ex2(string dir)
        {
            var dir1 = new DirectoryInfo(dir);
            var result = dir1.GetFiles().Take(2);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            return dir;

        }
    }
}