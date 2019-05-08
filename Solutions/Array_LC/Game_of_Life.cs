using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Game_of_Life
    {
        /*
        According to the Wikipedia's article: "The Game of Life, also known simply as Life, is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
        Given a board with m by n cells, each cell has an initial state live (1) or dead (0). Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using the following four rules (taken from the above Wikipedia article):
        1. Any live cell with fewer than two live neighbors dies, as if caused by under-population.
        2. Any live cell with two or three live neighbors lives on to the next generation.
        3. Any live cell with more than three live neighbors dies, as if by over-population..
        4. Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
        Write a function to compute the next state (after one update) of the board given its current state. The next state is created by applying the above rules simultaneously to every cell in the current state, where births and deaths occur simultaneously.
        */

        int m = 0, n = 0;

        public void GameOfLife(int[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return;
            m = board.Length;
            n = board[0].Length;
            int[][] record = new int[m][];
            for (int i = 0; i < m; ++i)
            {
                int[] row = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    row[j] = CountOne(board, i, j);
                }
                record[i] = row;
            }

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    board[i][j] = Update(board[i][j], record[i][j]);
                }
            }
        }

        List<int[]> list = new List<int[]>(){
            new int[2]{-1, -1},
            new int[2]{-1, 0},
            new int[2]{-1, 1},
            new int[2]{0, -1},
            new int[2]{0, 1},
            new int[2]{1, -1},
            new int[2]{1, 0},
            new int[2]{1, 1}
        };

        private int CountOne(int[][] board, int x, int y)
        {
            int count = 0;
            list.ForEach(point =>
            {
                int i = x + point[0], j = y + point[1];
                if (i != -1 && i != m && j != -1 && j != n)
                    count += board[i][j];
            });
            return count;
        }

        private int Update(int origVal, int count)
        {
            if (origVal == 0)
            {
                return count == 3 ? 1 : 0;
            }
            else {
                return (count < 2 || count > 3) ? 0 : 1;
            }
        }

        //Const space
        int[][] dirs = { new int[] { -1, -1 }, new int[] { -1, 0 }, new int[] { -1, 1 }, new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { 1, -1 }, new int[] { 1, 0 }, new int[] { 1, 1 } };

        public void GameOfLife_ConstSpace(int[][] board)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return;
            m = board.Length;
            n = board[0].Length;
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    int count = CountLive(board, i, j);
                    if (board[i][j] == 0)
                        board[i][j] = count == 3 ? 2 : 0;
                    else
                        board[i][j] = (count < 2 || count > 3) ? 1 : 3;
                }
            }

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    board[i][j] >>= 1;
                }
            }
        }

        private int CountLive(int[][] board, int x, int y)
        {
            int count = 0;
            foreach (int[] dir in dirs)
            {
                int i = x + dir[0], j = y + dir[1];
                if (i != -1 && i != m && j != -1 && j != n)
                    count += board[i][j] % 2;
            }
            return count;
        }
    }
}
