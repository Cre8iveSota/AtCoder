using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace x
{
    class Program
    {
        static void Main(string[] args)
        {
            // var exStdIn = new System.IO.StreamReader("./test/sample-1.in");
            // System.Console.SetIn(exStdIn);

            long num = long.Parse(Console.ReadLine());

            if (num > 0) Console.WriteLine((num + 9) / 10);
            else Console.WriteLine(num / 10);
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}