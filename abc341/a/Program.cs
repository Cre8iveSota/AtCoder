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

            Console.Write(1);
            for (long i = 0; i < n; i++)
            {
                string result = "01";
                Console.Write($"{result}");
            }

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}