using System;
using System.Collections.Generic;

namespace NearestLocker
{
    internal class Program
    {
        private static void Main()
        {
            //var result = createGrid(3, 5, new int[] {1}, new int[] {1});
            //var result = createGrid(5, 7, new int[] {2}, new int[] {3});
            var result = CreateGrid(5, 7, new[] { 2, 4 }, new[] { 3, 7 });

            var rowLength = result.GetLength(0);
            var colLength = result.GetLength(1);

            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.Write(result[i, j]);
                }

                Console.WriteLine("");
            }
        }

        private static int[,] CreateGrid(int length, int width, int[] xCoord, int[] yCoord)
        {
            var grid = new int[width, length];
            var xCount = xCoord.GetLength(0);
            var xInitial = xCoord[0];
            var yInitial = yCoord[0];

            for (var i = 1; i <= width; i++)
            {
                for (var j = 1; j <= length; j++)
                {
                    var distance = Math.Abs(j - xInitial) + Math.Abs(i - yInitial);
                    for (var k = 1; k <= xCount; k++)
                    {
                        var nextDistance = Math.Abs(j - xCoord[k - 1]) + Math.Abs(i - yCoord[k - 1]);
                        distance = Math.Min(distance, nextDistance);
                    }
                    grid[i - 1, j - 1] = distance;
                }
            }

            return grid;
        }

        private static int[] CreateGridWithObject(int length, int width, int[] xCoord, int[] yCoord)
        {
            var grid = new int[width * length];
            var xInitial = xCoord[0];
            var yInitial = yCoord[0];

            for (var i = 1; i <= width * length; i++)
            {

            }

            return grid;
        }
    }
}

