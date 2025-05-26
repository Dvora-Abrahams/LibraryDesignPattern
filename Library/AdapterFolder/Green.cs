using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdapterFolder
{
    class Green : Icolor
    {
        public ConsoleColor ColorConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return ConsoleColor.Green;
        }
    }
}
