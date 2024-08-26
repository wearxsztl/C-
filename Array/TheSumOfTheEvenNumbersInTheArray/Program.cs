using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSumOfTheEvenNumbersInTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumEvenNumbers = 0;
           
            int[] myArray = { 12, 85, 99, 69, 46, 66, 72, 6, 11, 35};

            for (int i = 0; i < myArray.Length; i++)
            {
                if ((myArray[i] % 2) == 0)
                {
                    sumEvenNumbers += myArray[i];
                }

            }
       
            Console.WriteLine(sumEvenNumbers);
        }
    }
}
