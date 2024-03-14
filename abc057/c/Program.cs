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
            long n = long.Parse(Console.ReadLine());
            long ans = -1;
            for (long i = 1; i * i <= n; i++)
            {
                if (n % i != 0) continue;
                long a = n / i;
                long b = i;
                long acnt = 1;
                long bcnt = 1;
                while (a / 10 > 0)
                {
                    a /= 10;
                    acnt++;
                }
                while (b / 10 > 0)
                {
                    b /= 10;
                    bcnt++;
                }
                if (ans == -1 || ans >= Math.Max(acnt, bcnt))
                { ans = Math.Max(acnt, bcnt); }
            }
            Console.WriteLine(ans);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}