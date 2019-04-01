namespace Solutions.Array_LC
{
    public class Set_Matrix_Zeroes
    {
        /*
        Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in-place.
        */

        public void SetZeroes(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return;
            int m = matrix.Length, n = matrix[0].Length;
            bool[] scan = new bool[m + n];
            for (int i = 0; i < m; ++i)
                for (int j = 0; j < n; ++j)
                    if (matrix[i][j] == 0)
                        scan[i] = scan[m + j] = true;

            for (int i = 0; i < m + n; ++i)
            {
                if (scan[i])
                {
                    if (i < m)
                    {
                        for (int j = 0; j < n; ++j)
                            matrix[i][j] = 0;
                    }
                    else
                    {
                        for (int j = 0; j < m; ++j)
                            matrix[j][i - m] = 0;
                    }
                }
            }
        }

        public void SetZeroes_ConstSpace(int[][] matrix)
        {
            int m = matrix.Length, n = matrix[0].Length;
            bool mark = false;
            for (int i = 0; i < m; ++i)
            {
                if (matrix[i][0] == 0)
                    mark = true;
                for (int j = 1; j < n; ++j)
                    if (matrix[i][j] == 0)
                        matrix[i][0] = matrix[0][j] = 0;
            }

            for (int i = m - 1; i >= 0; --i)
            {
                for (int j = n - 1; j >= 1; --j)
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                if (mark)
                    matrix[i][0] = 0;
            }
        }
    }
}
