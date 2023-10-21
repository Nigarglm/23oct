using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class Category:Base
    {
        private static int _nextId = 1;
        public Category(string name)
        {
            name = Name;
            Id = _nextId++;
        }
    }
}
