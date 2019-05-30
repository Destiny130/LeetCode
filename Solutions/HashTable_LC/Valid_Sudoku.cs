using System.Collections.Generic;

namespace Solutions.HashTable_LC
{
    public class Valid_Sudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            for (int i = 0; i < 9; ++i)
            {
                HashSet<int> setR = new HashSet<int>();
                HashSet<int> setC = new HashSet<int>();
                HashSet<int> setB = new HashSet<int>();
                for (int j = 0; j < 9; ++j)
                {
                    if (board[i, j] != '.' && !setR.Add(board[i, j]))
                        return false;
                    if (board[j, i] != '.' && !setC.Add(board[j, i]))
                        return false;
                    int x = (i / 3) * 3 + j / 3;
                    int y = (i % 3) * 3 + j % 3;
                    if (board[x, y] != '.' && !setB.Add(board[x, y]))
                        return false;
                }
            }
            return true;
        }

        //Use one hash set
        public bool IsValidSudoku_O(char[,] board)
        {
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (board[i, j] != '.' && (!set.Add(board[i, j] + "in row" + i.ToString())
                                               || !set.Add(board[i, j] + "in column" + j.ToString())
                                               || !set.Add(board[i, j] + "in block" + i / 3 + "-" + j / 3)))
                        return false;
                }
            }
            return true;
        }

        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; ++i)
            {
                bool[] record = new bool[27];
                for (int j = 0; j < 9; ++j)
                {
                    char row = board[i][j];
                    if (row != '.')
                    {
                        if (record[row - '1'])
                            return false;
                        else
                            record[row - '1'] = true;
                    }

                    char column = board[j][i];
                    if (column != '.')
                    {
                        if (record[column - '1' + 9])
                            return false;
                        else
                            record[column - '1' + 9] = true;
                    }

                    int x = (i / 3) * 3 + j / 3;
                    int y = (i % 3) * 3 + j % 3;
                    char block = board[x][y];
                    if (block != '.')
                    {
                        if (record[block - '1' + 18])
                            return false;
                        else
                            record[block - '1' + 18] = true;
                    }
                }
            }
            return true;
        }
    }
}
