using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutTipes
{
    internal class Program
    {
        static void Foo(float   a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            double a = 5;
             Foo((float)a);
        }
    }
}
