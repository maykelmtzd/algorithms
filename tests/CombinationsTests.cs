using System;
using System.Collections.Generic;
using Xunit;

namespace tests
{
    public class CombinationsTests
    {
        [Fact]
        public void ShouldInsertCharacterInAllPossiblePositions()
        {
            List<string> result = Combinations.InsertCharacter('a', "bc");
            Assert.Equal(new List<string>{ "abc", "bac", "bca" }, result);
        }
    }
}
