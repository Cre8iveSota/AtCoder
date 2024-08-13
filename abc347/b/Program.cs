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

            // 文字列の入力
            string s = Console.ReadLine();
            List<string> used = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    if (!used.Contains(s.Substring(i, j)))
                    {
                        used.Add(s.Substring(i, j));
                    }
                }
            }
            Console.WriteLine(used.Count);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}