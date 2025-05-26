using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdapterFolder
{
    class Red : Icolor
    {
        public ConsoleColor ColorConsole()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return ConsoleColor.Red;
        }
    }
}
