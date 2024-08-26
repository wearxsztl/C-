using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UsdToTenge = 453.12;
            double UsdToRub = 4.96;
            double USD;

            Console.WriteLine("Введите сумму в долларах: ");
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма долларов в тенге: " + UsdToTenge * USD);
            Console.WriteLine("Сумма долларов в рублях: " + UsdToRub * USD);
        
        
        
        
        
        
        }


    }
}
