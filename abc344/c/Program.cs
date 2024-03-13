using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int M = int.Parse(Console.ReadLine());
            var B = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int L = int.Parse(Console.ReadLine());
            var C = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int Q = int.Parse(Console.ReadLine());
            var X = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            List<int> sumList = new List<int>();

            for (int i = 0; i < Q; i++)
            {
                string result = "No";
                if (X[i] < A[0] + B[0] + C[0])
                {
                    Console.WriteLine(result);
                    continue;
                }
                else if (sumList.Contains(X[i]))
                {
                    result = "Yes";
                    Console.WriteLine(result);
                    continue;
                }
                else
                {
                    for (int k = 0; k < M; k++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            for (int l = 0; l < L; l++)
                            {
                                sumList.Add(A[j] + B[k] + C[l]);
                                if (X[i] == A[j] + B[k] + C[l])
                                {
                                    result = "Yes";
                                    break;
                                }
                            }
                        }
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}