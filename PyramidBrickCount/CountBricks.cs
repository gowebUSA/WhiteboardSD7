﻿using System;

namespace PyramidBrickCount
{
    class CountBrick
    {
        public static int CountOfBricks( int pyramidBase, int pyramidHeight, double brickSize)
        {
            int count = 0;

            int area = pyramidBase * pyramidHeight / 2;
            count = Convert.ToInt32(Convert.ToDouble(area) / brickSize);

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nPyramidBrickCount.CountBricks.Main()");

            Console.WriteLine($"\n\treturned count is: {CountOfBricks(100, 30, .17)} bricks!");
            Console.WriteLine($"\n\treturned count is: {CountOfBricks(1, 1, 1.0)} bricks!");
        }
    }
}
 