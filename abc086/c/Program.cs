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
            int n = int.Parse(Console.ReadLine());

            int[][] inputLongArray = new int[n][];

            int[] definedT = new int[n];
            int[] definedX = new int[n];
            int[] definedY = new int[n];

            for (int i = 0; i < n; i++)
            {
                // 整数配列の入力 
                inputLongArray[i] = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();
                definedT[i] = inputLongArray[i][0];
                definedX[i] = inputLongArray[i][1];
                definedY[i] = inputLongArray[i][2];
            }

            int[] currentPos = { 0, 0 };
            int time = 0;

            // if the time elappsed each second, player move a step that is like : x,y -> x+1,y || x,y -> x,y+1|| x,y -> x-1,y|| x,y -> x,y-1;
            // the time can change up to 

            // by each time, move charactor to reach the defined position;
            for (int i = 0; i < n; i++)
            {
                if (CanArriveWithinCount(definedX[i], definedY[i], definedT[i], currentPos[0], currentPos[1], time))
                {
                    currentPos[0] = definedX[i];
                    currentPos[1] = definedY[i];
                    time = definedT[i];
                }
                else
                {
                    break;
                }
            }

            if (currentPos[0] == definedX[n - 1] && currentPos[1] == definedY[n - 1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.Out.Flush();


            // checking Function:is it possible to reach the point which is grant as argmuents: -> counting difference X and Y
            // if you arrived the point however you can move more, at that time if the rest of turn is  even Numbet that is gonna be true;
            bool CanArriveWithinCount(int targetX, int targetY, int targetT, int currentPosX, int currentPosY, int currentT)
            {
                int neededCountToReach = (int)MathF.Abs(currentPosX - targetX) + (int)MathF.Abs(targetY - currentPosY);
                if (neededCountToReach == targetT - currentT) return true;
                if (neededCountToReach < targetT - currentT)
                {
                    if ((neededCountToReach - targetT + currentT) % 2 == 0) { return true; }
                    else return false;
                }
                else return false;
            }
        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}