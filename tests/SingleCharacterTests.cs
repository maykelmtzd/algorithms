
using algorithms;
using Xunit;

namespace tests
{
    public class SingleCharacterTests
    {
        [Fact]
        public void ShouldReturnTrueIfAllCharactersAreUnique()
        {
            var input = "abcd";
            Assert.True(SingleCharacter.AllCharactersAreUnique(input));
        }

        [Fact]
        public void ShouldReturnFalseIfAllCharactersAreNotUnique()
        {
            var input = "abcdc";
            Assert.False(SingleCharacter.AllCharactersAreUnique(input));
        }
    }
}