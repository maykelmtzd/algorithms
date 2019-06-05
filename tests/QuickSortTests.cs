
using Xunit;

namespace tests
{
    public class QuickSortTests
    {
        [Fact]
        public void ShouldReturnSameArrayWhenArrayHasOneElement()
        {
            int[] oneElementArray = new int[]{ 5 };
            QuickSort.Order(oneElementArray);
            Assert.Equal(new int[]{ 5 }, oneElementArray);
        }

        [Fact]
        public void ShouldOrderArrayOfTwoElements()
        {
            int[] twoElementsArray = new int[]{ 5, 4 };
            QuickSort.Order(twoElementsArray);
            Assert.Equal(new int[]{ 4, 5 }, twoElementsArray);
        }

        [Fact]
        public void ShouldOrderArrayOfSeveralElements()
        {
            int[] severalElementsArray = new int[]{ 5, 4, 3, 8, 80, 48, 100 };
            QuickSort.Order(severalElementsArray);
            Assert.Equal(new int[]{ 3, 4, 5, 8, 48, 80, 100 }, severalElementsArray);
        }
    }
}