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
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            for (int i = 0; i < 10; i++)
            {
                if (inputLongArray[0] + inputLongArray[1] != i)
                {
                    Console.Write(i);
                    break;
                }
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}