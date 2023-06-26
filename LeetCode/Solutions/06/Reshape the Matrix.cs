using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._06
{
    internal class Reshape_the_Matrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int[][] result = new int[r][];
            int r_counter = 0, c_counter = 0, collumns = 0;

            for (int i  = 0; i < r; i++)
            {
                result[i] = new int[c];
            }
            if (mat.Length * mat[0].Length % (r * c) == 0)
            {
                for (int i  = 0; i < mat.Length; i++)
                {
                    for (int j = 0; j < mat[i].Length; j++)
                    {
                        if (c_counter < c)
                        {
                            result[r_counter][c_counter] = mat[i][j];
                            c_counter++;
                        }
                        else
                        {
                            c_counter = 0; r_counter += 1;
                            result[r_counter][c_counter] = mat[i][j];
                            c_counter++;
                        }
                    }
                }
            }
            return result;
        }

    }
}
