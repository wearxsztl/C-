using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class Program
    {
        static int Sum(int a, int b) //модификатор+тип возвращаемого значения + название метода(параметр) параметр не обязательно в зависимости от функции
        {
            int result = a + b;

            return result;

            //return a + b;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения "  + result);
        }


        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = Sum(a, b);

            PrintResult(c);

            Console.WriteLine(c);
            Console.WriteLine("============");

        }
    }
}
