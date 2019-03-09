using System.Collections.Generic;

namespace Solutions.HashTable
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
    }
}
