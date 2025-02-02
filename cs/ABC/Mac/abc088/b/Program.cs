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
            int n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            List<int> aliceHands = new List<int>();
            List<int> bobeHands = new List<int>();

            Array.Sort(inputLongArray);
            Array.Reverse(inputLongArray);

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    aliceHands.Add(inputLongArray[i]);
                }
                else
                {
                    bobeHands.Add(inputLongArray[i]);
                }
            }


            int result = aliceHands.Sum() - bobeHands.Sum();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}