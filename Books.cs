using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Books
    {
        protected List<string> BookNames = new List<string>();

        public delegate void BookHandler(String text);
        public event BookHandler onAddBook;
        public event BookHandler onDeleteBook;
        public void AddBook(string bookName)
        {
            BookNames.Add(bookName);
            if(onAddBook != null)
            {
                onAddBook("Книга " +  bookName + " добавлена.");
            }
        }

        public void DeleteBook(string bookName)
        {
            BookNames.Remove(bookName);
            if(onDeleteBook != null)
            {
                onDeleteBook("Книга " + bookName + " УДАЛЕНА!");
            }
        }
    }
}
