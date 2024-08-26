using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int number = random.Next(0, 11);
            Console.WriteLine("Угадай число 0 до 10: ");
            int secondNumber = int.Parse(Console.ReadLine());
            
            if (number != secondNumber)
            {
                Console.WriteLine("Не верно");
                return;
            }
            else
            {
                Console.WriteLine("В точку");
            }
        }
    }
}
