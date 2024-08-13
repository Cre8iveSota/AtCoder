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

            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int a = int.Parse(s.Substring(i, 1));
                if (a == 1) { cnt++; }
            }


            string result = cnt.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}