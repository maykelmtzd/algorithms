using algorithms;
using Xunit;

namespace tests
{
    public class OneEditAwayTests
    {
        [Fact]
        public void ShouldReturnFalseIfLengthDifferenceIsGreaterThanOne()
        {
            string s1 = "pale";
            string s2 = "paleee";

            Assert.False(OneEditAway.AreOneEditAway(s1, s2));
        }

        [Fact]
        public void ShouldReturnTrueWithSameLengthAndZeroEditsNeeded()
        {
            string s1 = "pale";
            string s2 = "pale";

            Assert.True(OneEditAway.AreOneEditAway(s1, s2));
        }

        [Fact]
        public void ShouldReturnTrueWithSameLengthAndOneEditNeeded()
        {
            string s1 = "pale";
            string s2 = "pcle";

            Assert.True(OneEditAway.AreOneEditAway(s1, s2));
        }

        public void ShouldReturnFalseWithSameLengthAndTwoEditsNeeded()
        {
            string s1 = "palz";
            string s2 = "pcle";

            Assert.False(OneEditAway.AreOneEditAway(s1, s2));
        }

        [Fact]
        public void ShouldReturnTrueWithDifferentLengthsAndOneEditNeeded()
        {
            string s1 = "pale";
            string s2 = "pcale";

            Assert.True(OneEditAway.AreOneEditAway(s1, s2));
        }

        public void ShouldReturnFalseWithDifferentLengthsAndTwoEditsNeeded()
        {
            string s1 = "palez";
            string s2 = "plex";

            Assert.False(OneEditAway.AreOneEditAway(s1, s2));
        }
    }
}