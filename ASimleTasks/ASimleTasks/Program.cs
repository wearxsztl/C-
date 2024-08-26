using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASimleTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's your name? ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello: " + name);

            //Console.WriteLine("Input first number for summ ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input second number for summ ");
            //int secondNumber = int.Parse(Console.ReadLine());   
            //Console.WriteLine(firstNumber + secondNumber);

            //Console.WriteLine("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int j = 0; j <= 1; j++)
            //{


            //    for (int i = 0; i <= 3; i++)
            //    {
            //        Console.Write(number + " ");
            //    }
            //    Console.WriteLine();
            //    for (int i = 0; i <= 3; i++ )
            //    {
            //        Console.Write(number);
            //    }
            //     Console.WriteLine();
            //}
            //Console.WriteLine();


            Console.WriteLine("Input first number for summ ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second number for summ ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine(firstNumber + secondNumber + firstNumber);
            }
            else
            {
                Console.WriteLine(secondNumber + firstNumber);
            }
        }
    }
}
