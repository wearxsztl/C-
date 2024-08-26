using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Влоденные_Циклы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту прямоугольника: ");
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширина прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            for (int j = 0; j < hight; j++)
            {
                
                for (int i = 0; i < width; i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();    

            }
                    Console.ReadLine();

                
            
        }
    }
}
