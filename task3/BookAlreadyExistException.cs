using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class BookAlreadyExistException:Exception
    {
        public BookAlreadyExistException(string message) : base(message) { }
    }
}
