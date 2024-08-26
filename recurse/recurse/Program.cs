using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurse
{
    internal class Program
    {
        static void Foo(int i)
         {
            
            Console.WriteLine(i);

            if (i >= 3)
                return;

            i++;
            Foo(i);
        }

        static void Main(string[] args)
        {

            Foo(0);

        }
    }
}
