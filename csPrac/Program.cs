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

            //int numbers1=1;
            //int numbers2=2;
            //int numbers3=3;
            
            int[] numbers = new int[3];      // var[] nnumbers = new int[3] { 1, 2, 3 };
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            //int[]    ->we tell compiler to create an array
            //numbers  ->identifier or Name
            //new      ->new operator allocates memory to an array.
            //int[3]   ->size
            
         //Multi Dimensional Arrays;
            //2D: [Rows, Columns]
            var twoDArr = new int[3, 5]
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}
            };
            Console.WriteLine(twoDArr[1,4]); //10

            //3D: [Page,Rows,Columns]
            var threeDArr = new int[2, 3, 2]
            {
                {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                },
                {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                }
            };

            //Jagged Array; with custom size
            var jaggedArr = new int[3][];
            jaggedArr[0]=new int[2] {0,1};
            jaggedArr[1]=new int[4] {0,1,2,3};
            jaggedArr[2] = new int[3] {0,1,2};

            Console.WriteLine(jaggedArr[1][3]); //3

            //Array Classes (indexof, Clear, Copy, Sort, Reserve):

            //Array.indexof(array,value) --> returns index of certain value_ works for 1D arrays
            Console.WriteLine(Array.IndexOf(numbers,2));
            //Array.Clear(array,startingIndex,EndingIndex);
            //Array.Copy(array,anotherArray,length(how much array size(block) from first index)
            var no2 = new int[10];
            Array.Copy(numbers,no2,2);
            Array.ForEach(no2,Console.Write);
            //Array.Sort(array)
            //Array.Reverse(array) 
            
            
        }
    }
}
