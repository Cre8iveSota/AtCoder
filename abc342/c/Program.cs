using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整数の入力
            int n0 = int.Parse(Console.ReadLine());

            // 文字列の入力
            string s = Console.ReadLine();

            // 整数の入力
            int n1 = int.Parse(Console.ReadLine());

            string[,] inputQuery = new string[n1, 2];

            string mappingFrom = "abcdefghijklmnopqrstuvwxyz";
            string mappingTo = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < n1; i++)
            {
                var tempQuery = Console.ReadLine().Split(' ').ToArray();
                inputQuery[i, 0] = tempQuery[0];
                inputQuery[i, 1] = tempQuery[1];

                mappingTo = mappingTo.Replace(inputQuery[i, 0], inputQuery[i, 1]);
            }

            Console.WriteLine(TranslateString(s, mappingFrom, mappingTo));
        }
        static string TranslateString(string original, string mappingFrom, string mappingTo)
        {
            string inputArray = original.Select(s =>
             {
                 if (mappingFrom.IndexOf(s) != -1)
                 {
                     s = mappingTo[mappingFrom.IndexOf(s)];
                 }
             });
            return inputArray;
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}