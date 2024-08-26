using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine(i.HasValue);// False
            Console.WriteLine(i.GetValueOrDefault()); // 0
            Console.WriteLine(i.GetValueOrDefault(3)); // 3
            Console.WriteLine(i ?? 55); // 55 проверяет переменную на null, если в переменной null то возвратит 55
        }
    }
}
