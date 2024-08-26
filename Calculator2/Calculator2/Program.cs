using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            /*------------------------------------
             * switch (c) 
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":   
                if (b == 0)
                Console.Writeline(0)
                else
                    Console.WriteLine(a / b);   
                    break;
                default: Console.WriteLine("Вы ввели неверный знак операции!!! ");
                    break;
            }--------------------------------------------
            */
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;
                try
                {
                    Console.WriteLine("Ведите первое число: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ведите второе число: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строу в число! ");
                    Console.ReadLine();
                    continue;
                }

                          

                Console.WriteLine("Введите знак операции которую вы хотите выполнить: ");
                action = Console.ReadLine();

                

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }

                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }

                if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }

                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine("На ноль делить нельзя");
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else { Console.WriteLine("Вы ввели неверный знак операции!!! ");
                    
                }

                Console.ReadLine();

            }

            
            
        }
    }
}

