using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_dimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,,] myArray = new int[4, 3, 5];// Указываеим значения по оси zxy страница, строка, столбец

            //myArray[0, 2, 1] = 123;

            //Console.WriteLine(myArray[0, 2, 1]);
            //Console.ReadLine();




            ///////////////////////Inicialization 

            //int[,,] myArray3 = 
            //{
            //    {
            //        {2, 4, 5 },
            //        {45, 21, 78}
            //    },
            //    {
            //        {12, 41, 5 },
            //        {5, 201, 8}
            //    },
            //    {
            //        {20, 45, 51 },
            //        {15, 2, 38}
            //    }
            //};

            //////////////////// Инициализация четырехмерного массива

            // int[,,,] myArray4 =
            //{
            //     {
            //         {
            //             {2, 4, 5 },
            //             {45, 21, 78}
            //         },
            //         {
            //             {12, 41, 5 },
            //             {5, 201, 8}
            //         },
            //         {
            //             {20, 45, 51 },
            //             {15, 2, 38}
            //         }
            //     },
            //     {
            //         {
            //             {2, 4, 5 },
            //             {45, 21, 78}
            //         },
            //         {
            //             {12, 41, 5 },
            //             {5, 201, 8}
            //         },
            //         {
            //             {20, 45, 51 },
            //             {15, 2, 38}
            //         }
            //     }
            //
            // };


            Random rnd = new Random();

            int[,,] myArray = new int[4, 3, 5];

            for (int i = 0; i < myArray.GetLength(0); i++) //myArray.GetLength(0) хотим перебрать значения для первого измерения(перебор страниц)
            {
                for (int j = 0; j < myArray.GetLength(1); j++) //myArray.GetLength(0) хотим перебрать значения для второго измерения(перебор строк) 
                {
                    for (int k = 0; k < myArray.GetLength(2); k++) //myArray.GetLength(0) хотим перебрать значения для третего измерения(перебор столбцов)
                    {
                        myArray[i, j, k] = rnd.Next(100);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++) //myArray.GetLength(0) хотим перебрать значения для первого измерения(перебор страниц)
            {
                Console.WriteLine("Страница №: " + (i+1) );

                for (int j = 0; j < myArray.GetLength(1); j++) //myArray.GetLength(0) хотим перебрать значения для второго измерения(перебор строк) 
                {
                    for (int k = 0; k < myArray.GetLength(2); k++) //myArray.GetLength(0) хотим перебрать значения для третего измерения(перебор столбцов)
                    {
                        Console.Write(myArray[i,j,k] + " ");

                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("----------------------------------");

            }
            

            Console.ReadLine();

        }
    }
}
