using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoid
{
    internal class Program
    {
        
        static void PrintLine() 
        {
            Console.WriteLine("Метод PrintLine ВЫЗВАН ");
        }
        static void Main(string[] args)
        {
            PrintLine();
        }
    }
}
