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
            int[] inputStrArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            string[,] array = new string[inputStrArray[0], inputStrArray[1]];
            int[] currentPos = { 0, 0 };

            int currentRotationState = 0;

            int[] direction = { 0, 1 };

            for (int i = 0; i < inputStrArray[0]; i++)
            {
                for (int j = 0; j < inputStrArray[1]; j++)
                {
                    array[i, j] = ".";
                }
            }

            for (int i = 0; i < inputStrArray[2]; i++)
            {
                if (array[currentPos[0], currentPos[1]] == ".") { ClockWiseTurn(); }
                else { AntiClockWiseTurn(); }
                array[currentPos[0], currentPos[1]] = array[currentPos[0], currentPos[1]] == "." ? "#" : ".";
                Move();
            }

            OutputResult();

            void ClockWiseTurn()
            {
                currentRotationState++;
                direction[0] = (int)Math.Sin(Math.PI * currentRotationState / 2); // 0 -> 1 ->
                direction[1] = (int)Math.Cos(Math.PI * currentRotationState / 2);
            }

            void AntiClockWiseTurn()
            {
                currentRotationState--;
                direction[0] = (int)Math.Sin(Math.PI * currentRotationState / 2);
                direction[1] = (int)Math.Cos(Math.PI * currentRotationState / 2);
            }

            void RevisePosiForToras()
            {
                currentPos[0] = (currentPos[0] + inputStrArray[0]) % inputStrArray[0];
                currentPos[1] = (currentPos[1] + inputStrArray[1]) % inputStrArray[1];
            }

            void Move()
            {
                // 行がマイナスだとRevisePosiForToras()がうまく作用しないので調整
                if (direction[1] < 0 || direction[1] > 0)
                {
                    direction[1] = direction[1] * -1;
                }

                // 向いている方向に1ます進む
                currentPos[0] += direction[1]; // 行 x
                currentPos[1] += direction[0]; // 列 y

                //トーラス上に修正
                RevisePosiForToras();
            }

            void OutputResult()
            {
                for (int i = 0; i < inputStrArray[0]; i++)
                {
                    for (int j = 0; j < inputStrArray[1]; j++)
                    {
                        Console.Write(array[i, j]);
                    }
                    Console.WriteLine();
                }
            }

        }
    }

    //よく使うコードなどあれば    
    class Utils
    {

    }
}