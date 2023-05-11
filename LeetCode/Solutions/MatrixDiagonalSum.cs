using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    internal class MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int result = 0;
            for (int i  = 0; i < mat.Length; i++)
            {
                result += mat[i][mat.Length - 1 - i] + mat[i][i];
            }
            if (mat.Length%2 != 0)
            {
                result = result - mat[mat.Length / 2][mat.Length / 2];
            }

            return result;
        }
        
    }
}
