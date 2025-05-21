using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_2
{
    internal class Student
    {
        string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void Event1Handler()
        {
            Console.WriteLine($"Ученик {name} идет на урок");
        }
        public void Event2Handler()
        {
            Console.WriteLine($"Ученик {name} идет на перемену");
        }
    }
}
