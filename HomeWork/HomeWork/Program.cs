using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string firstValue, secondValue;

            Console.WriteLine("Введите первое число:");
            firstValue = Console.ReadLine();
            int str1 = Convert.ToInt32(firstValue);


            Console.WriteLine("Введите первое число:");
            secondValue = Console.ReadLine();
            int str = Convert.ToInt32(secondValue);

            double result = (double)(str1 + str) / 2 ;
            Console.WriteLine("Среднее арифметическое равно:" + result);
            */

            double firstValue, secondValue;

            Console.WriteLine("Введите первое число:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2;
        }
    }
}
