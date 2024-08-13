using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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

            (int x, int y)[] xy = Utils.IntXyIn(3);
            double a = Vector2.Distance(new Vector2(xy[0].x, xy[0].y), new Vector2(xy[1].x, xy[1].y));
            double b = Vector2.Distance(new Vector2(xy[1].x, xy[1].y), new Vector2(xy[2].x, xy[2].y));
            double c = Vector2.Distance(new Vector2(xy[2].x, xy[2].y), new Vector2(xy[0].x, xy[0].y));
            double d = Math.Pow(a, 2) + Math.Pow(b, 2);
            double dd = Math.Pow(c, 2);
            double e = Math.Pow(b, 2) + Math.Pow(c, 2);
            double ee = Math.Pow(a, 2);
            double f = Math.Pow(c, 2) + Math.Pow(a, 2);
            double ff = Math.Pow(b, 2);
            float threshould = 1f;
            bool ok = false;

            if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) - threshould && Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) + threshould)
            {
                ok = true;
            }
            else if (Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2) - threshould && Math.Pow(b, 2) + Math.Pow(c, 2) < Math.Pow(a, 2) + threshould)
            {
                ok = true;
            }
            else if (Math.Pow(c, 2) + Math.Pow(a, 2) > Math.Pow(b, 2) - threshould && Math.Pow(c, 2) + Math.Pow(a, 2) < Math.Pow(b, 2) + threshould)
            {
                ok = true;
            }

            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
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
        public static (int x, int y)[] IntXyIn(int maxNum)
        {
            (int x, int y)[] xy = new (int, int)[maxNum];
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                xy[i].x = int.Parse(line[0]);
                xy[i].y = int.Parse(line[1]);
            }
            return xy;
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