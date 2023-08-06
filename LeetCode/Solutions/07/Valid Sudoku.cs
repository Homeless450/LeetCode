using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._07
{
    internal class Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++) if (!CheckRow(board, i)) return false;
            for (int i = 0; i < 9; i++) if (!CheckCollumn(board, i)) return false;
            for (int i = 0; i < 9 / 3; i++)
            {
                for (int j = 0; j < 9 / 3; j++)
                {
                    if (!CheckBlock(board, i, j)) return false;
                }
            }
            return true;
        }

        private bool CheckRow(char[][] board, int row)
        {
            HashSet<char> digits = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if (digits.Contains(board[row][i]) && board[row][i] != '.') return false;
                else digits.Add(board[row][i]);
            }
            return true;
        }
        private bool CheckCollumn(char[][] board, int c)
        {
            HashSet<char> digits = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if (digits.Contains(board[i][c]) && board[i][c] != '.') return false;
                else digits.Add(board[i][c]);
            }
            return true;

        }

        private bool CheckBlock(char[][] board, int row, int col)
        {
            HashSet<char> digits = new HashSet<char>();
            for (int i = row * 3; i < row * 3 + 3; i++)
            {
                for (int j = col * 3; j < col * 3 + 3; j++)
                {
                    if (digits.Contains(board[i][j]) && board[i][j] != '.') return false;
                    else digits.Add(board[i][j]);
                }
            }
            return true;
        }

    }
}
