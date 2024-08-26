using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 3, 5, 55 };

            for (int i = 0; i < myArray.Length; i++) 
            {
                Console.WriteLine(myArray[i]);
            }    

            Console.ReadLine();
        }
    }
}
