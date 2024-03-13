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

            int a = s.IndexOf("|");
            string b = s.Substring(a + 1);
            int c = b.IndexOf("|");
            string d = b.Substring(c + 1);

            // s.Substring(a);




            Console.Write(s.Substring(0, a));
            Console.WriteLine(d);
            // Console.WriteLine(s.Substring(a + 1));
            // Console.WriteLine(s.Substring(0, a));
            // Console.WriteLine(s.Substring(b));


        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}