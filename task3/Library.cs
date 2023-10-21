using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class Library:Base
    {
        private List<Book> _books;
        private static int _nextId = 1;
        public Library(string name)
        {
            name = Name;
            _books = new List<Book>();
            Id = _nextId++;
        }
        public void AddBook(Book book) 
        {
            _books.Add( book );
        }
        public void ListAllBooks()
        {
            if(_books.Count == 0)
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
                return;
            }
            foreach(Book book in _books)
            {
                Console.WriteLine($"Id: {book.Id}; Name: {book.Name}; Category: {book.Category}; Authot: {book.Author}");
            }
        }
    }
}
