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

            //Working with Text:
            var text = "Kaveh Raymond";
            var textLower = text.ToLower();
            var textUpper = text.ToUpper();             
            int findA =text.IndexOf('a');//returns index of 1st a which is 1
            int findLastA = text.LastIndexOf('a'); //returns a index from the end which is 7
            Console.WriteLine(text.Substring(6,3));//returns string from given index length
            Console.WriteLine(text.Replace(" ", "-"));
            
            //String Builder:
            //Strings are immutable, if you're dealing a situation where you have a lot of string manipulation 
            //Operations you can use a string builder, makes it easy to create a string and modify it on the flight
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();//Enter
            builder.Append("  Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            builder.Replace('-', '*');
            builder.Remove(0, 10);


        }
    }
}
