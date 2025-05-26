using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdapterFolder
{
    class Yellow : Icolor
    {
        public ConsoleColor ColorConsole()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return ConsoleColor.Yellow; ;
        }
    }
}
