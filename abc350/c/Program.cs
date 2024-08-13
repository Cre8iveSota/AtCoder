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
            int N = int.Parse(Utils.StringIn());
            int[] target = Utils.IntArray1In();

            // index, myself == target, correct or not
            List<(int, int, bool)> data = new List<(int, int, bool)>();
            List<(int, int)> operation = new List<(int, int)>();

            for (int i = 0; i < target.Length; i++)
            {
                bool a = i + 1 == target[i] ? true : false;
                if (!a)
                {
                    data.Add((i + 1, target[i], a));

                    int targetChange1 = target[i];//3
                    int targetChange2 = target[targetChange1 - 1]; // dokuyatu //1
                    operation.Add((targetChange2, targetChange1)); // i into 2 // 逆?// 1,3
                    int tmp = target[targetChange2 - 1]; // 2 into tmp  //3
                    target[targetChange2 - 1] = target[targetChange1 - 1]; // 1 into 2// 1
                    target[targetChange1 - 1] = tmp;//3
                }
            }
            Console.WriteLine(operation.Count);
            foreach (var array in operation)
            {
                Console.WriteLine($"{array.Item1} {array.Item2}");
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