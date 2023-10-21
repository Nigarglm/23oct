using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class CategoryNotFoundException:Exception
    {
        public CategoryNotFoundException(string message): base(message) { }
    }
}
