using System;
using System.Collections.Generic;

namespace Solutions.Backtracking_LC
{
    public class Letter_Combinations_of_a_Phone_Number
    {
        string[] dic = new string[] { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            DFS(result, digits.ToCharArray(), 0, String.Empty);
            return result;
        }

        private void DFS(IList<string> result, char[] arr, int position, string prefix)
        {
            if (position == arr.Length)
                return;
            else if (position == arr.Length - 1)
                foreach (char c in dic[arr[position] - 50])
                    result.Add(prefix + c);
            else
                foreach (char c in dic[arr[position] - 50])
                    DFS(result, arr, position + 1, prefix + c);
        }
    }
}
