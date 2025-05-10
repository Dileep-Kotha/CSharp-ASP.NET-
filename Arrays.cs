using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 1, 2, 3, 4, 5 };//including size is optional
            // or int[] a={,2,3,4,5};
            Console.WriteLine("1D Array:");
            Console.WriteLine("length= "+ar.Length);
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }


            int[,] ar2 = new int[,] { {1,2,3},{4,5,6},{7,8,9} };//including size is optional
            //or int[,] ar2={ {1,2,3},{4,5,6},{7,8,9} };
            Console.WriteLine("2D Array:");
            Console.WriteLine("no of rows:"+ar2.GetLength(0));
            Console.WriteLine("no of columns:" + ar2.GetLength(1));

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ar2[{i},{j}]={ar2[i,j]}");
                }
            }




            Console.WriteLine("Jagged Array:");

            int[][] ar3 = new int[3][];//jagged arrays have arrays of diiferent length but no.of arrays should be specified
            ar3[0] = new int[] { 1, 2, 3 };
            ar3[1] = new int[] { 4, 5 };
            ar3[2] = new int[] { 6, 7, 8, 9 };

            /*
             int[][] anotherJaggedArray = new int[][]
             {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7 },
                new int[] { 8 },
                new int[] { 9, 10, 11, 12, 13 }
             };
             */
            for (int i = 0; i < ar3.Length; i++)
            {
                for (int j = 0; j < ar3[i].Length; j++)
                {
                    Console.WriteLine($"ar3[{i}][{j}]={ar3[i][j]}");
                    //i->sub array
                    //j->index of element in sub array
                }
            }
        }
    }
}
