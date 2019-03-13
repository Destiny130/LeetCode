namespace Solutions.Array_LC
{
    public class Rotate_Image
    {
        public void Rotate(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            for (int i = 0; i < m / 2; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[m - i - 1, j];
                    matrix[m - i - 1, j] = temp;
                }
            }
            for (int i = 0; i < m; ++i)
            {
                for (int j = i + 1; j < m; ++j)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
        }
    }
}
