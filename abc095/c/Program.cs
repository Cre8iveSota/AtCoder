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

            // 単数整数配列の入力
            var doubleNumArray = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();   // For given only one line array
            double A = doubleNumArray[0];
            double B = doubleNumArray[1];
            double C = doubleNumArray[2];
            double X = doubleNumArray[3];
            double Y = doubleNumArray[4];

            double minPrice = double.PositiveInfinity;
            double tempSum;

            for (double i = 0; i <= 100000; i++)
            {
                tempSum = i * C * 2;
                if (X - i > 0)
                {
                    tempSum += (X - i) * A;
                }
                if (Y - i > 0)
                {
                    tempSum += (Y - i) * B;
                }
                minPrice = Math.Min(minPrice, tempSum);
            }
            Console.WriteLine(minPrice);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}