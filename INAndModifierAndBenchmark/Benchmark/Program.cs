using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{

    internal class Program
    {
        struct Point
        {
            public float x;
            public float y;
            public float z;
        }
        static void Bar(Point value)
        {

        }

        static void Foo(in Point value)
        {

        }

        static void Main(string[] args)
        {
            Point a = new Point();
            
            Stopwatch sw = Stopwatch.StartNew();
            
            for (int i = 0; i < int.MaxValue; i++)
            {
                Foo(a);
            }

            sw.Stop();
            Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");//вывод в милисекундах

            sw.Restart();

            for (int i = 0;i < int.MaxValue; i++)
            {
                Bar(a);
            }
            
            sw.Stop();
            Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");
            Console.ReadLine();
        }

    }
}
