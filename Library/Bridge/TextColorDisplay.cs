//using Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.AdapterFolder;

namespace Library.Bridge
{
    class TextColorDisplay : ColorDisplay
    {
        private ConsoleColor _color;
        public TextColorDisplay()
        {

        }

        public void Color(Icolor color)
        {
            _color = color.ColorConsole();
        }

        public void display()
        {
            Console.ForegroundColor = _color;

            //Console.ResetColor();
        }

        public void Reaset()
        {
            Console.ForegroundColor = default;
        }
    }
}
