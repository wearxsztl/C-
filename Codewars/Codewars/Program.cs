using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Program
    {
        static bool Foo(int i)
        {
            return Math.Sqrt(i) % 1 == 0;
            Console.WriteLine(i);
        }


        static void Main(string[] args)
        {
            int i = -1;
            Foo(i);
        }
    }
}
