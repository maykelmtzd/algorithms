namespace algorithms
{
    public class Permutations
    {
        public static bool IsPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            if (!AllCharactersContained(s1, s2) || !AllCharactersContained(s2, s1))
                return false;

            return true;
        }
        private static bool AllCharactersContained(string s1, string s2)
        {
            foreach (char c in s1)
                if (!s2.Contains(c))
                    return false;

            return true;
        }
    }
}