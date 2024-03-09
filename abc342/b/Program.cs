using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数の入力
            long n1 = long.Parse(Console.ReadLine());
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            // 整数の入力
            long nn = long.Parse(Console.ReadLine());

            long[,] inputQuery = new long[nn, 2];

            for (int i = 0; i < nn; i++)
            {
                var tempQuery = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
                inputQuery[i, 0] = tempQuery[0];
                inputQuery[i, 1] = tempQuery[1];
                // Console.Write(inputQuery[i, 0]);
                // Console.Write("_");
                // Console.WriteLine(inputQuery[i, 1]);
            }

            for (int i = 0; i < nn; i++)
            {
                if (Array.IndexOf(inputLongArray, inputQuery[i, 0]) < Array.IndexOf(inputLongArray, inputQuery[i, 1]))
                {
                    Console.WriteLine(inputQuery[i, 0]);
                }
                else
                {
                    Console.WriteLine(inputQuery[i, 1]);
                }
            }
        }

        //よく使うコードなどあれば    
        class Utils
        {

        }

    }
}