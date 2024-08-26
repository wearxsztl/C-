using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    internal class Program
    {
        enum DayOfWeek: byte // для оптимизации меняем тип на байт
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        static DayOfWeek GetNextDay(DayOfWeek day)
        {
            if(day< DayOfWeek.Sunday)
                return day + 1;
            
            return DayOfWeek.Monday;
        }

        static void Main(string[] args)
        { 
            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek))); // Получаем тип данных
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);//приводим dayofweek к int
            Console.WriteLine((DayOfWeek)3); // берем число 3 и приводим к типу нашего enum DayOfWeek

            DayOfWeek nextDay = GetNextDay(dayOfWeek);
            Console.WriteLine(nextDay);
        }
    }
}
