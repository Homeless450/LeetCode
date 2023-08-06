using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int collumn = matrix.Length - 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] > target)
                {
                    collumn = i; break;
                }
            }
            if (collumn < 0) return false; 
            for (int i = 0; i < matrix[collumn].Length; i++)
            {
                if ((matrix[collumn][i] == target)) return true;
            }
            return false;
        }

    }
}
