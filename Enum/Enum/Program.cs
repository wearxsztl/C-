﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                ConsoleKey key = Console.ReadKey().Key;

                int keyCode = (int)key;

                Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

                if(key == ConsoleKey.Enter)
                {
                    Console.WriteLine("You enter enter!");
                }
            }


        }
    }
}
