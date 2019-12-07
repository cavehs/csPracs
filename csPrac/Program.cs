using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace csPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which one wou;d you choose: \n Enter 0 to open 'Key to ASCII' conversion\n Enter 1 to open 'ASCII to key' conversion");
            var input = int.Parse(Console.ReadLine());

            while (input == 0)
            {
                var kp = Console.ReadKey();
                Console.WriteLine(": " + (int)kp.KeyChar);
            }
            while (input == 1) 
            {
                var code = int.Parse(Console.ReadLine());
                Console.WriteLine((char)code);
            }

           

        }
    }
}
