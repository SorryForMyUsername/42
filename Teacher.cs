using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_2
{
    internal class Teacher
    {
        string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public void Event1Handler()
        {
            Console.WriteLine($"Учитель {name} идёт на урок");
        }

        public void Event2Handler()
        {
            Console.WriteLine($"Учитель {name} идёт в учительскую");
        }
    }
}
