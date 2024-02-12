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
            List<int> answer = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var inputintArray = Console.ReadLine().Split(' ').Select(k => int.Parse(k)).ToArray();

                int number = inputintArray[1];

                if (inputintArray[0] == 1)
                {
                    answer.Add(number);
                }
                else
                {
                    Console.WriteLine(answer[answer.Count() - number]);
                }
            }


            Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}