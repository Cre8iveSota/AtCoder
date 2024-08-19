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
            string X = Console.ReadLine();
            string ans = "";
            if (X.LastIndexOf(".") >= 0)
                ans = X.TrimEnd('0').TrimEnd('.');
            else
                ans = X;
            Console.WriteLine(ans);
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