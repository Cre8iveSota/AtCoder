using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NK = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            int N = NK[0];
            int K = NK[1];
            int[] A = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            A = (new int[] { 0 }).Concat(A).ToArray();
            int[] B = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            B = (new int[] { 0 }).Concat(B).ToArray();
            int[] C = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            C = (new int[] { 0 }).Concat(C).ToArray();
            int[] D = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
            D = (new int[] { 0 }).Concat(D).ToArray();

            int[] AB = new int[N * N + 1];
            int[] CD = new int[N * N + 1];
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++) AB[(i - 1) * N + j] = B[j] + A[i];
            }
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++) CD[(i - 1) * N + j] = D[j] + C[i];
            }

            Array.Sort(AB);
            Array.Sort(CD);
            bool ok = false;
            for (int i = 1; i <= N * N; i++)
            {
                int target = K - AB[i];
                int index = Array.BinarySearch(CD, target);
                if (index >= 0) { ok = true; }
            }

            if (ok) Console.WriteLine("Yes");
            else Console.WriteLine("No");
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