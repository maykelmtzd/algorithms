using System;
using System.Collections.Generic;

namespace algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abcd";

            List<string> allCombinations = Combinations.FindAllCombinations(input);
            allCombinations.ForEach(comb => Console.WriteLine(comb));
        }

        
    }
}
