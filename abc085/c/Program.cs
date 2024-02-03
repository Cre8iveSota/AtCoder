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
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            int n = inputLongArray[0];
            int sum = inputLongArray[1];
            string result = "a";
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    for (int k = 0; k <= n - j - i; k++)
                    {
                        if (i + j + k == n)
                        {
                            int tempSum = 10000 * i + 5000 * j + 1000 * k;
                            if (tempSum == sum)
                            {
                                result = $"{i} {j} {k}";
                            }
                        }
                    }
                }

            }

            if (result == "a")
            {
                result = "-1 -1 -1";
            }

            Console.WriteLine(result);
            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}