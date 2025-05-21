using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_2
{
    class Bell
    {
        public delegate void Message();

        public event Message Event1;
        public event Message Event2;

        int n;

        public Bell(int n)
        {
            this.n = n;
        }

        public void Event1Handler()
        {
            Console.WriteLine($"Звонок на {n} урок");
        }

        public void Event2Handler()
        {
            Console.WriteLine($"Звонок с {n} урока");
        }

        public void GenerateEvents()
        {
            Event1();
            Event2();
        }
    }
}
