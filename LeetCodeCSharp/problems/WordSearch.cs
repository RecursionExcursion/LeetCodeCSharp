using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    internal class WordSearch
    {

        public static bool Exist(char[][] board, string word)
        {

            char[] chars = word.ToCharArray();
            int index = 0;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == chars[index])
                    {
                        char[][] boardCopy = CopyBoardWithNulledIndexes(i, j, board);

                        if (IsValid(i, j, boardCopy, chars, index + 1))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool IsValid(int y, int x, char[][] board, char[] chars, int index)
        {
            if (index == chars.Length)
            {
                return true;
            }
            char nextChar = chars[index];
            char[][] boardCopy = CopyBoardWithNulledIndexes(y, x, board);

            //Down
            if (y < board.Length - 1 && board[y + 1][x] == nextChar)
            {
                if (IsValid(y + 1, x, boardCopy, chars, index + 1))
                {
                    return true;
                }
            }

            //Right
            if (x < board[y].Length - 1 && board[y][x + 1] == nextChar)
            {
                if (IsValid(y, x + 1, boardCopy, chars, index + 1))
                {
                    return true;
                }
            }

            //Up
            if (y > 0 && board[y - 1][x] == nextChar)
            {
                if (IsValid(y - 1, x, boardCopy, chars, index + 1))
                {
                    return true;
                }
            }

            //Left
            if (x > 0 && board[y][x - 1] == nextChar)
            {
                if (IsValid(y, x - 1, boardCopy, chars, index + 1))
                {
                    return true;
                }
            }

            return false;
        }

        private static char[][] CopyBoardWithNulledIndexes(int y, int x, char[][] board)
        {
            char[][] boardCopy = board.Select(a => a.ToArray()).ToArray();
            boardCopy[y][x] = '0';
            return boardCopy;
        }
    }
}
