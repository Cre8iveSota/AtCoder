using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            // 整数の入力
            long n = long.Parse(Console.ReadLine());
            if (SearchDiviserNum(n) == 8) { cnt++; }
            Console.WriteLine(cnt);
        }

        static long SearchDiviserNum(long num)
        {
            long ansCnt = 0;
            for (long i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    ansCnt++;
                }
            }
            return ansCnt;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}