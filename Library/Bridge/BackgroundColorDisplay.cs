//using Patterns;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.AdapterFolder;

namespace Library.Bridge
{
    class BackgroundColorDisplay : ColorDisplay
    {
        private ConsoleColor _color;
        public BackgroundColorDisplay()
        {

        }

        public void Color(Icolor color)
        {
            _color = color.ColorConsole();
        }

        public void display()
        {
            Console.BackgroundColor = _color;

            //Console.ResetColor();
        }

        public void Reaset()
        {
            Console.BackgroundColor = default;
        }
    }
}
