using System;

public class QuickSort
{
    public static void Order(int[] numbers)
    {
        MyQuickSort(numbers, 0, numbers.Length - 1);
    }

    private static void MyQuickSort(int[] numbers, int leftIndex, int rightIndex)
    {
        if(leftIndex < rightIndex)
        {
            int partitionIndex = FindPartitionIndex(numbers, leftIndex, rightIndex);
            MyQuickSort(numbers, leftIndex, partitionIndex - 1);
            MyQuickSort(numbers, partitionIndex + 1, rightIndex);
        }
    }

    private static int FindPartitionIndex(int[] numbers, int leftIndex, int rightIndex)
    {
        int partitionIndex = leftIndex;
        for(int i = leftIndex; i < rightIndex; i++)
        {
            if(numbers[i] > numbers[i + 1])
            {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
                partitionIndex = i + 1;
            }
        }
        return partitionIndex;
    }
}