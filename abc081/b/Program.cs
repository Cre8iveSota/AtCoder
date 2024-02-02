using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列の入力
            string s = Console.ReadLine();

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');


            int minCnt = 99999;
            for (int i = 0; i < int.Parse(s); i++)
            {
                int shou = int.Parse(inputStrArray[i]);
                int cnt = 0;
                while (shou % 2 == 0)
                {
                    shou = shou / 2;
                    cnt++;
                }
                if (cnt < minCnt)
                {
                    minCnt = cnt;
                }
            }


            int result = minCnt;

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}