using System;

namespace Solutions.HashTable_LC
{
    public class Find_the_Difference
    {
        public char FindTheDifference(string s, string t)
        {
            int[] arr = new int[26];
            foreach (char c in String.Concat(s, t).ToCharArray())
                arr[c - 'a']++;
            for (int i = 0; i < 26; ++i)
                if ((arr[i] & 1) == 1)
                    return (char)(i + 'a');
            return '0';
        }

        //Optimize 1
        public char FindTheDifference_1(string s, string t)
        {
            int[] arr = new int[26];
            foreach (char c in s.ToCharArray())
                arr[c - 'a']++;
            foreach (char c in t.ToCharArray())
            {
                arr[c - 'a']--;
                if (arr[c - 'a'] == -1)
                    return c;
            }
            return '0';
        }

        //Using xor
        public char FindTheDifference_XOR(string s, string t)
        {
            char ans = '0';
            foreach (char c in s)
                ans ^= c;
            foreach (char c in t)
                ans ^= c;
            return (char)(ans ^ '0');
        }
    }
}
