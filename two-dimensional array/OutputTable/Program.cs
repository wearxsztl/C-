using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] myArray = new int[,]
           {
                {2, 45, 65, 8, 12},
                {55, 21, 39, 89, 25},
                {6, 0, 73, 91, 44}
           };

            //Console.WriteLine(myArray.GetLength(1));//Вывдоит измирения, если 2мерный массив то в 1измерении(начинается с 0) будет кол-во строк, во втором(1) столбцы

            //int height = myArray.GetLength(0);
            //int width = myArray.GetLength(1);

            for (int x = 0; x < myArray.GetLength(0); x++) 
            {
                for (int y = 0; y < myArray.GetLength(1); y++) 
                {
                    Console.Write(myArray[x,y] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
