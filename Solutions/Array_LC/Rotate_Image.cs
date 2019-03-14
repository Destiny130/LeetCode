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
        
        //Fold, then reverse
        public void Rotate_1(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            for (int i = 0; i < m; ++i)
            {
                for (int j = i + 1; j < m; ++j)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < m; ++i)
            {
                int low = 0, high = m - 1;
                while (low < high)
                {
                    int temp = matrix[i, low];
                    matrix[i, low++] = matrix[i, high];
                    matrix[i, high--] = temp;
                }
            }
        }

        //One for loop
        public void Rotate_2(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            for (int i = 0; i < m / 2; ++i)
            {
                for (int j = i; j < m - 1 - i; ++j)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[m - 1 - j, i];
                    matrix[m - 1 - j, i] = matrix[m - 1 - i, m - 1 - j];
                    matrix[m - 1 - i, m - 1 - j] = matrix[j, m - 1 - i];
                    matrix[j, m - 1 - i] = temp;
                }
            }
        }
    }
}
