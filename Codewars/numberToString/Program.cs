using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberToString
{
    internal class Program
    {
        enum Dozen
        {
            Ten = 10,
            Twenty = 20,
            Thirty = 30,
            Forty = 40,
            Fifty = 50,
            Sixty = 60,
            Seventy = 70,
            Eighty = 80,
            Ninety = 90

        }
        static void underTenValue(string value)
        {
            switch (value)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                
                
            }
        }

        static void afterTenValue(string value)
        {
            switch (value)
            {
                case "0":
                    Console.WriteLine("Ten");
                    break;
                case "1":
                    Console.WriteLine("Eleven");
                    break;
                case "2":
                    Console.WriteLine("Twelve");
                    break;
                case "3":
                    Console.WriteLine("Thirteen");
                    break;
                case "4":
                    Console.WriteLine("Fourteen");
                    break;
                case "5":
                    Console.WriteLine("Fiveteen");
                    break;
                case "6":
                    Console.WriteLine("Sixteen");
                    break;
                case "7":
                    Console.WriteLine("Seventeen");
                    break;
                case "8":
                    Console.WriteLine("eightteen");
                    break;
                case "9":
                    Console.WriteLine("nineteen");
                    break;


            }
        }
        static string NumberToString(string number)
        {
            
            string[] array = number.Select(x => x.ToString()).ToArray(); //Переводим в стринговый массив чисел
            if (array.Length <= 1)
            {
                underTenValue(array[0]);
            }
            else if (array.Length <= 2 && array[0] == "1")
            {
                afterTenValue(array[1]);
            }
            else if(array.Length <= 2 && array[0] == "2")
            {

            }
            else if (array.Length <= 2 && array[0] == "2")
            {
                Dozen dozen = Dozen.Twenty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "3")
            {
                Dozen dozen = Dozen.Thirty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "4")
            {
                Dozen dozen = Dozen.Forty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "5")
            {
                Dozen dozen = Dozen.Fifty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "6")
            {
                Dozen dozen = Dozen.Sixty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "7")
            {
                Dozen dozen = Dozen.Seventy;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "8")
            {
                Dozen dozen = Dozen.Eighty;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            else if (array.Length <= 2 && array[0] == "9")
            {
                Dozen dozen = Dozen.Ninety;
                Console.Write(dozen + " ");
                underTenValue(array[1]);
            }
            return "str";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            NumberToString(number);
            
        }
    }
}
