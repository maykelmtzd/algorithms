using System;
using System.Collections.Generic;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] input = new int[] {2, 5, 3, 7, 10, 2, 80, 6};
            // QuickSort.Order(input);
        }
        static void Main1(string[] args)
        {
            string input = "abcd";

            List<string> allCombinations = Combinations.FindAllCombinations(input);
            allCombinations.ForEach(comb => Console.WriteLine(comb));
        }


    }
}
