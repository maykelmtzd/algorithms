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

            while(index1 < orderedArray1.Length && index2 < orderedArray2.Length)
            {
                if(orderedArray1[index1] <= orderedArray2[index2])
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

            if(index1 < orderedArray1.Length)
            {
                Enumerable.Range(index1, orderedArray1.Length - 1).ToList().ForEach(index => {
                    result[resultIndex] = orderedArray1[index];
                    resultIndex++; 
                });
            }
            else 
            {
                Enumerable.Range(index2, orderedArray2.Length - 1).ToList().ForEach(index => {
                    result[resultIndex] = orderedArray2[index];
                    resultIndex++; 
                });
            }

            return result;
        }
    }
}