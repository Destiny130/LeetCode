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
    }
}
