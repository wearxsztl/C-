using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[,] myArray;//создаем әмерный массив
            //myArray = new int[3, 5];//выделяем под него место в опервтивной памяти

            int[,] myArray = new int[3, 5];

            // myArray[0,2] = 85;

            int[,] myArray2 = 
            { 
                {2, 45, 65, 8, 12},
                {55, 21, 39, 89, 25},
                {6, 0, 73, 91, 44}
            };


            Console.WriteLine(myArray2[0,2]);
        }
    }
}
