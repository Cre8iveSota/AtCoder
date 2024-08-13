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
            int slength = s.Length;
            bool ok = true;
            string a = s.Substring(0, 1);
            string b = s.Substring(slength - 1, 1);
            if (s.Substring(0, 1) == "<" && s.Substring(slength - 1, 1) == ">")
            {

                for (int i = 1; i <= slength - 2; i++)
                {
                    if (s.Substring(i, 1) != "=")
                    {
                        ok = false;
                    }
                }
            }
            else
            {
                ok = false;
            }

            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }

    //よく使うコードなどあれば
    class Utils
    {

    }
}