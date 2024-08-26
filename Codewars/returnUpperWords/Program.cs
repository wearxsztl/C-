using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace returnUpperWords
{
    internal class Program
    {
        static string ToUpperCasePhrase(string phrase)
        {
            string result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase.ToLower()); 
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            string phrase = "Hello my best friend";
            ToUpperCasePhrase(phrase);
        }
    }
}
