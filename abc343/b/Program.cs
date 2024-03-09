using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            int[][] inputArray = new int[n][];

            var result = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                inputArray[i] = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                result.Clear();
                for (int j = 0; j < n; j++)
                {
                    if (inputArray[i][j] == 1)
                    {
                        if (result.Length != 0) { result.Append(" "); }
                        result.Append((j + 1).ToString());
                    }
                }
                Console.Write(result);
                Console.WriteLine();
            }


            // string result = "";

            // Console.WriteLine(result);

            // Console.Out.Flush();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}