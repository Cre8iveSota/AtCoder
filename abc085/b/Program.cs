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
            int N = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < N; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            int result = input.Distinct().Count();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}