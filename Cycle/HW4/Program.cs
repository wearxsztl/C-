using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну пирамиды");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int J = height; J > i ; J--)
                {
                    Console.Write(" ");
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("#");

            }


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int J = height; J > i; J--)
                {
                    Console.Write("#");
                }           

                Console.WriteLine(" ");

            }

            Console.ReadLine();
                        

            
        }
    }
}
