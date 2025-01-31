using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace x
{
    class Program
    {
        static Dictionary<(int, int), string> posValue = new Dictionary<(int, int), string>();
        static void Main(string[] args)
        {
            #region debug
            if (false)
            {
                var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
                System.Console.SetIn(exStdIn);
            }
            #endregion

            int[] HW = Utils.IntArray1In();
            int[] SiSj = Utils.IntArray1In();
            int H = HW[0];
            int W = HW[1];
            int Si = SiSj[0];
            int Sj = SiSj[1];

            Vector2 currentPos = new Vector2(Si, Sj);
            for (int h = 0; h < H; h++)
            {
                string hString = Console.ReadLine();
                for (int w = 0; w < W; w++)
                {
                    posValue.Add((h + 1, w + 1), hString[w].ToString());
                }
            }
            string command = Console.ReadLine();
            Vector2 result = Move(currentPos, command, H, W);
            Console.WriteLine($"{(int)result.X} {(int)result.Y}");
        }

        static Vector2 Move(Vector2 curPos, string command, int maxX, int maxY)
        {
            Vector2 expectedPos = new Vector2();
            Vector2 afterPos = curPos;
            foreach (char s in command)
            {
                switch (s.ToString())
                {
                    case "U":
                        expectedPos = new Vector2(afterPos.X - 1, afterPos.Y);
                        break;
                    case "L":
                        expectedPos = new Vector2(afterPos.X, afterPos.Y - 1);
                        break;
                    case "D":
                        expectedPos = new Vector2(afterPos.X + 1, afterPos.Y);
                        break;
                    case "R":
                        expectedPos = new Vector2(afterPos.X, afterPos.Y + 1);
                        break;
                }
                if (MovableChack(expectedPos, maxX, maxY))
                {
                    afterPos = expectedPos;
                }
            }
            return afterPos;
        }
        static bool MovableChack(Vector2 expectedPos, int maxX, int maxY)
        {
            if (expectedPos.X > 0 && expectedPos.Y > 0 && expectedPos.X <= maxX && expectedPos.Y <= maxY && posValue[((int)expectedPos.X, (int)expectedPos.Y)] != "#")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {
        // 文字列の入力
        public static string StringIn() { return Console.ReadLine(); }
        // 文字配列
        public static string[] StringArrayIn() { return Console.ReadLine().Split(""); }
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
        public static (int x, int y)[] IntXyzIn(int maxNum)
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