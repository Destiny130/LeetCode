using System;
using System.Collections.Generic;

namespace Solutions.HashTable
{
    public class Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int i = 0;
            foreach (string str in strs)
            {
                char[] arr = str.ToCharArray();
                System.Array.Sort(arr);
                string val = new String(arr);
                if (!dic.ContainsKey(val))
                {
                    dic.Add(val, i++);
                    result.Add(new List<string>());
                }
                result[dic[val]].Add(str);
            }
            return result;
        }
    }
}
