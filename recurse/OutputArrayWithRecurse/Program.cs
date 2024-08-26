using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputArrayWithRecurse
{
    internal class Program
    {

        static void Foo(int[] array, int i = 0) 
        {

            if (i >= array.Length)
            {
                return;
            }
            Console.WriteLine(array[i]);

            i++;
            Foo(array, i++);
            

        }

        static void Main(string[] args)
        {
            int[] array = { 41, 22, 93 };

            Foo(array);
            Console.ReadLine();
        }
    }
}
