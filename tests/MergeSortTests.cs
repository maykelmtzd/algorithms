using algorithms;
using Xunit;

namespace tests
{
    public class MergeSortTests
    {
        [Fact]
        public void ShouldReturnOrderedArrayWhenTwoOrderedArraysArePassed()
        {
            var orderedArray1 = new int[] { 2, 3, 5 };
            var orderedArray2 = new int[] { 2, 7, 9 };
            var result = MergeSort.Merge(orderedArray1, orderedArray2);

            Assert.Equal(new int[] { 2, 2, 3, 5, 7, 9 }, result);
        }

        [Fact]
        public void ShouldReturnOrderedArrayWhenTwoNumbersArePassed()
        {
            var orderedArray1 = new int[] { 2 };
            var orderedArray2 = new int[] { 6 };
            var result = MergeSort.Merge(orderedArray1, orderedArray2);

            Assert.Equal(new int[] { 2, 6 }, result);
        }

        [Fact]
        public void ShouldOrderArrayWithSeveralElements()
        {
            var array = new int[] { 2, 6, 1, 9 };
            var result = MergeSort.Order(array);
            Assert.Equal(new int[] { 1, 2, 6, 9 }, result);
        }

        [Fact]
        public void ShouldOrderArrayWithTwoElements()
        {
            var array = new int[] { 6, 2 };
            var result = MergeSort.Order(array);
            Assert.Equal(new int[] { 2, 6 }, result);
        }

        [Fact]
        public void ShouldOrderArrayWithOneElements()
        {
            var array = new int[] { 6 };
            var result = MergeSort.Order(array);
            Assert.Equal(new int[] { 6 }, result);
        }
    }
}