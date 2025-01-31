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
            int fiveHundreds = int.Parse(Console.ReadLine());
            int hundreds = int.Parse(Console.ReadLine());
            int fifties = int.Parse(Console.ReadLine());
            int targetSum = int.Parse(Console.ReadLine());
            int cnt = 0;
            int tempSum = 0;

            for (int fh = 0; fh <= fiveHundreds; fh++)
            {
                for (int h = 0; h <= hundreds; h++)
                {
                    for (int f = 0; f <= fifties; f++)
                    {
                        tempSum = fh * 500 + h * 100 + f * 50;
                        if (targetSum == tempSum)
                        {
                            cnt++;
                        }
                    }
                }
            }

            string result = cnt.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {
        /// <summary>
        /// 素因数分解。
        /// 出展：https://qiita.com/y_miyoshi/items/da814d96e8890224aad3
        /// </summary>
        public static IEnumerable<long> PrimeFactorsImpl(long n)
        {
            long i = 2;
            long tmp = n;

            while (i * i <= n) //※1
            {
                if (tmp % i == 0)
                {
                    tmp /= i;
                    yield return i;
                }
                else
                {
                    i++;
                }
            }
            if (tmp != 1) yield return tmp;//最後の素数も返す
        }
    }
}