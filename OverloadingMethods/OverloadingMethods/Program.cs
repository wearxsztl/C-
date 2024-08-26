using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    internal class Program
    {
        /*
        *   Перегрузка методов
        */

        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Вызвращает сумму трех целых чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Возвращает суммух двух дробных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b ;
        }

        static void Main(string[] args)
        {
            double result = Sum(2.4,6.7);
            Console.WriteLine(result);
 //           Sum()
        }
    }
}
