using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            long a = inputLongArray[0];
            long b = inputLongArray[1];
            long d = inputLongArray[2];

            for (int i = 0; i <= (b - a) / d; i++)
            {
                Console.Write($"{a + d * i} ");
            }

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}