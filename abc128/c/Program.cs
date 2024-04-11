using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
            // System.Console.SetIn(exStdIn);

            int S, L;
            (int, int) num = Utils.IntArray2In();
            S = num.Item1;
            L = num.Item2;
            int[][] jag = Utils.IntJaggedArrayIn(L);
            int[] switches = Utils.IntArray1In();
            int[] bit = new int[10];
            int cnt = 0;
            for (int i = 0; i < 1 << S; i++)
            {
                if (OnlightCheck(jag, i))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);

            // スイッチの要素とonのスイッチの番号を受取り、それぞれのライトの条件を満たしていたらTrueをかえす。
            bool OnlightCheck(int[][] jag, int onLightNum)
            {
                for (int j = 0; j < 10; j++)
                {
                    int div = 1 << j;
                    bit[j] = (onLightNum / div) % 2;
                }

                for (int l = 0; l < L; l++)
                {
                    int onCnt = 0;
                    for (int item = 1; item < jag[l].Length; item++)
                    {
                        if (bit[jag[l][item] - 1] == 1)
                        {
                            onCnt++;
                        }
                    }
                    if (onCnt % 2 != switches[l])
                    {
                        return false;
                    }
                }
                return true;
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
    }
}