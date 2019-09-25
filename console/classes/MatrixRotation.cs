using System;
using System.Collections.Generic;

namespace algorithms
{
    public class MatrixRotation
    {
        public static int[,] Rotate90Degrees(int[,] matrix)
        {
            int startColIndex = 0;
            int endColIndex = Convert.ToInt32(matrix.GetLongLength(0) - 1);
            int maxRowIndex = Convert.ToInt32(matrix.GetLongLength(0) - 1);

            while (startColIndex < endColIndex)
            {
                Rotate(matrix, startColIndex, endColIndex, maxRowIndex);
                startColIndex++;
                endColIndex--;
            }

            return matrix;
        }

        private static void Rotate(int[,] matrix, int startColIndex, int endColIndex, int maxRowIndex)
        {
            int currentRow = startColIndex;
            for (int i = startColIndex; i < endColIndex; i++)
            {
                Swap(matrix, currentRow, i, maxRowIndex);
            }
        }

        private static void Swap(int[,] matrix, int currentRow, int startIndex, int maxRowIndex)
        {
            int row = currentRow;
            int col = startIndex;
            int tempBehind = matrix[row, col];
            int temp = 0;
            do
            {
                temp = matrix[col, maxRowIndex - row];
                matrix[col, maxRowIndex - row] = tempBehind;
                tempBehind = temp;
                temp = row;
                row = col;
                col = maxRowIndex - temp;
            }
            while (!(row == currentRow && col == startIndex));

            matrix[col, maxRowIndex - row] = tempBehind;
        }
    }
}