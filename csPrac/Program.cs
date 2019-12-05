using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPrac
{
    class Program
    {
        //we wanna build an app for post company & we wanna support few different shipping method  

        /* 
             _one approach is to declare this way below, although its work its messy:
                const int RegularAirMail = 1;
                const int RegisterAirMail = 2;
                const int Express=3;
        */


        //we use enum to declare number of relative constants
        //enum is internally an integer, we can change it by writing infront of it
        //if we don't set values to enum members,by deafult it's gonna set 1st member 1 and increment it for each member


        static void Main(string[] args)
        {
            public enum shippingMethod
            {
            RegularAirMail = 1,
            RegisterAirMail = 2,
            Express = 3
            }
        }

        var method = shippingMethod.Express;
        Console.WriteLine((int)metohde);
    }
}

