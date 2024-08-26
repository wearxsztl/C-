using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        static int Foo(int n)
         {
            int curentNumber = n;

            int[] array = new int[5];

            for (int i = 0; curentNumber > 0; i++)
            {
                int number = curentNumber % 10;

                curentNumber -= number;
                curentNumber = curentNumber / 10;

                
                array[i] = number;

                Console.WriteLine(curentNumber);
                
            }
            return curentNumber;

        }
        static void Main(string[] args)
        {
            int n = 35231;
            

            Foo(n);
        }
    }
}
