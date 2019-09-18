using System;
using System.Text;

namespace algorithms
{
    public class Compression
    {
        public static string Compress(string s)
        {
            StringBuilder compressed = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                int sameCharCounter = CountSameCharacter(s, i);
                compressed.Append(s[i]);
                compressed.Append(1 + sameCharCounter);
                i = i + sameCharCounter;
            }
            if (compressed.Length < s.Length)
                return compressed.ToString();

            return s;
        }

        private static int CountSameCharacter(string s, int i)
        {
            int initialIndex = i;
            while (i < s.Length - 1 && s[i] == s[i + 1])
            {
                i++;
            }
            return i - initialIndex;
        }
    }
}