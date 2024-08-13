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

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 複数整数配列の入力を各indexに基づき、index毎にそれぞれの変数に保存
            int maxNum = n;
            (int x, int y, int h) ans = (0, 0, 0);
            (int x, int y, int h)[] xyh = new (int, int, int)[n];
            for (int i = 0; i < maxNum; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                xyh[i].x = int.Parse(line[0]);
                xyh[i].y = int.Parse(line[1]);
                xyh[i].h = int.Parse(line[2]);
            }

            int h = 0;

            for (int cx = 0; cx <= 100; cx++)
            {
                for (int cy = 0; cy <= 100; cy++)
                {
                    int H = -1;
                    for (int i = 0; i < maxNum; i++)
                    {
                        if (xyh[i].h != 0 && H == -1)
                        {
                            H = xyh[i].h + Math.Abs(cx - xyh[i].x) + Math.Abs(cy - xyh[i].y);
                        }
                    }

                    bool ok = true;
                    for (int i = 0; i < maxNum; i++)
                    {
                        if (Math.Max(H - Math.Abs(xyh[i].x - cx) - Math.Abs(xyh[i].y - cy), 0) != xyh[i].h)
                        {
                            ok = false;
                            break;
                        }
                    }

                    if (ok)
                    {
                        Console.WriteLine($"{cx} {cy} {H}");
                        return;
                    }
                }
            }
        }
    }


    //よく使うコードなどあれば    
    class Utils
    {

    }
}