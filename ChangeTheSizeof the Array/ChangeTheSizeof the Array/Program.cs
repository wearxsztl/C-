using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTheSizeof_the_Array
{
    internal class Program
    {

        static void Resize<T>(ref T[] arr, int newSize)
        {
            T[] newArr = new T[newSize];
            
            for (int i = 0; i < newArr.Length && i < newArr.Length; i++)
                newArr [i] = arr [i];
            
            arr = newArr;
           
        }



        static void Main(string[] args)
        {
            int[] myArray = { 14, 21, 3, 17, 54 };

            Resize(ref myArray, 2);

            
        }
    }
}
