using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletingFirstElementOfTheArrays
{
    internal class Program
    {
        static void RemoteElements(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            //for (int i = index; i < array.Length; i++)
            //    newArray[i ] = array[i + 1];  Ошибка при удалении последнего элемента

            for (int i = index + 1; i < array.Length; i++)
            {
                array[i - 1] = newArray[i];
            }
            
            array = newArray;
        }

        static void RemoveFirst(ref int[] array)
        {
            RemoteElements(ref array, 0);
        }

        static void RemoveLast(ref int[] array)
        {
            RemoteElements(ref array, array.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            RemoteElements(ref myArray, 4);
        }
    }
}
