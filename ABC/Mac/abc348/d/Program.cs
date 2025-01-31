using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
            System.Console.SetIn(exStdIn);

            // 単数整数配列の入力
            var intNumArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array
            int H, W;
            H = intNumArray[0];
            W = intNumArray[1];

            string[] intNumArray2 = new string[H];
            for (int i = 1; i <= H; i++)
            {
                var intNumArray3 = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array
                for (int j = 0; j <= W; j++)
                {
                    intNumArray2[i] = Console.ReadLine();   // For given only one line array
                }
            }


            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 複数整数配列の入力を各indexに基づき、index毎にそれぞれの変数に保存 まとめて保持したいとき
            int maxNum = 0;
            (int x, int y, int e)[] xyz = new (int, int, int)[n];
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                xyz[i].x = int.Parse(line[0]);
                xyz[i].y = int.Parse(line[1]);
                xyz[i].e = int.Parse(line[2]);
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {
        //     // 複数整数配列の入力を各indexに基づき、index毎にそれぞれの変数に保存
        //     int maxNum = 0;
        //     int[] numarray1 = new int[maxNum];
        //     int[] numarray2 = new int[maxNum];
        //         for (int i = 0; i<maxNum; i++)
        //         {
        //             string[] line = Console.ReadLine().Split(" ");
        //     numarray1[i] = int.Parse(line[0]);
        //     numarray2[i] = int.Parse(line[1]);
        // }
    }
}