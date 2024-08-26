using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenAndOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                uint oddNumbersCount = 0;
                uint evenNumberCount = 0;

                int oddNumbersSumm = 0;
                int evenNumbersSumm = 0;

                Console.WriteLine("Введите первое число диапазона: ");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите последнее число диапазона: ");
                int limit = int.Parse(Console.ReadLine());
               

                while (count <= limit)
                {

                    

                    if ((count % 2) > 0)
                    {
                        oddNumbersCount++;
                        oddNumbersSumm = oddNumbersSumm + count;
                    }
                    else
                    {
                        evenNumberCount++;
                        evenNumbersSumm += count;
                       
                    }
                    count++;

                    

                     
                }
                Console.WriteLine("Колличество четных чисел: " + evenNumberCount);
                Console.WriteLine("Колличество не четных чисел: " + oddNumbersCount);
                Console.WriteLine("Сумма четных чисел: " + evenNumbersSumm);
                Console.WriteLine("Сумма не четных чисел: " + oddNumbersSumm);
                Console.ReadLine();
            }
        }
    }
}
