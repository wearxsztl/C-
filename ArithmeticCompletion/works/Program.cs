using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace works
{
    internal class Program
    {
        static bool Foo(string [] s) 
        {

            for (int i = 0; i < s.Length; i++)
            {
                char[] s2 = s[i].Distinct().ToArray();
                if(s2.Length < s[i].Length)
                {
                    return false;
                }
                Console.WriteLine(s2);
                
               
            }
            return true;
        }
        static void Main(string[] args)
        {

            string[] str = { "agaga", "qwerty", "zxcv" };

                Foo(str);

        }
    }
}
