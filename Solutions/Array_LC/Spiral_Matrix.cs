using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Spiral_Matrix
    {
        /*
        Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
        */

        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> list = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return list;
            int m = matrix.Length, n = matrix[0].Length, left = 0, top = 0;
            int len = m * n;
            --m;
            --n;
            while (list.Count < len)
            {
                //left to right
                for (int i = left; i <= n; ++i)
                {
                    list.Add(matrix[top][i]);
                }
                ++top;

                //top to bottom
                if (top > m)
                    break;
                for (int i = top; i <= m; ++i)
                {
                    list.Add(matrix[i][n]);
                }
                --n;

                //right to left
                if (left > n)
                    break;
                for (int i = n; i >= left; --i)
                {
                    list.Add(matrix[m][i]);
                }
                --m;

                //bottom to top
                for (int i = m; i >= top; --i)
                {
                    list.Add(matrix[i][left]);
                }
                ++left;
            }
            return list;
        }
    }
}
