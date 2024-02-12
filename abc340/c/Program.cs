using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static Dictionary<long, long> usedNumberMemory = new Dictionary<long, long>();

        static void Main(string[] args)
        {
            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(MakeTwoNumByDevide(n));
            Console.Out.Flush();
        }

        static long MakeTwoNumByDevide(long num)
        {
            if (usedNumberMemory.ContainsKey(num))
            {
                return usedNumberMemory[num];
            }
            if (num < 2)
            {
                return 0;
            }
            return usedNumberMemory[num] = MakeTwoNumByDevide((num + 1) / 2) + MakeTwoNumByDevide(num / 2) + num;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}