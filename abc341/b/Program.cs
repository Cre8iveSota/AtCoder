using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            long Output = 0;
            // 整数の入力
            int n = int.Parse(Console.ReadLine());
            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            List<(int, int)> st = new List<(int, int)>();
            for (int i = 0; i < n - 1; i++)
            {
                var array = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                st.Add((array[0], array[1]));
            }
            // Console.WriteLine(n);
            // for (int i = 0; i < n - 1; i++)
            // {
            //     Console.WriteLine(inputintArray[i]);
            // }
            // for (int i = 0; i < n - 1; i++)
            // {
            //     Console.WriteLine(st[i]);
            // }
            // Console.WriteLine(Array.IndexOf(inputintArray, inputintArray.Max()));
            for (int i = 0; i < n - 1; i++)
            {
                inputLongArray[i + 1] += st[i].Item2 * Math.Floor(inputLongArray[i] / st[i].Item1);
            }


            Console.WriteLine(inputLongArray[n - 1]);

        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}