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
            if (matrix == null || matrix.Length == 0)
                return false;
            int m = matrix.GetLength(0), n = matrix.GetLength(1);
            int i = 0, j = m - 1;
            while (i < n && j >= 0)
            {
                if (matrix[j, i] == target)
                    return true;
                else if (matrix[j, i] > target)
                    --j;
                else
                    ++i;
            }
            return false;
        }

        public bool SearchMatrix_DC(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
                return false;
            return SearchMatrix(matrix, target, 0, matrix.GetLength(0) - 1, 0, matrix.GetLength(1) - 1);
        }

        private bool SearchMatrix(int[,] matrix, int target, int rowLow, int rowHigh, int columnLow, int columnHigh)
        {
            if (rowLow > rowHigh || columnLow > columnHigh)
                return false;

            int rowMid = rowLow + (rowHigh - rowLow) / 2, columnMid = columnLow + (columnHigh - columnLow) / 2;
            int value = matrix[rowMid, columnMid];
            if (value == target)
                return true;

            if (value > target)
            {
                return SearchMatrix(matrix, target, rowLow, rowMid - 1, columnLow, columnMid - 1) ||
                    SearchMatrix(matrix, target, rowLow, rowMid - 1, columnMid, columnHigh) ||
                    SearchMatrix(matrix, target, rowMid, rowHigh, columnLow, columnMid - 1);
            }
            else
            {
                return SearchMatrix(matrix, target, rowMid + 1, rowHigh, columnMid + 1, columnHigh) ||
                    SearchMatrix(matrix, target, rowLow, rowMid, columnMid + 1, columnHigh) ||
                    SearchMatrix(matrix, target, rowMid + 1, rowHigh, columnLow, columnMid);
            }
        }

        private bool SearchMatrix_Optimize(int[,] matrix, int target, int rowLow, int rowHigh, int columnLow, int columnHigh)
        {
            if (rowLow > rowHigh || columnLow > columnHigh)
                return false;
            int rowMid = (rowLow + rowHigh) / 2, columnMid = (columnLow + columnHigh) / 2;
            if (matrix[rowMid, columnMid] == target)
                return true;
            else if (matrix[rowMid, columnMid] > target)
            {
                int visit = rowMid - 1;
                while (visit >= rowLow && matrix[visit, columnMid] > target)
                    --visit;
                return (visit >= rowLow && (matrix[visit, columnMid] == target || SearchMatrix_Optimize(matrix, target, rowLow, visit, columnMid + 1, columnHigh))) ||
                    SearchMatrix_Optimize(matrix, target, visit + 1, rowHigh, columnLow, columnMid - 1);
            }
            else
            {
                int visit = rowMid + 1;
                while (visit <= rowHigh && matrix[visit, columnMid] < target)
                    ++visit;
                return (visit <= rowHigh && (matrix[visit, columnMid] == target || SearchMatrix_Optimize(matrix, target, visit, rowHigh, columnLow, columnMid - 1))) ||
                    SearchMatrix_Optimize(matrix, target, rowLow, visit - 1, columnMid + 1, columnHigh);
            }
        }
    }
}
