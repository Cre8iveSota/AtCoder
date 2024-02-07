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

            int i = s.LastIndexOf(".");





            string result = s.Substring(i + 1);

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}