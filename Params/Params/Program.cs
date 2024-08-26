using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        /// <summary>
        // Params складывает все числа, модификатор params указывается в конце, модификатор может быть только 1 в методе
        /// </summary>
        
        static int Sum(params int[] parametrs)// Params складывает все числа, модификатор params указывается в конце, модификатор может быть только 1 в методе
        {
            int result = 0;
            for (int i = 0; i < parametrs.Length; i++)
            {
                result += parametrs[i];

            }
            return result;
        }

        static void Main(string[] args)
        {
            int result = Sum(4, 5, 6);
            Console.WriteLine(result);
        }
    }
}
