using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列配列の入力
            string inputStrArray = Console.ReadLine();



            for (int i = 1; i < inputStrArray.Length - 1; i++)
            {
                // Console.WriteLine(inputStrArray.IndexOf(inputStrArray.Substring(i, 1)));
                if (inputStrArray.Substring(i, 1) == inputStrArray.Substring(i - 1, 1) && inputStrArray.Substring(i, 1) == inputStrArray.Substring(i + 1, 1))
                {

                }
                else if (inputStrArray.Substring(i, 1) != inputStrArray.Substring(i - 1, 1) && inputStrArray.Substring(i, 1) != inputStrArray.Substring(i + 1, 1))
                {
                    Console.WriteLine(i + 1);
                }
                else if (inputStrArray.Substring(i, 1) != inputStrArray.Substring(i - 1, 1) && inputStrArray.Substring(i, 1) == inputStrArray.Substring(i + 1, 1))
                {
                    Console.WriteLine(i - 1 + 1);
                    break;
                }
                else if (inputStrArray.Substring(i, 1) == inputStrArray.Substring(i - 1, 1) && inputStrArray.Substring(i, 1) != inputStrArray.Substring(i + 1, 1))
                {
                    Console.WriteLine(i + 1 + 1);
                    break;
                }
            }

        }
    }

    //よく使うコードなどあれば
    class Utils
    {

    }
}