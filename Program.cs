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

            for (int i = 0; i < 10; i++)
            {
                Man man = new Man((i + 1).ToString());

                Barrier.Event1 += man.Event1Handler;
                Barrier.Event2 += man.Event2Handler;

                barrier.GenerateEvent(i);
            }

            Console.ReadKey(true);
        }
    }
}
