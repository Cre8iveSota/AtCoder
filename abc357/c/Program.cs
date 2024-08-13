using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            #region debug
            if (false)
            {
                var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
                System.Console.SetIn(exStdIn);
            }
            #endregion

            int N = int.Parse(Console.ReadLine());
            if (N > 0)
            {
                string[,] carpet = CreateCarpetBlack(N, true);
                string[,] carpet2 = CreateCenterColorWhite(N - 1, carpet);
                PrintCarpet(CreateCenterColorWhite(N - 1, ConcatenateCarpets(carpet2, (int)Math.Pow(3, N - 1))));
            }
        }
        static string[,] CreateCarpetBlack(int i, bool isBlack)
        {
            int sideOfGrid = (int)Math.Pow(3, i);
            string[,] ret = new string[sideOfGrid, sideOfGrid];

            for (int k = 0; k < sideOfGrid; k++)
            {
                for (int j = 0; j < sideOfGrid; j++)
                {
                    if (isBlack)
                    {
                        ret[k, j] = "#";
                    }
                    else
                    {
                        ret[k, j] = ".";
                    }
                }
            }
            return ret;
        }

        // i != 0 
        static string[,] CreateCenterColorWhite(int i, string[,] carpet)
        {
            int sideOfGrid = (int)Math.Pow(3, i);
            int eachRange = sideOfGrid / 3;

            int minX = eachRange;
            int maxX = eachRange * 2 - 1;
            int minY = minX;
            int maxY = maxX;

            for (int k = 0; k < sideOfGrid; k++)
            {
                for (int j = 0; j < sideOfGrid; j++)
                {
                    if (
                        minX <= k && k <= maxX
                     && minY <= k && k <= maxY
                    )
                    {
                        carpet[k, j] = ".";
                    }
                }
            }

            return carpet;
        }

        static string[,] ConcatenateCarpets(string[,] block, int repeat)
        {
            int blockSize = block.GetLength(0);
            int totalSize = blockSize * repeat;
            string[,] result = new string[totalSize, blockSize];

            for (int k = 0; k < totalSize; k++)
            {
                for (int j = 0; j < blockSize; j++)
                {
                    int blockIndex = k / blockSize;
                    int blockPos = k % blockSize;
                    result[k, j] = block[blockPos, j];
                }
            }

            return result;
        }

        static void PrintCarpet(string[,] carpet)
        {
            int rows = carpet.GetLength(0);
            int cols = carpet.GetLength(1);

            for (int k = 0; k < rows; k++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(carpet[k, j]);
                }
                Console.WriteLine();
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