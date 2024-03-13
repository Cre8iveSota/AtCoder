using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(" ");
        int N = int.Parse(line[0]);
        int M = int.Parse(line[1]);

        int[] S = new int[5];
        int[] C = new int[5];
        for (int i = 0; i < M; i++)
        {
            string[] lineB = Console.ReadLine().Split(" ");
            S[i] = int.Parse(lineB[0]) - 1;
            C[i] = int.Parse(lineB[1]);
        }

        bool ok = true;
        for (int ans = 0; ans < 1000; ans++)
        {
            if (ans.ToString().Length != N) { continue; }
            ok = true;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i == S[j] && C[j] != int.Parse(ans.ToString()[i].ToString()))
                    {
                        ok = false;
                        break;
                    }
                }
                if (!ok) { break; }
            }
            if (ok) { Console.WriteLine(ans); break; }
        }

        if (!ok) Console.WriteLine(-1);
    }
}