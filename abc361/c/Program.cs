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
                var exStdIn = new System.IO.StreamReader("./test/sample-2.in");
                System.Console.SetIn(exStdIn);
            }
            #endregion
            int[] NK = Utils.IntArray1In();
            int N = NK[0];
            int K = NK[1];
            int[] A = Utils.IntArray1In();

            double mean = A.Average();
            double hensa = Stdev(A);


            //order, value-divation
            int cnt = 0;
            Dictionary<(int, int), double> valueDev = new Dictionary<(int, int), double>();
            foreach (int i in A)
            {
                valueDev.Add((i, cnt), Math.Abs((i - mean) * 10 / hensa + 50));
                cnt++;
            }
            Dictionary<int, int> arrangedDic = valueDev.OrderBy(i => Math.Abs(i.Value - 50)).ToDictionary(e => e.Key.Item2, e => e.Key.Item1);
            List<int> valuesList = new List<int>(arrangedDic.Values);

            int[] newArray = new int[N - K];
            Array.Copy(valuesList.ToArray(), newArray, N - K);
            Array.Sort(newArray);
            Console.WriteLine(Math.Abs(newArray[N - K - 1] - newArray[0]));

            static double Stdev(int[] src)
            {
                if (!src.Any()) throw new InvalidOperationException("Cannot compute median for an empty set.");
                //Doubleにキャストして処理を進める
                var doubleList = src.Select(a => Convert.ToDouble(a)).ToArray();

                //平均値算出
                double mean = doubleList.Average();
                //自乗和算出
                double sum2 = doubleList.Select(a => a * a).Sum();
                //分散 = 自乗和 / 要素数 - 平均値^2
                double variance = sum2 / doubleList.Count() - mean * mean;
                //標準偏差 = 分散の平方根
                return Math.Sqrt(variance);
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