using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace addindInToBeginningandEnd
{
    internal class Program
    {
        static void AddElement(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i]; 
            
            for (int i = index; i < newArray.Length; i++)
                newArray[i + 1] = array[i];

            newArray = array;


        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };

            AddElement(ref myArray, 888, 1);
        }
    }
}
