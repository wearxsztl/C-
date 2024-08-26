using System;


// See https://aka.ms/new-console-template for more information

namespace Lessons_core
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = {1, 10, 3, 45, 77, 45, 63};
            //Console.WriteLine(myArray[myArray.Length - 1]);
            //Console.WriteLine(myArray[^1]); // ^1 просим первый элемент с конца
            //int[] myArray2 = myArray[1..4]; Выведится 10 3 и 45 4элемент не выйдет [..5]- от начала до 5го

            //Index myIndex = ^3;//без ^ is fromend покажет false
            //Console.WriteLine(myArray[myIndex]);
            //Console.WriteLine($"value {myIndex.Value} isFrom {myIndex.IsFromEnd}");


            //Index myIndex = new Index(3, true);
            //Console.WriteLine(myArray[myIndex]);
            //Console.WriteLine();
            //Console.WriteLine($"value {myIndex.Value} isFrom {myIndex.IsFromEnd}");

            //Range myRange = 1..4;
            //Range myRange = new Range(1,4);

            //int[] myArray2 = myArray[^4..^1];

            string str = "Hello World !!! =) ";

            Console.WriteLine(str[^3..]);// =)
            Console.WriteLine(str[0..6]);






        }


    }
}