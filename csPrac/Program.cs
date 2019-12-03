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
            //implicit type Conversion (in conversion from smaller (ranged) datatypes to larger ones):
            byte b1 = 1;
            int i1 = b1;

            //Explicit type conversion (in conversion from larger (ranged) datatypes to smaller ones) :
            int i2 = 1;
            byte b2 = (byte)i2;

            //non-compatible datatype Conversion:
            string s = "3";
            int i3 = int.Parse(s); // or ==>  int i3 = Convert.ToInt32(s);


            /*c# doesn't recognize overflow, unless we put checked code :
              with this overflow will not happen at runtime instead an exception will be thrown
              and program will crash unless U handle the exception & we handle it by trycatch. : */
            try
            {
                checked
                {
                    byte b3 = 255;
                    b3 += 1;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Overflow occured: Byte range is 0 to 255");
            }

        }
    }
}
