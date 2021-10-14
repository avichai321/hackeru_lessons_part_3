using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class LuckyNumber
    {
        public event EventHandler<int> LuckyNumberWasEntered;
        public void Ex2()
        {
            if (LuckyNumberWasEntered != null)
            {
                Console.WriteLine("Enter Number: ");
                var count = 0;
                var number = int.Parse(Console.ReadLine());
                while (number != 999)
                {
                    LuckyNumberWasEntered(this, count);
                    count++;
                    Console.WriteLine("Enter Number: ");
                    number = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Lucky Number Was Entered");
                LuckyNumberWasEntered(this, count);
            }


        }
    }
}
