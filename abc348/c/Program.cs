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

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 複数整数配列の入力を各indexに基づき、index毎にそれぞれの変数に保存
            int maxNum = n;
            int[] A = new int[maxNum];
            int[] C = new int[maxNum];
            Dictionary<int, int> valueType = new Dictionary<int, int>();
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                A[i] = int.Parse(line[0]);
                C[i] = int.Parse(line[1]);

                if (!valueType.ContainsKey(C[i]))
                {
                    valueType.Add(C[i], A[i]);
                }
                else if (valueType.ContainsKey(C[i]) && valueType[C[i]] > A[i])
                {
                    valueType[C[i]] = A[i];
                }
            }
            int ans = 0;
            foreach (var i in valueType)
            {
                if (ans < i.Value)
                {
                    ans = i.Value;
                }
            }
            Console.WriteLine(ans);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}