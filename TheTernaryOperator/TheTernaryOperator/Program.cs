using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool accessAllowed;
            
            //string storePassword = "qwerty";
            //string enteredPassword = Console.ReadLine();

            ////if (enteredPassword == storePassword)
            ////{
            ////    accessAllowed = true;
            ////}
            ////else
            ////{
            ////    accessAllowed = false;
            ////}

            //accessAllowed = enteredPassword == storePassword ? true : false;


            //Console.WriteLine(accessAllowed);
            //Console.ReadLine();

            int inputData = int.Parse(Console.ReadLine());
            int outputData = inputData > 0 ? inputData : 0;
            Console.WriteLine(outputData);
            
        }
    }
}
