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

        //Using array store usage status
        public int TotalNQueens_Optimize(int n)
        {
            return Backtracing(new bool[5 * n], 0, n);
        }

        private int Backtracing(bool[] dp, int p, int n)
        {
            if (p == n)
                return 1;

            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                int column = i, d1 = i - p + n * 2, d2 = i + p + n * 3;
                if (!dp[column] && !dp[d1] && !dp[d2])
                {
                    SetValue(dp, true, column, d1, d2);
                    count += Backtracing(dp, p + 1, n);
                    SetValue(dp, false, column, d1, d2);
                }
            }
            return count;
        }

        private void SetValue(bool[] arr, bool value, params int[] indices)
        {
            foreach (int i in indices)
                arr[i] = value;
        }
    }
}
