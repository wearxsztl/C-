using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void OutputR(char symbol, int number ) 
        {
            for (int i = 0; i < number; i++) 
            {
                Console.Write(symbol);
            }
            
        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите символ который будет отображаться: ");
            //string symbol =  Console.ReadLine();

            //Console.WriteLine("Введите колличество отображений: ");
            //int number = int.Parse( Console.ReadLine());

            //OutputR(symbol, number);
            //Console.ReadLine();

            //Для типа char


            Console.WriteLine("Введите символ который будет отображаться: ");
            char symbol = Console.ReadKey().KeyChar; 

            Console.WriteLine("\n Введите колличество отображений: ");
            int number = int.Parse(Console.ReadLine());

            OutputR(symbol, number);
            Console.ReadLine();
        }
    }
}
