using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Word_Search_II
    {
        int m = 0, n = 0;

        public IList<string> FindWords_NormalDFS(char[][] board, string[] words)
        {
            IList<string> result = new List<string>();
            if (board == null || board.Length == 0 || board[0].Length == 0)
                return result;
            m = board.Length;
            n = board[0].Length;
            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word))
                    result.Add(word);
                else {
                    char[] arr = word.ToCharArray();
                    bool flag = false;
                    for (int i = 0; i < m && !flag; ++i)
                    {
                        for (int j = 0; j < n && !flag; ++j)
                        {
                            flag = Find(board, arr, i, j, 0);
                        }
                    }
                    if (flag)
                        result.Add(word);
                }
            }
            return result;
        }

        private bool Find(char[][] board, char[] arr, int x, int y, int position)
        {
            if (x < 0 || x >= m || y < 0 || y >= n || position >= arr.Length || board[x][y] != arr[position])
                return false;
            if (position == arr.Length - 1)
                return true;
            board[x][y] = '0';
            bool flag = Find(board, arr, x - 1, y, position + 1) || Find(board, arr, x, y - 1, position + 1)
                || Find(board, arr, x + 1, y, position + 1) || Find(board, arr, x, y + 1, position + 1);
            board[x][y] = arr[position];
            return flag;
        }
    }
}
