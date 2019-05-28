using System;

namespace Solutions.Backtracking_LC
{
    public class N_Queens_II
    {
        public int TotalNQueens(int n)
        {
            return Backtracing(new char[n, n], 0, n);
        }

        private int Backtracing(char[,] matrix, int p, int n)
        {
            if (p == n)
                return 1;

            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                if (Validate(matrix, p, i, n))
                {
                    matrix[p, i] = 'Q';
                    count += Backtracing(matrix, p + 1, n);
                    matrix[p, i] = Char.MinValue;
                }
            }
            return count;
        }

        private bool Validate(char[,] matrix, int x, int y, int n)
        {
            for (int k = -1; k <= 1; ++k)
            {
                for (int i = x, j = y; i >= 0 && j >= 0 && j < n; --i, j += k)
                {
                    if (matrix[i, j] == 'Q')
                        return false;
                }
            }
            return true;
        }
    }
}
