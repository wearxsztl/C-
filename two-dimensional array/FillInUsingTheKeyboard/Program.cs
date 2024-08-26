using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillInUsingTheKeyboard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[,] myArray = new int[10,6];

            //Random rnd = new Random(); // Random генерирует случ числа, сразу создали и выделили место в оперативной памяти

            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        myArray[i, j] = rnd.Next(0, 100);// можно оставить пустым
            //    }
            //}


            //        for (int x = 0; x < myArray.GetLength(0); x++)
            //{
            //    for (int y = 0; y < myArray.GetLength(1); y++)
            //    {
            //        Console.Write(myArray[x, y] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //int[,] myArray = new int[3, 3];


            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray.GetLength(1); j++)
            //    {
            //        Console.WriteLine("Введите значение массива с координатами X: " + i +  "  Y: " + j);
            //        myArray[i,j] = int.Parse( Console.ReadLine());
            //    }
            //}


            //for (int x = 0; x < myArray.GetLength(0); x++)
            //{
            //    for (int y = 0; y < myArray.GetLength(1); y++)
            //    {
            //        Console.Write(myArray[x, y] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            string[,] myArray = new string[3, 3];


            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Введите значение массива с координатами X: " + i + "  Y: " + j);
                    myArray[i, j] = Console.ReadLine();
                }
            }


            for (int x = 0; x < myArray.GetLength(0); x++)
            {
                for (int y = 0; y < myArray.GetLength(1); y++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
