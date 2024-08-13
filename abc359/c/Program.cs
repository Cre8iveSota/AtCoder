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
            if (!false)
            {
                var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
                System.Console.SetIn(exStdIn);
            }
            #endregion
            long[] SxSy = Utils.LongArray1In();
            long[] TxTy = Utils.LongArray1In();
            long Sx = SxSy[0] + 1;
            long Sy = SxSy[1] + 1;
            long Tx = TxTy[0] + 1;
            long Ty = TxTy[1] + 1;
            long toll = 0;
            bool ok = false;

            if ((Tx + 1) / 2 == (Sx + 1) / 2 && Ty == Sy && Ty % 2 == 1)
            {
                toll += 0;
                ok = true;
            }
            else if (Tx / 2 == Sx / 2 && Ty == Sy && Ty % 2 == 0)
            {
                toll += 0;
                ok = true;
            }

            if (Math.Abs(Tx - Sx) <= Math.Abs(Ty - Sy) && !ok)
            {
                toll += Math.Abs(Ty - Sy) + Math.Abs(Tx - Sx) - Math.Abs(Tx - Sx);
            }
            if (Math.Abs(Tx - Sx) > Math.Abs(Ty - Sy) && !ok)
            {
                toll += Math.Abs(Tx - Sx);
            }


            Console.WriteLine(toll);

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
        public static long[] LongArray1In()
        {
            long[] line = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
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