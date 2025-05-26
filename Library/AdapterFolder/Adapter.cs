using Library.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.AdapterFolder
{
    class Adapter
    {
        private ColorDisplay colorDisplay;
        public Adapter(ColorDisplay colorDisplay)
        {
            this.colorDisplay = colorDisplay;
        }
        public void Print(BookCategory book)
        {
            switch (book)
            {
                case BookCategory.Adult:
                    colorDisplay.Color(new Blue());
                    return;
                case BookCategory.ChildrensBooks:
                    colorDisplay.Color(new Yellow());
                    return;
                case BookCategory.YoungAdult:
                    colorDisplay.Color(new Red());
                    return;
                default:
                    return;
            }
        }
        public void Reaset()
        {
            colorDisplay.Reaset();
        }

    }
}
