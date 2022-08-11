using System;
using System.Collections.Generic;
using System.Linq;

namespace plus_minus_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started ...");
            plusMinus(new int[] { 1, 1, 0, -1, -1 });
            plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }

        private static void plusMinus(int[] numbers)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (numbers != null && numbers.Length != 0)
            {
                var countOfNumbers = numbers.Length;
                var negativeNumbers = numbers.Where(number => number < 0);
                var zeroNumbers = numbers.Where(number => number == 0);
                var positiveNumbers = numbers.Where(number => number > 0);

                Console.WriteLine($"{string.Join(',', numbers)}");
                Console.WriteLine($"There are {positiveNumbers.Count()} positive number(s), {negativeNumbers.Count()} negative number(s) and {zeroNumbers.Count()} zero number(s) in the array.");

                Console.WriteLine($"{plusMinusDivision(countOfNumbers, positiveNumbers)}");
                Console.WriteLine($"{plusMinusDivision(countOfNumbers, negativeNumbers)}");
                Console.WriteLine($"{plusMinusDivision(countOfNumbers, zeroNumbers)}\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Array of digits not provided!\n");
            }
        }

        private static string plusMinusDivision(int countOfNumbers, IEnumerable<int> posNegZeroNumbers)
        {
            return string.Format("{0:N6}", (decimal)posNegZeroNumbers.Count() / countOfNumbers);
        }
    }
}
