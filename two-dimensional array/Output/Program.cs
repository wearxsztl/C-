using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray2 = new int[,]
            {
                {2, 45, 65, 8, 12},
                {55, 21, 39, 89, 25},
                {6, 0, 73, 91, 44}
            };

            foreach (int i in myArray2) 
            {
                Console.Write(i + " ");
            }


        }
    }
}
