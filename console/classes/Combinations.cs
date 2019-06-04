using System;
using System.Collections.Generic;
using System.Linq;
public static class Combinations
{
        public static List<string> FindAllCombinations(string input)
        {
            return RecCombinations(input, new List<string>());
        }

        private static List<string> RecCombinations(string input, List<string> list)
        {
            if(input == null)
                throw new ArgumentException("Null is not a valid input");
            
            if(input == "")
                return list;

            char firstCharacter = input[0];
            return InsertCharacter(firstCharacter, RecCombinations(input.Substring(1), list));
        }

        private static List<string> InsertCharacter(char firstCharacter, List<string> list)
        {
            if(list.Count == 0)
                return new List<string> { firstCharacter.ToString() };

            List<string> result = list.Select(combination => InsertCharacter(firstCharacter, combination))
                                        .SelectMany(l => l).ToList();
            return result;
        }

        public static List<string> InsertCharacter(char firstCharacter, string combination)
        {
            return Enumerable.Range(0, combination.Length + 1)
                                .Select(i => combination.Insert(i, firstCharacter.ToString()))
                                .ToList();
        }
}