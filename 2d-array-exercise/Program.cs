using System;
using System.Collections.Generic;

namespace _2d_array_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nStarted...");

            int[, ] array = new int[, ] {
                { 1, 1, 1, 0, 0, 0}, 
                { 0, 1, 0, 0, 0, 0}, 
                { 1, 1, 1, 0, 0, 0}, 
                { 0, 0, 0, 0, 0, 0}, 
                { 0, 0, 0, 0, 0, 0}, 
                { 0, 0, 0, 0, 0, 0}};
            int maxHourglassSum = hourglassSum(array);
            Console.WriteLine($"Test Case 1 : maxHourglassSum = {maxHourglassSum}");

            array = new int[, ] {
                { -9, -9, -9, 1, 1, 1 }, 
                { 0, -9, 0, 4, 3, 2 }, 
                { -9, -9, -9, 1, 2, 3 }, 
                { 0, 0, 8, 6, 6, 0 }, 
                { 0, 0, 0, -2, 0, 0 }, 
                { 0, 0, 1, 2, 4, 0 }};
            maxHourglassSum = hourglassSum(array);
            Console.WriteLine($"Test Case 2 : maxHourglassSum = {maxHourglassSum}");

            array = new int[,] {
                { 1, 1, 1, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 1, 1, 1, 0, 0, 0 },
                { 0, 0, 2, 4, 4, 0 },
                { 0, 0, 0, 2, 0, 0 },
                { 0, 0, 1, 2, 4, 0 }};
            maxHourglassSum = hourglassSum(array);
            Console.WriteLine($"Test Case 3 : maxHourglassSum = {maxHourglassSum}");

            Console.WriteLine("\nDone!");
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadLine();
        }

        private static int hourglassSum(int[, ] array)
        {
            int maxSum = 0;
            for (int row = 0; row <= 3; row++)
            {
                for (int col = 0; col <= 3; col++)
                {
                    int sum = 0;

                    sum += array[row, col];
                    sum += array[row, col + 1];
                    sum += array[row, col + 2];
                    sum += array[row + 1, col + 1];
                    sum += array[row + 2, col];
                    sum += array[row + 2, col + 1];
                    sum += array[row + 2, col + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}
