using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefPassingArgumentsByReference
{
    internal class Program
    {

        /*
         * Ключевое слово ref
         *  
         */

        /*
         * Передача аргументов
         */

        //static void Foo(int a)
        //{
        //    a = -5;
        //}
        //static void Bar(int b) 
        //{}
        //static void Main(string[] args)
        //{
        //    int a = 2;
        //    Foo(a);
        //    Console.WriteLine(a);// а разные переменные, выведится 2
        //}

        //static void Foo(ref int a)
        //{
        //    a = -5;
        //}
        //static void Bar(int b) 
        //{}
        //static void Main(string[] args)
        //{
        //    int a = 2;
        //    Foo(ref a);
        //    Console.WriteLine(a);// а получается ссылочного типо? переменная не копируется а ссылается, поэтому а меняет свое значение
        //}



        static void Main(string[] args)
        {
            int[] myArray = { 42, 12, 3, 0, 5 };
            ref int b = ref myArray[0];
            b = -5; 
            //ссылаясь на значение в массиве и присваивая в переменнную б, изменится и значение в массиве
        }
    }
}
