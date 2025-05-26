using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum BookCategory
    {
        NA = 0,              // לא הוגדר//00000000
        Thriller = 1,        // מותחן//00000001
        Biography = 2,       // בביאוגרפיה//00000010
        SelfHelp = 4,        // עזרה עצמית//00000100
        History = 8,         // היסטוריה//00001000
        Holocaust = 16,      // שואה//00010000
        YoungAdult = 32,     // נוער//00100000
        ChildrensBooks = 64, // ילדים//01000000
        Adult = 128,         //מבוגרים//10000000
    }
}
