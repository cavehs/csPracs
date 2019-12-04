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
            
            //Person person = new Person();
            //person.CalAge(1994, 2019);

            int sum = Person.Add(4, 9);
            Console.WriteLine(sum);
        }
    }
}
