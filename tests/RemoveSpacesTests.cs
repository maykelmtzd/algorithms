using algorithms;
using Xunit;

namespace tests
{
    public class RemoveSpacesTests
    {
        [Fact]
        public void ShouldRemoveAllSpacesInStringWithoutConsecutiveSpaces()
        {
            string s = "Mr John Smith is a teacher          ";
            char[] stringWithSpaces = s.ToCharArray(0, s.Length);
            char[] stringWithoutSpaces = SpaceRemover.RemoveSpaces(stringWithSpaces);

            Assert.Equal("Mr%20John%20Smith%20is%20a%20teacher", new string(stringWithoutSpaces));
        }

        [Fact]
        public void ShouldRemoveAllSpacesInStringWithoutConsecutiveSpacesAndStartingWithSpace()
        {
            string s = " Mr John Smith      ";
            char[] stringWithSpaces = s.ToCharArray(0, s.Length);
            char[] stringWithoutSpaces = SpaceRemover.RemoveSpaces(stringWithSpaces);

            Assert.Equal("%20Mr%20John%20Smith", new string(stringWithoutSpaces));
        }
    }
}