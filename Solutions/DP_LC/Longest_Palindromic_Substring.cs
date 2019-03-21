using System;

namespace Solutions.DP_LC
{
    public class Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            if (s.Length < 2)
                return s;
            string result = String.Empty;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                string temp = Sub(arr, i, i);
                if (temp.Length > result.Length)
                    result = temp;
                temp = Sub(arr, i, i + 1);
                if (temp.Length > result.Length)
                    result = temp;
            }
            return result;
        }

        private string Sub(char[] arr, int low, int high)
        {
            for (; low >= 0 && high < arr.Length; --low, ++high)
            {
                if (arr[low] != arr[high])
                    break;
            }
            low += 1;
            high -= 1;
            return new string(arr, low, high - low + 1);
        }

        //Just store indexes
        public string LongestPalindrome_1(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 2)
                return s;
            int start = 0, end = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                int len1 = Expand(arr, i, i);
                int len2 = Expand(arr, i, i + 1);
                int len = len1 > len2 ? len1 : len2;
                if (len > end - start + 1)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }
            return new String(arr, start, end - start + 1);
        }

        private int Expand(char[] arr, int left, int right)
        {
            while (left >= 0 && right < arr.Length && arr[left] == arr[right])
            {
                --left;
                ++right;
            }
            return right - left - 1;
        }
    }
}
