using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveSumm
{
    internal class Program
    {
        static string[] returnSumm(string str)
        {
            string[] newstr = str.Split(' ');
            return newstr;
        }
        static void Main(string[] args)
        {
            string Array = "I love arrays they are my favorite"; 
                returnSumm(Array);
        }
    }
}
