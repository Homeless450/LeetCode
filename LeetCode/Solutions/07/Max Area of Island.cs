using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Max_Area_of_Island
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int area = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        DFS(grid, i, j, ref temp);
                        area = Math.Max(area, temp);
                    }
                }
            }
            return area;
        }

        public void DFS(int[][] grid, int i, int j, ref int area)
        {
            grid[i][j] = 0;
            area++;
            if (i < grid.Length -1 && grid[i + 1][j] == 1) DFS(grid, i + 1, j, ref area);
            if (i > 0 && grid[i - 1][j] == 1) DFS(grid, i - 1, j, ref area);
            if (j < grid[0].Length - 1 && grid[i][j + 1] == 1) DFS(grid, i, j + 1, ref area);
            if (j > 0 && grid[i][j - 1] == 1) DFS(grid, i, j - 1, ref area);
        }
    }
}
