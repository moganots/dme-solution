using System;

namespace bigger_is_greater_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nStarted...");

            var result = biggerIsGreater("ab");
            Console.WriteLine($"input: ab, expected: ba, returned: {result}");
            result = biggerIsGreater("bb");
            Console.WriteLine($"input: bb, expected: no answer, returned: {result}");
            result = biggerIsGreater("hefg");
            Console.WriteLine($"input: hefg, expected: hegf, returned: {result}");
            result = biggerIsGreater("dhck");
            Console.WriteLine($"input: dhck, expected: dhkc, returned: {result}");
            result = biggerIsGreater("dkhc");
            Console.WriteLine($"input: dkhc, expected: hcdk, returned: {result}");
            result = biggerIsGreater("lmno");
            Console.WriteLine($"input: lmno, expected: lmon, returned: {result}");
            result = biggerIsGreater("dcba");
            Console.WriteLine($"input: dcba, expected: no answer, returned: {result}");
            result = biggerIsGreater("dcbb");
            Console.WriteLine($"input: dcbb, expected: no answer, returned: {result}");
            result = biggerIsGreater("abdc");
            Console.WriteLine($"input: abdc, expected: acbd, returned: {result}");
            result = biggerIsGreater("abcd");
            Console.WriteLine($"input: abcd, expected: abdc, returned: {result}");
            result = biggerIsGreater("fedcbabcd");
            Console.WriteLine($"input: fedcbabcd, expected: fedcbabdc, returned: {result}");

            Console.WriteLine("\nDone!");
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadLine();
        }

        private static string biggerIsGreater(string word)
        {
            // 1. Get each letter in the word into an array
            char[] letters = word?.ToCharArray();

            // 2. Find the longest non-increasing suffix
            int i = letters.Length - 1;
            while(i > 0 && letters[i - 1] >= letters[i])
            {
                i--;
            }
            if (i <= 0)
            {
                return "no answer";
            }

            // 3. Pivot rightmost successor in the suffix
            int j = letters.Length - 1;
            while (letters[j] <= letters[i - 1])
            {
                j--;
            }

            // 4. Swap (3) with the rightmost character
            char temp = letters[i - 1];
            letters[i - 1] = letters[j];
            letters[j] = temp;

            // 5. Reverse the suffix
            j = letters.Length - 1;
            while(i < j)
            {
                temp = letters[i];
                letters[i] = letters[j];
                letters[j] = temp;
                i++;
                j--;
            }
            return string.Join("", letters);
        }
    }
}
