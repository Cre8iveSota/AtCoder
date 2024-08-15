using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hwn = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int H = hwn[0];
            int W = hwn[1];
            int N = hwn[2];
            int[] A = new int[N + 1];
            int[] B = new int[N + 1];
            int[] C = new int[N + 1];
            int[] D = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                A[i] = row[0];
                B[i] = row[1];
                C[i] = row[2];
                D[i] = row[3];
            }
            int[][] X = new int[H + 1][];
            for (int i = 0; i <= H; i++)
            {
                X[i] = new int[W + 1];
            }
            int[][] Z = new int[H + 1][];
            for (int i = 0; i <= H; i++)
            {
                Z[i] = new int[W + 1];
            }
            for (int i = 1; i <= N; i++)
            {
                X[A[i]][B[i]]++;
                if (C[i] + 1 <= H && D[i] + 1 <= W)
                    X[C[i] + 1][D[i] + 1]++;
                if (A[i] <= H && D[i] + 1 <= W)
                    X[A[i]][D[i] + 1]--;
                if (C[i] + 1 <= H && B[i] <= W)
                    X[C[i] + 1][B[i]]--;
            }
            for (int i = 1; i <= H; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    Z[i][j] = X[i][j] + Z[i][j - 1];
                }
            }
            for (int j = 1; j <= W; j++)
            {
                for (int i = 1; i <= H; i++)
                {
                    Z[i][j] += Z[i - 1][j];
                }
            }

            for (int i = 1; i <= H; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    if (j == W)
                    {
                        Console.WriteLine(Z[i][j]);
                    }
                    else
                    {
                        Console.Write(Z[i][j] + " ");
                    }
                }
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {
        // 文字列の入力
        public static string StringIn() { return Console.ReadLine(); }
        // 文字配列
        public static string[] StringArrayIn() { return Console.ReadLine().Split(' '); }
        // 単数整数配列の入力
        public static int[] IntArray1In()
        {
            int[] line = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            return line;
        }
        public static (int N1, int N2) IntArray2In()
        {
            int[] line = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            return (line[0], line[1]);
        }
        // 複数整数配列の入力を各indexに基づき、index毎にそれぞれの変数に保存
        public static (int[] expectedInputData1, int[] expectedInputData2) IntArrayDoubleIn(int maxNum)
        {
            int[] expectedInputData1 = new int[maxNum];
            int[] expectedInputData2 = new int[maxNum];
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                expectedInputData1[i] = int.Parse(line[0]);
                expectedInputData2[i] = int.Parse(line[1]);
            }
            return (expectedInputData1, expectedInputData2);
        }

        // 座標複数
        public static (int x, int y, int z)[] IntXyzIn(int maxNum)
        {
            (int x, int y, int z)[] xyz = new (int, int, int)[maxNum];
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                xyz[i].x = int.Parse(line[0]);
                xyz[i].y = int.Parse(line[1]);
                xyz[i].z = int.Parse(line[2]);
            }
            return xyz;
        }

        // ジャグ配列
        public static int[][] IntJaggedArrayIn(int maxNum)
        {
            int[][] jaggedArray = new int[maxNum][];
            for (int i = 0; i < maxNum; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            }
            return jaggedArray;
        }

        //bit
        public static int[] DecimalToBit(int decimalNum, int intendedDigit)
        {
            int[] bit = new int[intendedDigit];
            for (int i = 0; i < intendedDigit; i++)
            {
                int div = 1 << i;
                bit[i] = (decimalNum / div) % 2;
            }
            return bit;
        }
    }
}