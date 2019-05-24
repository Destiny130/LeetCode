namespace Solutions.Array_LC
{
    public class Spiral_Matrix_II
    {
        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];
            for (int k = 0; k < n; ++k)
                matrix[k] = new int[n];

            int curr = 0, max = n * n;
            int rowLow = 0, rowHigh = n - 1, columnLow = 0, columnHigh = n - 1;

            while (curr < max)
            {
                //left to right
                for (int i = columnLow; i <= columnHigh; ++i)
                    matrix[rowLow][i] = ++curr;
                ++rowLow;

                //top to bottom
                for (int i = rowLow; i <= rowHigh; ++i)
                    matrix[i][columnHigh] = ++curr;
                --columnHigh;
                if (curr == max)
                    break;

                //right to left
                for (int i = columnHigh; i >= columnLow; --i)
                    matrix[rowHigh][i] = ++curr;
                --rowHigh;
                if (curr == max)
                    break;

                //bottom to top
                for (int i = rowHigh; i >= rowLow; --i)
                    matrix[i][columnLow] = ++curr;
                ++columnLow;
            }

            return matrix;
        }
    }
}
