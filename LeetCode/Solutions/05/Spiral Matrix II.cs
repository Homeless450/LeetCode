using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class Spiral_Matrix_II
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            int count = 1;
            int left = 0, right = n - 1, top = 0, bottom = n - 1;

            for (int i = 0; i < n; i++)
                matrix[i] = new int[n];

            while (count < n * n + 1)
            {
                for (int j = left; j <= right; j++)
                {
                    matrix[top][j] = count++;
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right] = count++;
                }
                right--;

                if (top <= bottom)
                {
                    for (int j = right; j >= left; j--)
                    {
                        matrix[bottom][j] = count++;
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i][left] = count++;
                    }
                    left++;
                }
            }

            return matrix;
        }
    }
}
