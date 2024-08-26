using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    internal class Program
    {
        static int IndexReturn(int [] myArray, int number) 
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == number) 
                {
                    return i;

                }

            }

            return -1;
        }

        static int[] GetRandomArray(uint lenght, int minValue, int maxValue) 
        {
            int[] myArray = new int[lenght];
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++) 
            {
                myArray[i] = random.Next(minValue, maxValue);
            }


            return myArray;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Введите число от 1 до 10 :");
            //int number = int.Parse(Console.ReadLine());

            int[] myArray = GetRandomArray(10, -10, 20);// длинна мин значение и макс значение

            int result = IndexReturn(myArray, 11);//Передаем массив и искомое число
            Console.WriteLine(result);
        }
    }
}
