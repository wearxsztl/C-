using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleAndFloat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0 / 0.0;
            Console.WriteLine(double.IsInfinity(a)); //true

            double b = 0.0 / 0.0;
            Console.WriteLine(double.IsNaN(b)); // true

            double c = double.MaxValue + double.MaxValue;
            Console.WriteLine(double.IsInfinity(c)); // true
        }
    }
}
