using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = GetStdin();
            for (int max = s.Length - 1; max >= 0; max--)
            {
                Console.WriteLine(s[max]);
            }
        }
        static private int[] GetStdin()
        {
            var list = new List<int>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                list.Add(int.Parse(line));
            }
            return list.ToArray();
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}