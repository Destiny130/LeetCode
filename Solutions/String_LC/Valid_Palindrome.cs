using System;
using System.Collections.Generic;

namespace Solutions.String_LC
{
    public class Valid_Palindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            List<char> list = new List<char>();
            foreach (char c in s)
                if (IsAbc(c) || IsNum(c))
                    list.Add(c);
            int low = 0, high = list.Count - 1;
            while (low < high)
            {
                char a = list[low++];
                char b = list[high--];
                if (!IsEqual(a, b))
                    return false;
            }
            return true;
        }

        private bool IsAbc(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        private bool IsNum(char c)
        {
            return c >= '0' && c <= '9';
        }

        private bool IsEqual(char a, char b)
        {
            if (IsNum(a) || IsNum(b))
                return a == b;
            return a == b || Math.Abs(a - b) == 32;
        }
    }
}
