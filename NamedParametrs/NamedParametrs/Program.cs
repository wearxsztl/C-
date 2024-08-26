using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParametrs
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static void Main(string[] args)
        {
            int firstValue = 3;
            int secondValue = 5;
            int result = Sum(a: firstValue, b: secondValue);//Именованные параметры? присваивается значения не по порядку а конкретной переменной
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
