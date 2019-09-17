
using System;
using algorithms;
using Xunit;

namespace tests
{
    public class PalindromePermutationTests
    {
        [Fact]
        public void shouldReturnTrueWhenLengthRemovingSpacesIsOddAndOnlyOneCharacterCountIsOdd()
        {
            string permutation = "a  bc dcb  a";
            Assert.True(PalindromePermutation.IsPalindromePermutation(permutation));
        }

        [Fact]
        public void shouldReturnTrueWhenLengthRemovingSpacesIsEvenAndNoCharacterCountIsOdd()
        {
            string permutation = "a  b ccba";
            Assert.True(PalindromePermutation.IsPalindromePermutation(permutation));
        }

        [Fact]
        public void shouldReturnFalseWhenLengthRemovingSpacesIsEvenAndThereAreOddCharacterCounts()
        {
            string permutation = "a  b ccbacb";
            Assert.False(PalindromePermutation.IsPalindromePermutation(permutation));
        }

        [Fact]
        public void shouldReturnFalseWhenLengthRemovingSpacesIsOddAndThereIsNotOneOddCharacterCounts()
        {
            string permutation = "a  b ccbacb";
            Assert.False(PalindromePermutation.IsPalindromePermutation(permutation));
        }
    }
}