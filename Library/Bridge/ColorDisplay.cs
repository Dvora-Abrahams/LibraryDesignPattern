//using Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.AdapterFolder;

namespace Library.Bridge
{
    interface ColorDisplay
    {
        void display();
        void Color(Icolor color);

        void Reaset();
    }
}
