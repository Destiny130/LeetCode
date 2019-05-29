namespace Solutions.Backtracking_LC
{
    public class Sudoku_Solver
    {
        public void SolveSudoku(char[][] board)
        {
            Backtracing(board, 0);
        }

        private bool Backtracing(char[][] board, int row)
        {
            for (int i = row; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (board[i][j] == '.')
                    {
                        for (int k = 1; k <= 9; ++k)
                        {
                            char c = (char)(k + '0');
                            if (Validate(board, i, j, c))
                            {
                                board[i][j] = c;
                                if (Backtracing(board, row))
                                    return true;
                                else
                                    board[i][j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool Validate(char[][] board, int x, int y, char c)
        {
            for (int i = 0; i < 9; ++i)
            {
                if (board[x][i] == c)
                    return false;
                if (board[i][y] == c)
                    return false;
                int j = (x / 3) * 3 + i / 3;
                int k = (y / 3) * 3 + i % 3;
                if (board[j][k] == c)
                    return false;
            }

            return true;
        }
    }
}
