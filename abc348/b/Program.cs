using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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
            int[] x = new int[maxNum];
            int[] y = new int[maxNum];

            List<int> pointDis = new List<int>();
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                x[i] = int.Parse(line[0]);
                y[i] = int.Parse(line[1]);
            }

            for (int i = 0; i < maxNum; i++)
            {
                float maxDis = 0f;
                int maxDisIndex = 0;
                for (int j = 0; j < maxNum; j++)
                {
                    float tmpDis = Vector2.Distance(new Vector2(x[i], y[i]), new Vector2(x[j], y[j]));
                    if (maxDis < tmpDis)
                    {
                        maxDis = tmpDis;
                        maxDisIndex = j + 1;
                    }
                }
                pointDis.Add(maxDisIndex);
            }
            foreach (var i in pointDis)
            {
                Console.WriteLine(i);
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}