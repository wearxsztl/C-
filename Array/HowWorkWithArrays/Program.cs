using System;
using System.Collections.Generic;
using System.Linq; //extension
using System.Text;
using System.Threading.Tasks;

namespace HowWorkWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 122, 3, 85, 49, 9, 86, 6, 35, 48, 85, 23, 6, 96, 23 };

            Console.WriteLine("Минимальное число в массиве: " + myArray.Min());
            Console.WriteLine("Максимально число в массиве: " + myArray.Max());
            Console.WriteLine("Сумма всех элементов в массиве: " + myArray.Sum());
            Console.WriteLine("Сумма всех четных элементов в массиве: " + myArray.Where(i => i % 2 == 0 ).Sum());
            Console.WriteLine("Минимальное число в массиве: " + myArray.Where(i => i % 2 != 0).Min());

            //int[] result = myArray.Distinct().ToArray();  Оставить только уникальные элементы в массиве, убрать повторяющиеся
            //int[] result = myArray.OrderBy(i => i).ToArray();Сортировка по возростанию orderByDescending сотировка по убыванию

            //Array.Sort(myArray); Сортировка
            //int result = Array.Find(myArray, i => i < 70);  поиск по условию, выведет первый элемент соответствующий условию
            //int result = Array.FindLast(myArray, i => i < 70); поиск с конца массива
            //int[] result = Array.FindAll(myArray, i => i < 70); возвращает все число соответствующие условию

            //int result = Array.FindIndex(myArray, i => i == 86);
            //Console.WriteLine(result);

            //Array.Reverse(myArray); меняет порядок на обратный

            //int[] result = myArray.Where(i=> i < 70).ToArray(); все числа меньше 70, т.е повторили функционал метода FindAll класса Array
            
            //int result = myArray.Where(i=> i<70).First(); передеат первое число если нет числа подходящее условию то используем FirstOrDefault возвращает дефолтное значение для типа данных
            Console.ReadLine();
        }
    }
}
