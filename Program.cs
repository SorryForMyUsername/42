using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barrier barrier = new Barrier();
            Barrier.Event1 += barrier.Event1Handler;
            Barrier.Event2 += barrier.Event2Handler;

            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Man man = new Man(i.ToString());

                Barrier.Event1 += man.Event1Handler;
                Barrier.Event2 += man.Event2Handler;

                barrier.GenerateEvent(rnd.Next(1, 3));
            }

            Console.ReadKey(true);
        }
    }
}
