using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HWReturn
{
    internal class Program
    {

        //     static int GetIndexValue()
        //     {
        ////         for (int i = 0; i < myArray.Length; i++)
        ////{
        ////             if (myArray[i] == number) 
        ////             {
        ////                 return i;
        ////             }
        ////}
        ////         return -1;



        //}
        static int GetIndex(int[] myArray, int number) 
        {
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (myArray[i] == number) 
                {
                    return i;
                }
            }
            return -1;
        }

        static int[] GetRandomArray(int minValue, int maxValue, uint length) 
        {
            int [] myArray = new int[length];
            Random random = new Random();

            for (int i = 0; i < length ; i++ )
            {
                myArray[i]= random.Next( minValue, maxValue );
            }

            return myArray;
        }
        static void Main(string[] args)
        {
            

            Console.WriteLine("Input nomber");
            int number = int.Parse(Console.ReadLine());

            int [] myArray = GetRandomArray(-10, 10, 5);
            Console.WriteLine(myArray.Length);

            int returnIndex = GetIndex(myArray, number);
            Console.WriteLine(returnIndex);
            //int[] myArray = { 1, 2, 3, 6, 8, 9 };
            //int number = 6;


            //int result = GetIndexValue(myArray, number);
            //Console.WriteLine(result);
        }
    }
}
