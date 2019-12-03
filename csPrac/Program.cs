using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            //Arithmetic Operations: +, -, *, /, %, ++, --
            int a = 1, b = 3;
            int d = ++a;
            int e = a++;
            Console.WriteLine("d:" + d + "      e:" + e + "       a:" + a);

            //COmparison Operation (==, !=, >=, <=, <,>): 
            Console.WriteLine("{0} {1} {2} {3} {4}", a == b, a > d, e < d, a != d, a >= 1);

            //Assignment Operators(= ,+=, -=, *= , /=)
            int m = a *= 1;

            //Logical operators (||, &&, !)
            Console.WriteLine();

            //Bitwise OPerators (&, |) : used in low level programming
        }
    }
}
