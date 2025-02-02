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
            long n = long.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            long minGuestCnt = 0;
            for (int i = 0; i < n; i++)
            {
                minGuestCnt = (minGuestCnt + a[i]) < 0 ? 0 : minGuestCnt + a[i];
            }

            Console.WriteLine(minGuestCnt);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}