using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OUT
{
    internal class Program
    {
        static void Fer(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 5;
            
        }

        static void Main(string[] args)
        {
            Bar(out int a); //Переменная передаваемая при вызове будет инициализирована, значение указывается при использовании out переменной должно присваиваться значение в методе

            Console.WriteLine(a);

            //string value = Console.ReadLine();
            //int.TryParse( value, out int result);
            //Console.WriteLine(result);пример
        }
    }
}
