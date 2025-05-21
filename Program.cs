using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество уроков: ");
            int lessonCount = int.Parse(Console.ReadLine());

            Teacher teacher = new Teacher("Петя");
            Student student = new Student("Вася");

            Console.WriteLine();
            for(int i = 1; i <= lessonCount; i++)
            {
                Bell bell = new Bell(i);

                bell.Event1 += bell.Event1Handler;
                bell.Event1 += teacher.Event1Handler;
                bell.Event1 += student.Event1Handler;
                bell.Event2 += bell.Event2Handler;
                bell.Event2 += teacher.Event2Handler;
                bell.Event2 += student.Event2Handler;

                bell.GenerateEvents();
            }

            Console.ReadKey(true);
        }
    }
}
