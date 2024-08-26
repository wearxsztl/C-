using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите колличество элементов мсассива:\t");
            int elementsCoount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCoount];
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите число массива с индексом {i} : \t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива: ");

            for (int i = myArray.Length; i <= myArray.Length; i--)
            {
                Console.WriteLine(myArray[i-1]);

            }
        }
    }
}
