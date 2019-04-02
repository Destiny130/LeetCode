namespace Solutions.Backtracking_LC
{
    public class Word_Search
    {
        int m = 0, n = 0;

        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return false;
            if (string.IsNullOrEmpty(word))
                return true;
            m = board.Length;
            n = board[0].Length;
            char[] arr = word.ToCharArray();
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (board[i][j] == word[0] && DFS(board, i, j, arr, 0))
                        return true;
                }
            }
            return false;
        }

        private bool DFS(char[][] board, int i, int j, char[] arr, int position)
        {
            if (i == -1 || j == -1 || i >= m || j >= n || position >= arr.Length || board[i][j] != arr[position])
                return false;
            if (position == arr.Length - 1)
                return true;
            board[i][j] = '*';
            bool result = DFS(board, i + 1, j, arr, position + 1) ||
                          DFS(board, i, j + 1, arr, position + 1) ||
                          DFS(board, i - 1, j, arr, position + 1) ||
                          DFS(board, i, j - 1, arr, position + 1);
            board[i][j] = arr[position];
            return result;
        }
    }
}
