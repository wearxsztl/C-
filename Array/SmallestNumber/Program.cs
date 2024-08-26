using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = { 2, 15, 45, 75, 34, 59, 88, 1, 76, 41, 97 };

            int minValue = myArray[0];
            int maxValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue) 
                {
                    minValue = myArray[i];
                }

                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }

            }
            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);
        }
    }
}
