using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading
{
    internal class NumNum
    {
        public int SleepTime { get; set; }
        public string TheredName { get; set; }
        public void sleep()
        {
            //Thread thread = new Thread(() =>
            //{
            //    Console.WriteLine($"{TheredName} going to sleep");
            //    Thread.Sleep(SleepTime);
            //    Console.WriteLine($"{TheredName} done sleeping");
            //    Console.WriteLine($"Thread '{TheredName}' ; Sleep time {SleepTime / 1000f} seconds");
            //});
            //thread.Start();
            //thread.Join();

            Task task = new Task(() =>
            {
                Console.WriteLine($"{TheredName} going to sleep");
                Thread.Sleep(SleepTime);
                Console.WriteLine($"{TheredName} done sleeping");
                Console.WriteLine($"task '{TheredName}' ; Sleep time {SleepTime / 1000f} seconds");
                
            });
            task.Start();
            
        }

        public async void sleepAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"{TheredName} going to sleep");
                Thread.Sleep(SleepTime);
                Console.WriteLine($"{TheredName} done sleeping");
                Console.WriteLine($"task '{TheredName}' ; Sleep time {SleepTime / 1000f} seconds");

            });
        }
        public NumNum(string nameOfThered)
        {
            Random rand = new Random();
            SleepTime = rand.Next(0, 5000);
            TheredName = nameOfThered;

        }
    }
}
