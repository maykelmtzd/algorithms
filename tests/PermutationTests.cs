using algorithms;
using Xunit;

namespace tests
{
    public class PermutationTests
    {
        [Fact]
        public void shouldReturnFalseIfStringsAreNotTheSameLength()
        {
            var s1 = "abc";
            var s2 = "abcd";
            Assert.False(Permutations.IsPermutation(s1, s2));
        }

        [Fact]
        public void shouldReturnFalseIfStringsHaveSameLengthButAreNotPermutations()
        {
            var s1 = "abcc";
            var s2 = "abcd";
            Assert.False(Permutations.IsPermutation(s1, s2));
        }

        [Fact]
        public void shouldReturnTrueIfStringsArePermutations()
        {
            var s1 = "dacb";
            var s2 = "abcd";
            Assert.True(Permutations.IsPermutation(s1, s2));
        }
    }
}