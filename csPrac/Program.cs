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
            // below int is "datatype" & number is "Identifier";
            int number;
            int no = 1;
            const float Pi = 3.14f; // Real numbers like (float,decimal) except double get f or m at the end
                                    // also consts identifier should be declared in Pascal case & variables should be declared in camel case. 
            const decimal Tax = 88.9m;
            double score = 19.65;

            //we can also use "var" instead of writing datatype by initializing it .net will underestands which datatype is suitable for it.
            var text = "kaveh";
            var firstLetter = 'k';
            //by holding ctrl+Rclick on datatypr you can see its primary declaration in .net class 
        

            /*in general: 
                camalCase is used for:   LocalVariables, Private Fields, Methodes Parameters
                PascalCase is used for:  Consts, Public Fields, Class&Methode Name    */
            
            
        }
    }
}
