using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 単数整数配列の入力
            var intNumArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array
            var intNumArray2 = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();   // For given only one line array
            int N = intNumArray[0];
            int K = intNumArray[1];

            List<int> item = new List<int>();
            foreach (int i in intNumArray2)
            {
                if (i % K == 0)
                {
                    item.Add(i / K);
                }
            }

            for (int i = 0; i < item.Count; i++)
            {
                if (i != 0) { Console.Write(" "); }
                Console.Write(item[i]);
            }
            Console.WriteLine();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}