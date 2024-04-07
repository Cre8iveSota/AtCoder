using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
            // System.Console.SetIn(exStdIn);

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            List<int> ox = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    ox.Add(0);
                }
                else
                {
                    ox.Add(1);
                }
            }

            foreach (int i in ox)
            {
                if (i == 1)
                {
                    Console.Write("o");
                }
                else
                {
                    Console.Write("x");
                }
            }
            Console.WriteLine();

        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}