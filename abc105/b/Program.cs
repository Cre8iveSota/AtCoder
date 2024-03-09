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

            string ret = "No";

            for (int a = 0; a <= n / 4; a++)
            {
                for (int b = 0; b <= n / 7; b++)
                {
                    if (4 * a + 7 * b == n)
                    {
                        ret = "Yes";
                        break;
                    }
                }
            }

            Console.WriteLine(ret);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}