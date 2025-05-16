using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    class Man
    {
        string name;

        public string Name { get => name; set => name = value; }

        public Man(string name)
        {
            Name = name;
        }

        public void Event1Handler()
        {
            Console.WriteLine($"Человек {Name}, иду.");

            Barrier.Event1 -= Event1Handler;
            Barrier.Event2 -= Event2Handler;
        }

        public void Event2Handler()
        {
            Console.WriteLine($"Человек {Name}, стою.");
        }
    }
}
