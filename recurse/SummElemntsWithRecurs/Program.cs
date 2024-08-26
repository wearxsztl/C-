using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummElemntsWithRecurs
{
    internal class Program
    {
        static int SummElementofArray(int[] array, int i = 0)
        {
           
           if (i > array.Length)
                return 0;
           
           return SummElementofArray(array, i++) + array[i];

        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            SummElementofArray(array);

        }
    }
}
