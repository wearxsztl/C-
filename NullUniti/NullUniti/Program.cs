using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullUniti
{
    internal class Program
    {
        // Null объединение

        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            //string str = "ytttttt";
            //string result;

            //if (str == null)
            //{
            //    result = "net dannyh";
            //}
            //else
            //{
            //    result = str;
            //}
            //Console.WriteLine(result);


            //string str = null; ;
            //Console.WriteLine(null ?? "net dannyh");

            //string str = null;

            //string result = str ?? "default string";
            //Console.WriteLine("Количество символов в строке " + result.Length);



            //string str = "hello";

            ////string result = str ??= "default string";//в str присваивается дефолтное значение
            //str ??= "default string";//В переменную strничего не присваивается
            //Console.WriteLine("Количество символов в строке " + str.Length);


            int[]myArray = GetArray();
            myArray ??= new int[0];
            Console.WriteLine("Количество символов в строке " + myArray.Length);
        }
    }
}
