using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');

            int a = int.Parse(inputStrArray[0]);
            int b = int.Parse(inputStrArray[1]);
            if (a * b % 2 == 0)
            {
                string result = "Even";
                Console.WriteLine(result);
            }
            else
            {
                string result = "Odd";
                Console.WriteLine(result);
            }

            // Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {
    }
}