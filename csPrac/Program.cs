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

            var numbersLst = new List<int>() {1,2,3,4,5};
            numbersLst.Add(1);
            numbersLst.AddRange(new int[3] {7,8,9});
            numbersLst.IndexOf(1);//==> 0
            numbersLst.LastIndexOf(1);//starting search from end ==> 5
            Console.WriteLine(numbersLst.Count);
            numbersLst.Remove(9);//removing an item from list, if it was 1 it'll remove first 1 found which is in zero index
            numbersLst.Contains(5);//true
            numbersLst.ForEach(Console.Write);
            
        }
    }
}
