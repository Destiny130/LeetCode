using System.Collections.Generic;

namespace Solutions.Math_LC
{
    public class Roman_to_Integer
    {
        /*
        Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        Symbol       Value
        I             1
        V             5
        X             10
        L             50
        C             100
        D             500
        M             1000
        */

        public int RomanToInt(string s)
        {
            int[] dp = new int[26];
            char prev = '0';
            int count = 0;
            foreach (char c in s)
            {
                if (c == 'M' || c == 'D')
                {
                    int temp = c == 'M' ? 1000 : 500;
                    if (prev == 'C')
                    {
                        temp -= count * 100;
                        dp['C' - 'A'] -= count * 100;
                    }
                    dp[c - 'A'] += temp;
                }
                else if (c == 'C' || c == 'L')
                {
                    int temp = c == 'C' ? 100 : 50;
                    if (prev == 'X')
                    {
                        temp -= count * 10;
                        dp['X' - 'A'] -= count * 10;
                    }
                    dp[c - 'A'] += temp;
                }
                else if (c == 'X' || c == 'V')
                {
                    int temp = c == 'X' ? 10 : 5;
                    if (prev == 'I')
                    {
                        temp -= count * 1;
                        dp['I' - 'A'] -= count * 1;
                    }
                    dp[c - 'A'] += temp;
                }
                else {  //Should be 'I' here
                    dp[c - 'A'] += 1;
                }
                count += c == prev ? 1 : -count + 1;
                prev = c;
            }
            int result = 0;
            foreach (int i in dp)
                result += i;
            return result;
        }

        //Using dictionary
        public int RomanToInt_Dic(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>(){
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            char[] arr = s.ToCharArray();
            int result = dic[arr[arr.Length - 1]];
            for (int i = arr.Length - 2; i != -1; --i)
            {
                result += dic[arr[i]] < dic[arr[i + 1]] ? -dic[arr[i]] : dic[arr[i]];
            }
            return result;
        }
    }
}
