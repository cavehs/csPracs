using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPrac
{
    public class Person
    {
        //Field, Attribute or Variable     *public makes it accessible anywhere in the app
        public string Name= "kaveh";
        public const int ID= 837597;

        //Methode or Function
        public void Introduce()
        {
            Console.WriteLine("Hi, my name is " + Name + " and my ID is " +ID);
        }

        //method has an output and one or more inputs (every output is called parameter)
        //below we have 2 parameters for CalAge method.
        public void CalAge(int birthDate,int currentDate)
        {
            int age = currentDate - birthDate;
            Console.WriteLine("the age is "+ age );
        }
        
        
        //by addig static modifier to a method we can access it without the need for creating object for it.
        public static int Add(int a , int b)
        {
            return a + b;
        } 
        
    }
}
