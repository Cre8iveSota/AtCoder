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
            string n = Console.ReadLine();

            int cnt = 0;
            for (int i = 1; i <= int.Parse(n); i++)
            {
                if (i.ToString().Length % 2 == 1)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }

        //よく使うコードなどあれば    
        class Utils
        {

        }
    }
}