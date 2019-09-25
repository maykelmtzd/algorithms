using algorithms;
using Xunit;

namespace tests
{
    public class MatrixRotationTests
    {
        [Fact]
        public void ShouldRotate90DegreesWith2X2Matrix()
        {
            int[,] matrix = new int[2, 2] {
                {1,2},
                {3,4},
            };

            int[,] resultMatrix = new int[2, 2] {
                {3,1},
                {4,2},
            };

            Assert.Equal(resultMatrix, MatrixRotation.Rotate90Degrees(matrix));
        }

        [Fact]
        public void ShouldRotate90DegreesWith3X3Matrix()
        {
            int[,] matrix = new int[3, 3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] resultMatrix = new int[3, 3] {
                {7,4,1},
                {8,5,2},
                {9,6,3}
            };

            Assert.Equal(resultMatrix, MatrixRotation.Rotate90Degrees(matrix));
        }

        [Fact]
        public void ShouldRotate90DegreesWith4X4Matrix()
        {
            int[,] matrix = new int[4, 4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12},
                {13,14,15,16}
            };

            int[,] resultMatrix = new int[4, 4] {
                {13,9,5,1},
                {14,10,6,2},
                {15,11,7,3},
                {16,12,8,4}
            };

            Assert.Equal(resultMatrix, MatrixRotation.Rotate90Degrees(matrix));
        }
    }
}