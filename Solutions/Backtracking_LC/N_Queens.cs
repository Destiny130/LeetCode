using System;
using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class N_Queens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> result = new List<IList<string>>();

            char[][] matrix = new char[n][];
            for (int i = 0; i < n; ++i)
                matrix[i] = new char[n];
            Backtracing(matrix, 0, n, result);

            return result;
        }

        private void Backtracing(char[][] matrix, int p, int n, IList<IList<string>> result)
        {
            for (int i = 0; i < n; ++i)
            {
                if (CanPut(matrix, n, p, i))
                {
                    matrix[p][i] = 'Q';
                    if (p == n - 1)
                    {
                        //Add to result
                        AddToResult(matrix, n, result);
                    }
                    else
                    {
                        //Go to next depth
                        Backtracing(matrix, p + 1, n, result);
                    }
                    matrix[p][i] = Char.MinValue;
                }
            }
        }

        static List<int[]> dirs = new List<int[]>()
        {
            new int[] {-1, 0 },
            new int[] {-1, 1 },
            new int[] {0, 1 },
            new int[] {1, 1 },
            new int[] {1, 0 },
            new int[] {-1, -1 },
            new int[] {0, -1 },
            new int[] {-1, -1 },
        };

        private bool CanPut(char[][] matrix, int n, int x, int y)
        {
            foreach (int[] dir in dirs)
            {
                for (int i = x, j = y; i >= 0 && i < n && j >= 0 && j < n; i += dir[0], j += dir[1])
                {
                    if (matrix[i][j] == 'Q')
                        return false;
                }
            }
            return true;
        }

        private void AddToResult(char[][] matrix, int n, IList<IList<string>> result)
        {
            IList<string> list = new List<string>();
            for (int i = 0; i < n; ++i)
            {
                string row = String.Join("", matrix[i]).Replace(Char.MinValue, '.');
                list.Add(row);
            }
            result.Add(list);
        }
    }
}
