using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.UseDebug(false, 1);
            int[] NK = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int N = NK[0];
            int K = NK[1];
            int[] R = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            List<int[]> items = new List<int[]>();
            GenerateCombinations(new int[N], 0);
            foreach (var i in items)
            {
                if (i.Sum() % K == 0) Console.WriteLine(string.Join(" ", i));
            }
            void GenerateCombinations(int[] temp, int index)
            {
                if (index == N)
                {
                    items.Add((int[])temp.Clone());
                    return;
                }
                for (int i = 1; i <= R[index]; i++)
                {
                    temp[index] = i;
                    GenerateCombinations(temp, index + 1);
                }
            }
        }
    }
}

class Utils
{
    public static void UseDebug(bool enable, int sampleNum)
    {
        if (enable)
        {
            string targetSampleFile = $"./test/sample-{sampleNum}.in";
            var exStdIn = new System.IO.StreamReader(targetSampleFile);
            System.Console.SetIn(exStdIn);
        }
    }
}
