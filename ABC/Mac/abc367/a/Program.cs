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

            int[] ABC = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int A = ABC[0];
            int B = ABC[1];
            int C = ABC[2];
            bool ok = false;

            if (B >= C)
            {
                if (A < B && C <= A)
                {
                    ok = true;
                }
            }
            else if (A >= C)
            {
                ok = true;
            }
            else if (A < B && B <= C)
            {
                ok = true;
            }

            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
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
}