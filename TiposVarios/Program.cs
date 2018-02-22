using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 1;
            string s = "\"communist: I hunger \u00A9\"";
            string u = @"C A P I T A L I S M    I N T E N S I F I E S";
            string k = "a" + 2;
            string a = "abc" + x;
            string p = $"where da sheckels at, i had {x}";
            string e = $"{x} mais {y} e' {x + y}";
            Console.WriteLine(s);
            Console.WriteLine(u);
            Console.WriteLine(k);
            Console.WriteLine(a);
            Console.WriteLine(p);
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
