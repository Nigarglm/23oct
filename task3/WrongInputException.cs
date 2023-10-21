using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23oct_task
{
    internal class WrongInputException:Exception
    {
        public WrongInputException(string message) : base(message) { }
    }
}
