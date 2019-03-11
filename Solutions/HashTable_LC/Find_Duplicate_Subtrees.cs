using Solutions.BinaryTree_LC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.HashTable_LC
{
    public class Find_Duplicate_Subtrees
    {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            Dictionary<TreeNode, string> dic = new Dictionary<TreeNode, string>();
            NodeToString(root, dic);
            IList<TreeNode> result = new List<TreeNode>();
            Dictionary<string, int> countDic = new Dictionary<string, int>();
            foreach (string str in dic.Values)
            {
                if (countDic.ContainsKey(str))
                    ++countDic[str];
                else
                    countDic[str] = 1;
            }
            Stack<string> stack = new Stack<string>(countDic.Where(d => d.Value > 1).Select(d => d.Key));
            while (stack.Count != 0)
            {
                string curr = stack.Pop();
                foreach (var pair in dic)
                {
                    if (pair.Value == curr)
                    {
                        result.Add(pair.Key);
                        break;
                    }
                }
            }
            return result;
        }

        private string NodeToString(TreeNode node, Dictionary<TreeNode, string> dic)
        {
            if (node == null)
                return "N";
            if (!dic.ContainsKey(node))
                dic[node] = NodeToString(node.left, dic) + node.val.ToString() + NodeToString(node.right, dic);
            return dic[node];
        }
    }
}
