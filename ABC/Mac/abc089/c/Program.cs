using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] S = new string[N];
        Dictionary<char, long> m = new Dictionary<char, long>(); // keyを文字に、値を出現回数を保存する
        string march = "MARCH";

        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
            char firstChar = S[i][0];
            if (!m.ContainsKey(firstChar))
                m[firstChar] = 0;
            m[firstChar]++;
        }

        long ans = 0;
        for (int a = 0; a < 5; a++)
        {
            for (int b = a + 1; b < 5; b++)
            {
                for (int c = b + 1; c < 5; c++)
                {
                    ans += m.GetValueOrDefault(march[a], 0) * m.GetValueOrDefault(march[b], 0) * m.GetValueOrDefault(march[c], 0);
                }
            }
        }
        Console.WriteLine(ans);
    }
}
