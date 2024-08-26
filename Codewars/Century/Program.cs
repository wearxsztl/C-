using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Century
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int century, x;
            int year = int.Parse(Console.ReadLine());

            
            int centuryv = year / 100;
            int z = year % 100 > 0 ? centuryv + 1 : centuryv; 
            Console.WriteLine(centuryv);


            //return (year - 1) / 100 + 1;
        }
    }
}
