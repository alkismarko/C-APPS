using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpressions
{    // This is new pr
    class Program
    {
        static void Main(string[] args)
        {
            // The symbols && (AND), || (OR), ! (NOT) are called boolean operators (Λογικοί τελεστές) 
            // The symbols <, >, <=, >=, != are called comparison operators(Τελεστές σύγκρισης)
            // And finally expressions like (12 > 8) or (true && false) or (x > y || a < b)
            // are called boolean expressions
            bool x = true;
            bool y = false;
            int a = 5;
            int b = 10;
            Console.WriteLine(!x);
            Console.WriteLine(x && y);
            Console.WriteLine(b > a && x);

        }
    }
}
