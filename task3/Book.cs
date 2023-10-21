using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class Book:Base
    {
        public string Author { get; set; }
        public Category Category { get; set; }
        private static int _nextId = 1;
        public Book(string name, string author, Category category) 
        {
            name = name;
            author = Author;
            category = Category;
            Id = _nextId++;
        }
    }
}
