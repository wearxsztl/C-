using System;
using System.Globalization;


namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string data = Console.ReadLine();
            //Console.WriteLine("Привет " + data);
            //////////////////////////////////////////////////////////////////////////////////////////

            //string str = "5";
            //int a = Convert.ToInt32(str);

            ////////////////////////////////////////

            /*String str;
            int a, b, result;
            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Введите первое число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            result = a + b;
            Console.WriteLine("Сумма чисел = " + result);
            */

            /////////////////////////////////////////
            /*string str = "5trttr";
            //double a = double.Parse(str);
            try 
            { 
                int a = Convert.ToInt32(str);
                Console.WriteLine("Успешная конвертация " + a);
            } 
            catch (Exception) 
            {
                Console.WriteLine("Неверно введены параметры");
            } */

            ////////////////////////////////////////////////

            /*string str = "5.3";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double a = double.Parse(str,  numberFormatInfo);
            */

            ///////////////////////////////////////////////

            /* string str = "4";
             int a;

             int.TryParse(str, out a);
            */

            /*string str = "5uyto";
                int a;
            bool result = int.TryParse(str, out a);

            if (result)
            {
                Console.WriteLine("Успешно " + a);
            }
            else
            { 
                Console.WriteLine("Не удалось");
            }
            */

            /*
            int a = 10;
            int b = 3;
            int c = 5;

            double result =  a + 7;
            Console.WriteLine(result);
            */

            int  a ;
            string str;
            Console.WriteLine("Введите число :");

            a = int.Parse(Console.ReadLine());
                               

            if (a % 2 != 0)
            {
                Console.WriteLine(a + " Нечетное число");
            }
            else
            {
                Console.WriteLine(a + " Четное число");
            }
        }
    }
}
