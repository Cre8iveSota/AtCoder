using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
            // System.Console.SetIn(exStdIn);

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 単数整数配列の入力
            var intNumArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array

            string ans = "";
            for (int i = 0; i < n - 1; i++)
            {
                ans += (intNumArray[i] * intNumArray[i + 1]).ToString();
                if (i != n - 2)
                {
                    ans += " ";
                }
            }
            Console.WriteLine(ans);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}