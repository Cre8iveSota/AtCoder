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
            var longNumArray0 = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
            long N = longNumArray0[0];
            long K = longNumArray0[1];

            // 単数整数配列の入力
            var longNumArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();   // For given only one line array
            var distinctNumbers = longNumArray.Distinct().ToList();


            long minusSum = 0;

            foreach (long a in distinctNumbers)
            {
                if (a > K)
                {
                    continue;
                }
                minusSum += a;
            }

            long ans = 0;
            long sum = 0;
            // for (long i = 0; i <= K; i++)
            // {
            //     sum += i;
            // }
            sum = K * (K + 1) / 2;

            ans = sum - minusSum;

            Console.WriteLine(ans);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}