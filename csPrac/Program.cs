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

            string fName = "Kaveh";
            string lName = "Sadidi";
            //string name = fName + " " + lName; ==> this kinda format makes it hard to imagine the final result
            string name = string.Format("my name is {0} {1}", fName, lName); //string is again static method of .Net framework
            Console.WriteLine(name);
           
            //join connecting elements of an array
            var numbers = new int[3] { 1, 2, 3 };
            string list = string.Join("-", numbers);
            Console.WriteLine(list);

            //you can read a character from string but you cannot change it (strings are readonly)
            char firstChar = name[0];
            //name[0] = 'm'; strings are Immutable, Once created, cannot be changed

            //verbatim String
            var path = "C:\\Users\\Administrator\\Documents"; 
            //in C# we should put 2slashes // for declaring path unless we put @ at first
            var path2 = @"C:\Users\Administrator\Documents";
        }
    }
}
