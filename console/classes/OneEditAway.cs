using System;

namespace algorithms
{
    public class OneEditAway
    {
        public static bool AreOneEditAway(string s1, string s2)
        {
            if (Math.Abs(s1.Length - s2.Length) > 1)
                return false;

            if (s1.Length == s2.Length)
                return ZeroOrOneEditDiffWithSameLength(s1, s2);

            if (s1.Length > s2.Length)
                return ZeroOrOneEditDiffWithDifferentLength(s1, s2);

            return ZeroOrOneEditDiffWithDifferentLength(s2, s1);
        }

        private static bool ZeroOrOneEditDiffWithDifferentLength(string longString, string shortString)
        {
            int longStringCount = 0;
            int shortStringCount = 0;
            int diffCount = 0;
            while (longStringCount < longString.Length && diffCount <= 1)
            {
                if (longString[longStringCount] != shortString[shortStringCount])
                {
                    diffCount++;
                }
                else
                {
                    shortStringCount++;
                }
                longStringCount++;
            }

            return diffCount <= 1;
        }

        private static bool ZeroOrOneEditDiffWithSameLength(string s1, string s2)
        {
            int count = 0;
            int diffCount = 0;
            while (count < s1.Length && diffCount <= 1)
            {
                if (s1[count] != s2[count])
                    diffCount++;

                count++;
            }

            return diffCount <= 1;
        }
    }
}