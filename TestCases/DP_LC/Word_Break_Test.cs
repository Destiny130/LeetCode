using System;
using System.Collections.Generic;
using System.Diagnostics;
using Solutions.DP_LC;

namespace TestCases.DP_LC
{
    public class Word_Break_Test
    {
        public void Execute()
        {
            string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab";
            IList<string> wordDict = new List<string>() { "a", "aa", "aaa", "aaaa", "aaaaa", "aaaaaa", "aaaaaaa", "aaaaaaaa", "aaaaaaaaa", "aaaaaaaaaa" };
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine($"{new Word_Break().WordBreak_DP(s, wordDict)}");
            watch.Stop();
            Console.WriteLine($"spent: {watch.ElapsedMilliseconds} milliseconds\n");
        }
    }
}
