using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int k = height; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {                    
                    Console.Write("#");

                }
                Console.WriteLine();
            }
            Console.ReadLine(); */
            //////////////////////////////////////////////
            /*Console.WriteLine("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(height - i, i ++);
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                
            }
            Console.ReadLine();
            */

            Console.WriteLine("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");

                }
                for (int k = height; k > i; k--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
    }
}
