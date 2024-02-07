using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // 文字列の入力
            string s = Console.ReadLine();
            string t = "";

            while (s != "")
            {
                // 末尾からそれぞれの単語に一致するか確認
                if (s.EndsWith("dream"))
                {
                    t = "dream" + t;
                    s = s.Substring(0, s.Length - 5);
                }
                else if (s.EndsWith("dreamer"))
                {
                    t = "dreamer" + t;
                    s = s.Substring(0, s.Length - 7);
                }
                else if (s.EndsWith("erase"))
                {
                    t = "erase" + t;
                    s = s.Substring(0, s.Length - 5);
                }
                else if (s.EndsWith("eraser"))
                {
                    t = "eraser" + t;
                    s = s.Substring(0, s.Length - 6);
                }
                else
                {
                    // いずれにも一致しない場合、NOを出力して終了
                    Console.WriteLine("NO");
                    return;
                }
            }

            // 文字列Sが空になった場合、YESを出力
            Console.WriteLine("YES");
        }
    }
}