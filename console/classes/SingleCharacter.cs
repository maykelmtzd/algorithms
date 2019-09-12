using System;

namespace algorithms
{

    public class SingleCharacter
    {
        public static bool AllCharactersAreUnique(string input)
        {
            if (input == "" || input.Length == 1)
                return true;

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                        return false;
                }
            }

            return true;
        }
    }
}