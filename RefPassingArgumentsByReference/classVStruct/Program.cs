using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace classVStruct
{
    //struct MyStrukt//Структура значимый тип, данные при передаче копируются
    //{
    //    public int a;
    //    public string b;
    //    public float c;
    //}
    //internal class Program
    //{


    //    static void Foo(ref MyStrukt myStrukt)
    //    {
    //        myStrukt.a = -5;
    //    }

    //    static void Main(string[] args)
    //    {

    //        MyStrukt myStrukt= new MyStrukt();
    //        Foo(ref myStrukt);// Передача по ссылке поэтому а прменяется на -5

    //    }

    //class MyClass //Классы это ссылочные типы поэтому данные будут передаваьтся по ссылке
    //{
    //    public int a;
    //    public string b;
    //    public float c;
    //}
    //internal class Program
    //{

    // static void Foo( MyClass myClass)
    // {
    // myClass.a = -5;
    // }

    //static void Main(string[] args)
    //{

    //    MyClass myClass = new MyClass();
    //    Foo(myClass);// Передача по ссылке поэтому а прменяется на -5

    //}     
    //}



    //static void Bar( ref int[] array)
    //{
    //    array = new int[10];
    //}

    //static void Main(string[] args)
    //{
    //    int[] myArray = { 1, 2, 3 };

    //    Bar(ref myArray);  //массив myArray после вызова функции будет иметь 10 элементов, старый массив удалит сборщик мусора
    //}


}
