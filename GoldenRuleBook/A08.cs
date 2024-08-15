using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] HW = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int H = HW[0];
            int W = HW[1];
            int[][] X = new int[H + 1][];
            X[0] = new int[W + 1];
            for (int i = 1; i <= H; i++)
            {
                X[i] = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();
                X[i] = (new[] { 0 }).Concat(X[i]).ToArray();  // X[i] の先頭に 0 を追加
            }

            int Q = int.Parse(Console.ReadLine());
            int[] A = new int[Q + 1];
            int[] B = new int[Q + 1];
            int[] C = new int[Q + 1];
            int[] D = new int[Q + 1];
            for (int i = 1; i <= Q; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
                A[i] = row[0];
                B[i] = row[1];
                C[i] = row[2];
                D[i] = row[3];
            }
            int[][] Z = new int[H + 1][];
            for (int i = 0; i <= H; i++)
            {
                Z[i] = new int[W + 1]; // 全行を初期化
            }
            for (int i = 1; i <= H; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    Z[i][j] = Z[i][j - 1] + X[i][j];
                }
            }

            for (int i = 1; i <= H; i++)
            {
                for (int j = 1; j <= W; j++)
                {
                    Z[i][j] = Z[i - 1][j] + Z[i][j];
                }
            }

            for (int i = 1; i <= Q; i++)
            {
                //  int ans = Z[C[i]][D[i]] + Z[A[i] - 1][B[i] - 1] - Z[C[i]][1] - Z[1][D[i]];
                int ans = Z[C[i]][D[i]] - Z[A[i] - 1][D[i]] - Z[C[i]][B[i] - 1] + Z[A[i] - 1][B[i] - 1];
                Console.WriteLine(ans);
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