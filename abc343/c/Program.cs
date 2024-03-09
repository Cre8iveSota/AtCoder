using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static Dictionary<int, int> cubicalPalindromeBank = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            for (long j = n; j > 0; j--)
            {
                // nの立方根までのを作成する
                double maNum = Math.Floor(Math.Pow(j, (1 / 3f)));

                double appropriateNum = Math.Pow(maNum, 3);

                if (CheckPalindrome(appropriateNum))
                {
                    cubicalPalindromeBank.Add(maNum, appropriateNum);
                    Console.WriteLine(appropriateNum);
                    return;
                }
            }

        }

        // static bool CheckPalindrome(double num)
        // {
        //     string target = num.ToString;
        //     while (target != "")
        //     {
        //         if (target.Substring(0, 1) == target.Substring(target.Length - 1))
        //         {
        //             target = target.Substring(1, Length - 1);
        //         }
        //     }
        //     if (target == "") return true;
        //     else return false;
        // }

        static bool CheckPalindrome(double num)
        {
            string target = num.ToString();
            while (target.Length > 1)
            {
                if (target[0] == target[target.Length - 1])
                {
                    target = target.Substring(1, target.Length - 2);
                }
                else
                {
                    return false; // チェック中に一致しない文字が見つかった場合は回文ではありません
                }
            }
            return true; // チェックが完了した場合は回文です
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}