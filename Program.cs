using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            books.onAddBook += ShowMessage;
            books.onDeleteBook += ShowMessage;
            books.AddBook("Властелин колец");
            books.AddBook("Звёздные войны");
            books.DeleteBook("Звёздные войны");
        }

        public static void ShowMessage(String text)
        {
            Console.WriteLine(text);
        }
    }
}
