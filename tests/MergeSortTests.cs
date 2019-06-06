using algorithms;
using Xunit;

namespace tests
{
    public class MergeSortTests
    {
        [Fact]
        public void ShouldReturnOrderedArrayWhenTwoOrderedArraysArePassed()
        {
            var orderedArray1 = new int[] {2, 3, 5};
            var orderedArray2 = new int[] {2, 7, 9};
            var result = MergeSort.Merge(orderedArray1, orderedArray2);

            Assert.Equal(new int[]{2, 2, 3, 5, 7, 9}, result);
        }
    }
}