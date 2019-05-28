using System.Collections.Generic;
using System.Text;

namespace Solutions.Backtracking_LC
{
    public class N_Queens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> result = new List<IList<string>>();
            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i, j] = '.';
                }
            }
            Backtracing(matrix, 0, n, result);
            return result;
        }

        private void Backtracing(char[,] matrix, int p, int n, IList<IList<string>> result)
        {
            if (p == n)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < n; ++i)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < n; ++j)
                    {
                        sb.Append(matrix[i, j]);
                    }
                    list.Add(sb.ToString());
                }
                result.Add(list);
                return;
            }

            for (int i = 0; i < n; ++i)
            {
                if (Validate(matrix, n, p, i))
                {
                    matrix[p, i] = 'Q';
                    Backtracing(matrix, p + 1, n, result);
                    matrix[p, i] = '.';
                }
            }
        }

        private bool Validate(char[,] matrix, int n, int x, int y)
        {
            for (int k = -1; k < 2; ++k)
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
        public IList<IList<string>> SolveNQueens_Optimize(int n)
        {
            IList<IList<string>> result = new List<IList<string>>();

            char[,] matrix = new char[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i, j] = '.';
                }
            }
            Backtracing(matrix, new bool[n * 5], 0, n, result);
            return result;
        }

        private void Backtracing(char[,] matrix, bool[] dp, int p, int n, IList<IList<string>> result)
        {
            if (p == n)
            {
                List<string> list = new List<string>();
                for (int i = 0; i < n; ++i)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < n; ++j)
                    {
                        sb.Append(matrix[i, j]);
                    }
                    list.Add(sb.ToString());
                }
                result.Add(list);
                return;
            }

            for (int i = 0; i < n; ++i)
            {
                int column = i, d1 = i - p + n * 2, d2 = i + p + n * 3;
                if (!dp[column] && !dp[d1] && !dp[d2])
                {
                    SetValue(dp, true, column, d1, d2);
                    matrix[p, i] = 'Q';
                    Backtracing(matrix, dp, p + 1, n, result);
                    SetValue(dp, false, column, d1, d2);
                    matrix[p, i] = '.';
                }
            }
        }

        private void SetValue(bool[] arr, bool value, params int[] indices)
        {
            foreach (int i in indices)
                arr[i] = value;
        }
    }
}
