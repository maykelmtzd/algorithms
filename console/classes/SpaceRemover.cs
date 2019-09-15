using System;

namespace algorithms
{
    public class SpaceRemover
    {
        public static char[] RemoveSpaces(char[] stringWithSpaces)
        {
            int lastCharacterIndex = SearchLastCharacterIndex(stringWithSpaces);
            int spacesToMove = 2 * CountSpaces(stringWithSpaces, lastCharacterIndex);

            for (int i = lastCharacterIndex; (i > 0 && spacesToMove > 0); i--)
            {
                while (stringWithSpaces[i] != ' ')
                {
                    stringWithSpaces[i + spacesToMove] = stringWithSpaces[i];
                    i--;
                }

                stringWithSpaces[i + spacesToMove] = '0';
                stringWithSpaces[i + spacesToMove - 1] = '2';
                stringWithSpaces[i + spacesToMove - 2] = '%';
                spacesToMove -= 2;
            }
            return stringWithSpaces;
        }

        private static int SearchLastCharacterIndex(char[] stringWithSpaces)
        {
            int lastCharacterIndex = stringWithSpaces.Length - 1;
            while (stringWithSpaces[lastCharacterIndex] == ' ')
                lastCharacterIndex--;

            return lastCharacterIndex;
        }

        private static int CountSpaces(char[] stringWithSpaces, int lastCharacterIndex)
        {
            int spacesCount = 0;
            for (int i = lastCharacterIndex; i >= 0; i--)
            {
                if (stringWithSpaces[i] == ' ')
                    spacesCount++;
            }

            return spacesCount;
        }
    }
}