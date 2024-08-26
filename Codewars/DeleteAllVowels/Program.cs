using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeleteAllVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            Console.WriteLine(Regex.Replace(str,"(?i)[euioa]", ""));
        }
    }
}
