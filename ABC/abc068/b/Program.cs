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
            int n = int.Parse(Console.ReadLine());

            int maxDividableNum = 1;
            int ansNum = 1;

            for (int i = 1; i <= n; i++)
            {
                if (DividableCount(i) > maxDividableNum)
                {
                    maxDividableNum = DividableCount(i);
                    ansNum = i;
                }
            }
            Console.WriteLine(ansNum);
        }

        static int DividableCount(int n)
        {
            int cnt = 0;
            while (n % 2 == 0) { n = n / 2; cnt++; }
            return cnt;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}