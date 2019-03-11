using System.Collections.Generic;
using System.Linq;

namespace Solutions.HashTable
{
    class Uncommon_Words_from_Two_Sentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in A.Split(' '))
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 1);
            }
            foreach (string word in B.Split(' '))
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 1);
            }
            return dic.Where(d => d.Value == 1).Select(d => d.Key).ToArray();
        }

        //One loop
        public string[] UncommonFromSentences_OneLoop(string A, string B)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string word in (A + ' ' + B).Split(' '))
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 1);
            }
            return dic.Where(d => d.Value == 1).Select(d => d.Key).ToArray();
        }
    }
}
