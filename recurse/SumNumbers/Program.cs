using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    internal class Program
    {
        static int Sum(int number)
        {
            if (number < 10)
                return number;

            int lastnum = number % 10;
            int nextValue = number / 10;
            return Sum(nextValue) + lastnum;
        }

        static void Main(string[] args)
        {
            int number = 254;
            Sum(number);
        }
    }
}
