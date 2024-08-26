using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество элементов мсассива:\t");
            
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount] ;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите числа массива под индексовм {i} :\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива: ");

            for (int i = 0 ; i < myArray.Length ; i++)
            {
                Console.WriteLine(myArray[i]);

            }

        }
    }
}
