using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Введите первое число: ");
            string a1 = Console.ReadLine();
            int a = Convert.ToInt32(a1);

            Console.WriteLine("Введите первое число: ");
            string b1 = Console.ReadLine();
            int b = Convert.ToInt32(b1);

            Console.WriteLine("Введите первое число: ");
            string c1 = Console.ReadLine();
            int c = Convert.ToInt32(c1);

            int result = a + b + c;
            Console.WriteLine("Результат суммы этих чисел :" + result);
            int result1 = a * b * c;
            Console.WriteLine("Результат умножения этих чисел :" + result1);
            */

            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Введите первое число:");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");

            secondValue = double.Parse(Console.ReadLine());

            double summ = firstValue + secondValue + thirdValue;
            Console.WriteLine("Сумма чисел равно " + summ);

            double multiplicateon = firstValue * secondValue * thirdValue;
            Console.WriteLine("Произведение чисел равно " + multiplicateon);

        }
    }
}
