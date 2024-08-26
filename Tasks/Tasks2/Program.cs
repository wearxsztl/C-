using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tasks2
{
    internal class Program
    {
        public static int basicOp(bool[] sheeps)
        {
            return sheeps.Count(s => s);
            
        }
        static void Main(string[] args)
        {
            bool[] sheeps = { true, false, true };

            basicOp(sheeps);
        }
    }
}
