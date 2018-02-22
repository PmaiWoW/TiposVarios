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
            string s = "\"communist: I hunger \u00A9\"";
            string u = @"C A P I T A L I S M    I N T E N S I F I E S";
            Console.WriteLine(s);
            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
}
