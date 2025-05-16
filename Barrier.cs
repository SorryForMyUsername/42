using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrier
{
    internal class Barrier
    {
        public delegate void Message();

        public static event Message Event1;
        public static Message Event2;

        public void Event1Handler()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Открыто");
            Console.ResetColor();
        }

        public void Event2Handler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыто");
            Console.ResetColor();
        }

        public void GenerateEvent(int eventNumber)
        {
            switch (eventNumber)
            {
                case 1: Event1(); break;
                case 2: Event2(); break;
            }
        }
    }
}
