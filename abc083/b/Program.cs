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

            long N = inputLongArray[0];
            long A = inputLongArray[1];
            long B = inputLongArray[2];


            string result = Caliculation(N, A, B).ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }


        static long Caliculation(long N, long A, long B)
        {
            long sum = 0;
            for (long i = 0; i <= N; i++)
            {
                if (CalculationDigit(i) >= A && CalculationDigit(i) <= B)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static long CalculationDigit(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}