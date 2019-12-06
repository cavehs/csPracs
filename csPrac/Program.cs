using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPrac
{
    /*
    C# includes a value type entity same as class called "structure". Structs are mainly useful to hold small data values.
    The struct type is suitable for representing lightweight objects such as Point, Rectangle, and Color.
    Although it is just as convenient to represent a point as a class with Auto-Implemented Properties,
    a struct might be more efficient in some scenarios.For example, if you declare an array of 1000 Point objects,
    you will allocate additional memory for referencing each object; in this case, a struct would be less expensive.
    Because.NET already contains an object called Point, the struct in this example is named Coords instead.
    It can contain parameterized constructor, static constructor, constants, fields, methods, properties, indexers, operators, events and nested types.
    */

    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an object.
            Coords coords1;   //Coords coords1=new Coords(10,20);

            // Initialize.
            coords1.x = 10;
            coords1.y = 20;
            
            Console.Write("Coords 1: ");
            Console.WriteLine($"x = {coords1.x}, y = {coords1.y}");

            
        }
    }
}
