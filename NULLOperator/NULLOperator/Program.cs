using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NULLOperator
{
    internal class Program
    {
        //static int[] GetArray()
        //{
        //    int[] myArray = { 1, 2, 3};
        //    return myArray;
        //}

        //static void Main(string[] args)
        //{
        //    int[] myArray  = GetArray();
        //    Console.WriteLine("Сумма элементов массива" + myArray.Sum());

        //}

        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            Console.WriteLine("Сумма элементов массива" + (myArray?.Sum() ?? 0)); // если в массиве null то количество не выведится. ?? - объединение с 0 

     
        }


        // Example: get number 
        //Console.Writeline(person?.Contacts?.PhoneNumber ?? "not data")



    }
}
