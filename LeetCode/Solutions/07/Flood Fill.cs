using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Flood_Fill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            if (image[sr][sc] == color) return image;
            Fill(image, sr, sc, color, image[sr][sc]);
            return image;
        }

        void Fill(int[][] image, int sr, int sc, int color, int orig)
        {
            if (sr < 0 || sr == image.Length) return;
            if (sc < 0 || sc == image[0].Length) return;
            if (image[sr][sc] != orig) return;
            image[sr][sc] = color;
            Fill(image, sr - 1, sc, color, orig);
            Fill(image, sr + 1, sc, color, orig);
            Fill(image, sr, sc - 1, color, orig);
            Fill(image, sr, sc + 1, color, orig);
        }
    }
}
