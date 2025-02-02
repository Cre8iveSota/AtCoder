using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
        int[] NQ = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int N = NQ[0];
    int Q = NQ[1];
    int[] tori = new int[N];
        for (int i = 0; i<N; i++)
        {
            tori[i] = i;
        }

for (int i = 0; i < Q; i++)
{
    var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (line[0] == 1)
    {
        tori[line[1] - 1] = line[2] - 1;
    }
    else
    {
        Console.WriteLine(CntMoreThanOne(tori));
    }
}

int CntMoreThanOne(int[] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (dict.ContainsKey(array[i]))
        {
            dict[array[i]]++;
        }
        else
        {
            dict[array[i]] = 1;
        }
    }
    return dict.Count(x => x.Value > 1);
}
    }
}
