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

            // 単数整数配列の入力
            var intNumArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array
            string piano = "wbwbwwbwbwbw";
            int WN = intNumArray[0];
            int BN = intNumArray[1];

            while (piano.Length < 200)
            {
                piano += piano;
            }

            // if (WN < BN || WN - BN > 2)
            // {
            //     Console.WriteLine("No");
            // }
            // else
            // {
            //     Console.WriteLine("Yes");
            // }
            string ans = "";
            bool ok = false;
            for (int i = 0; i < 200 - (WN + BN); i++)
            {
                string candetate = piano.Substring(i, WN + BN);
                if (CountChar(candetate, 'w') == WN && CountChar(candetate, 'b') == BN)
                {
                    Console.WriteLine("Yes");
                    ok = true;
                    break;
                }
            }



            // for (int j = 0; j < 200 - (WN + BN); j++)
            // {
            //     for (int i = 0; i < WN + BN; i++)
            //     {
            //         ans += piano[i + j];
            //     }
            //     if (ans.Length == WN + BN)
            //     {
            //         if (CountChar(ans, 'w') == WN && CountChar(ans, 'b') == BN)
            //         {
            //             Console.WriteLine("Yes");
            //             ok = true;
            //         }
            //     }
            // }
            if (!ok)
            {
                Console.WriteLine("No");
            }

        }
        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}