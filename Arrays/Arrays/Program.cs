using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray;
            //myArray = new int[10];
            //Console.WriteLine(myArray.Length);
            //Console.ReadLine();


            //int[] myArray = new int[5] {6,3,4,89,5};
            //int[] myArray1 = new int[] {6,3,4,89,5};
            //int[] myArray2 = { 6, 3, 4, 89, 5 };

            //int[] myArray3 = Enumerable.Repeat(1, 5).ToArray();//[1,1,1,1,1]
            //int[] myArray4 = Enumerable.Range(1, 5).ToArray(); //[4,5,6,7,8]


            int[] myArray = { 10, 3, 5, 55 };

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();



        }
    }
}
