﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_3array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[][][] myArray  = new int[rnd.Next(3,6)][][]; // 3 мерный массив, тетрадка в которой от 3х до 6 страниц

            for (int i = 0; i < myArray.Length; i++) 
            {
                myArray[i] = new int[rnd.Next(2, 6)][]; //для каждого элемента выделяем память для каждой строки в страницах
                for (int j = 0; j < myArray[i].Length; j++) 
                {
                    myArray[i][j] = new int[rnd.Next(2, 6)]; // для каждого столбца выделяем память
                    for (int k = 0; k < myArray[i][j].Length; k++) 
                    {
                        myArray[i][j][k] = rnd.Next(100);
                    }
                }

            }

            for (int i = 0;i < myArray.Length; i++)
            {
                Console.WriteLine("Page #:" + (i+1));
                for (int j = 0;j < myArray[i].Length;j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
