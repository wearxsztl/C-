using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticCompletion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte agressor = 1;
            byte democracyModifire = 1;

            try
            {
                agressor = checked((byte)(agressor - democracyModifire));
                Console.WriteLine(agressor);
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Error");
            }

        }
    }
}
