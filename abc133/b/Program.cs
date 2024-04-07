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

            // 単数整数配列の入力
            var intNumArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array

            // 単数整数配列の複数入力: 合ってるか未確認
            int maxNum = intNumArray[0];
            int[][] multiNumArray = new int[maxNum][];
            int cnt = 0;
            for (int i = 0; i < maxNum; i++)
            {
                multiNumArray[i] = Console.ReadLine().Split(" ").Select(i => int.Parse(i)).ToArray();
            }

            for (int i = 0; i < maxNum - 1; i++)
            {
                double ans = 0;
                for (int j = 0; j < intNumArray[1]; j++)
                {
                    ans += Math.Pow(multiNumArray[i][j] - multiNumArray[i + 1][j], 2);
                }
                if (Math.Sqrt(ans) % 1 == 0) { cnt++; }
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}