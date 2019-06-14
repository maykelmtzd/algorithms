using System;
using System.Linq;

namespace algorithms
{
    public class MergeSort
    {
        public static int[] Merge(int[] orderedArray1, int[] orderedArray2)
        {
            var result = new int[orderedArray1.Length + orderedArray2.Length];
            var maxLength = Math.Max(orderedArray1.Length, orderedArray2.Length);
            var index1 = 0;
            var index2 = 0;
            var resultIndex = 0;

            while (index1 < orderedArray1.Length && index2 < orderedArray2.Length)
            {
                if (orderedArray1[index1] <= orderedArray2[index2])
                {
                    result[resultIndex] = orderedArray1[index1];
                    index1++;
                }
                else
                {
                    result[resultIndex] = orderedArray2[index2];
                    index2++;
                }
                resultIndex++;
            }

            if (index1 < orderedArray1.Length)
            {
                Enumerable.Range(index1, orderedArray1.Length - index1).ToList().ForEach(index =>
                {
                    result[resultIndex] = orderedArray1[index];
                    resultIndex++;
                });
            }
            else
            {
                Enumerable.Range(index2, orderedArray2.Length - index2).ToList().ForEach(index =>
                {
                    result[resultIndex] = orderedArray2[index];
                    resultIndex++;
                });
            }

            return result;
        }

        public static int[] Order(int[] array)
        {
            if (array.Length == 1)
                return array;

            var midIndex = array.Length / 2;
            var leftArray = CreateArray(array, 0, midIndex - 1);
            var rightArray = CreateArray(array, midIndex, array.Length - 1);

            var leftOrderedArray = Order(leftArray);
            var rightOrderedArray = Order(rightArray);

            return Merge(leftOrderedArray, rightOrderedArray);
        }

        private static int[] CreateArray(int[] array, int leftIndex, int rightIndex)
        {
            var resultLegth = rightIndex - leftIndex + 1;
            var result = new int[resultLegth];
            // Enumerable.Range(leftIndex, resultLegth).ToList().ForEach(index => result[index] = array[index]);
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array[leftIndex];
                leftIndex++;
            }
            return result;
        }
    }
}