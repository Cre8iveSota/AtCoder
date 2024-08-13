using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.SafeHandles;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            long ans = 0;
            long[] cnt = new long[26];
            bool same = false;
            string s = Console.ReadLine();
            long n = s.Length;

            // Count occurrences of each character
            foreach (char c in s)
            {
                cnt[c - 'a']++;
            }

            ans = n * n;

            // Subtract the square of each character count from the total
            for (int i = 0; i < 26; i++)
            {
                ans -= cnt[i] * cnt[i];
                if (cnt[i] > 1)
                {
                    same = true;
                }
            }

            ans /= 2;

            if (same)
            {
                ans++;
            }

            Console.WriteLine(ans);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}