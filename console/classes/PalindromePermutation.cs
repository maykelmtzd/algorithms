using System;
using System.Collections.Generic;

namespace algorithms
{
    public class PalindromePermutation
    {
        public static bool IsPalindromePermutation(string permutation)
        {
            Dictionary<char, int> counters = new Dictionary<char, int>();
            permutation = permutation.Replace(" ", string.Empty);
            foreach (char c in permutation)
            {
                if (counters.ContainsKey(c))
                    counters[c]++;
                else
                    counters.Add(c, 1);
            }

            if (IsEven(permutation.Length) && CountOdds(counters) == 0)
                return true;

            if (!IsEven(permutation.Length) && CountOdds(counters) == 1)
                return true;

            return false;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        private static int CountOdds(Dictionary<char, int> counters)
        {
            int oddsCounter = 0;
            foreach (int counter in counters.Values)
            {
                if (counter % 2 != 0)
                    oddsCounter++;
            }
            return oddsCounter;
        }
    }
}