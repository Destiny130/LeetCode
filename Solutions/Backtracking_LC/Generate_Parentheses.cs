using System;
using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Generate_Parentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            DFS(result, String.Empty, 0, 0, n);
            return result;
        }

        private void DFS(IList<string> result, string curr, int open, int close, int max)
        {
            if (curr.Length == max * 2)
            {
                result.Add(curr);
                return;
            }
            if (open < max)
                DFS(result, curr + "(", open + 1, close, max);
            if (close < open)
                DFS(result, curr + ")", open, close + 1, max);
        }
    }
}
