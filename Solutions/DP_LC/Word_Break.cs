using System.Collections.Generic;
using System.Linq;

namespace Solutions.DP_LC
{
    public class Word_Break
    {
        //Brute force, get TLE
        public bool WordBreak(string s, IList<string> wordDict)
        {
            Dictionary<string, int> dic = wordDict.ToDictionary(w => w, w => w.Length);
            char[] arr = s.ToCharArray();
            return Divide(arr, 0, dic);
        }

        private bool Divide(char[] arr, int start, Dictionary<string, int> dic)
        {
            if (start > arr.Length)
                return false;
            for (int i = start; i < arr.Length; ++i)
            {
                if (dic.ContainsKey(new string(arr, start, i - start + 1)))
                {
                    if (i == arr.Length - 1)
                        return true;
                    bool sub = Divide(arr, i + 1, dic);
                    if (!sub)
                        continue;
                    return true;
                }
            }
            return false;
        }

        //DP, using bool array
        public bool WordBreak_DP(string s, IList<string> wordDict)
        {
            HashSet<string> set = new HashSet<string>(wordDict);
            bool[] dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (dp[j] && set.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
