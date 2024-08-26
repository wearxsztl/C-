using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[][] myArray = new int[4][];// 2мерный зубчатый массив с 4мя строками


            //int[,] myArray2 = new int[4, 10];

            //int myArrayRank = myArray.Rank;// rank колличество измерений
            //int myArrayRank2 = myArray2.Rank;

            //int myArrayLength = myArray.Length;
            //int myArrayLength2 = myArray2.Length;

            myArray[0] = new int[5];
            myArray[1] = new int[6];
            myArray[2] = new int[2];
            myArray[3] = new int[3];

            Random random = new Random();

            for (int i = 0; i < myArray.Length; i++) 
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for(int i = 0; i < myArray.Length; i++) 
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

            
        }
    }
}
