using System;

namespace Solutions.Array_LC
{
    public class Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            char[] arr = s.ToCharArray();
            int[] dic = new int[256];
            int result = 0;
            for (int i = 0, j = 0; i < arr.Length; ++i)
            {
                j = Math.Max(j, dic[arr[i]]);
                dic[arr[i]] = i + 1;
                result = Math.Max(i - j + 1, result);
            }
            return result;
        }
    }
}
