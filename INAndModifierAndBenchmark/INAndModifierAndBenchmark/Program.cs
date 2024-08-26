using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INAndModifierAndBenchmark
{

    /// <summary>
    /// ключевое слово IN допукскает только просмотр переменной но не изменнение
    /// </summary>
    internal class Program
    {
        static void Foo(in int x)
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int a = 1;
            Foo(a);

        }
    }
}
