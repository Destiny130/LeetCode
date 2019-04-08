namespace Solutions.Array_LC
{
    public class Search_a_2D_Matrix_II
    {
        /*
        Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
            Integers in each row are sorted in ascending from left to right.
            Integers in each column are sorted in ascending from top to bottom.
        */

        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
                return false;
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            int i = 0, j = n - 1;
            while (i < m && j >= 0)
            {
                if (matrix[i, j] == target)
                    return true;
                else if (matrix[i, j] > target)
                    --j;
                else
                    ++i;
            }
            return false;
        }
    }
}
