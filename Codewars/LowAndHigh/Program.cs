using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowAndHigh
{
    internal class Program
    {
        static string LowAndHigh(string num)
        {
            string[] numbers = num.Split(' ');
            
            for (int i = 0; i > numbers.Length; i++)
            {
                
            }
            return numbers[0];
        }
        static void Main(string[] args)
        {
            string num = "4 3 8 9 -9 7 -12";
            LowAndHigh(num);
        }
    }
}
