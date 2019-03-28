using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Pascal_s_Triangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (numRows == 0)
                return ans;
            IList<int> list = new List<int>() { 1 };
            ans.Add(list);
            if (numRows == 1)
                return ans;
            for (int i = 0; i < numRows - 1; ++i)
            {
                IList<int> curr = new List<int>() { 1 };
                for (int j = 0; j < i; ++j)
                    curr.Add(ans[i][j] + ans[i][j + 1]);
                curr.Add(1);
                ans.Add(curr);
            }
            return ans;
        }
    }
}
