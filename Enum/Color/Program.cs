using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color
{
    internal class Program
    {
        enum Color 
        {
            Red,
            Green,
            Blue,   
            Yellow,
            Black
        }
        static void Main(string[] args)
        {
            //var value = Enum.GetValues(typeof(color));
            //foreach (var item in value)
            //{
            //    Console.WriteLine(item); // Выводим все доступнеы значения enum
            //}

            string str = Console.ReadLine();
            Color color = (Color)Enum.Parse(typeof(Color), str, ignoreCase: true);
            Console.WriteLine(color);

            switch (color)
            {
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                case Color.Yellow:
                    break;
                case Color.Black:
                    break;
                default:
                    break;
            }
        }
    }
}
