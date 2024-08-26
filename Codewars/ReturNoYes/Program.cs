using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturNoYes
{
    internal class Program
    {
        static string Kata(bool word)
        {
            return word ? "Yes": "No";
        }
        static void Main(string[] args)
        {
            bool word = false;
            Kata(word);
        }
    }
}
