using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivod_4h_merniyMassiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////Вывести 4х мерный массив, есть 4 тетради, 2 страницы, в которой таблицы 3 строки и 5 столбцов 
            Random rnd = new Random();

            int[,,,] myArray = new int[4,2,3,5];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for(int k = 0; k < myArray.GetLength(2); k++)
                    {
                        for (int a = 0; a < myArray.GetLength(3); a++)
                        {
                            myArray[i, j, k, a] = rnd.Next(100);
                        }
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                
                Console.WriteLine("----Book---- №:" + (i+1));
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("--Page-- №: " + (j+1) );
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.WriteLine();
                        for (int a = 0; a < myArray.GetLength(3); a++)
                        {
                            Console.Write(myArray[i,j,k,a] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
