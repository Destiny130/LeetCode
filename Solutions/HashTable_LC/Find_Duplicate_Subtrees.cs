using System.Collections.Generic;
using System.Linq;
using Solutions.BinaryTree_LC;

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

        //Don't store TreeNode in dic
        public IList<TreeNode> FindDuplicateSubtrees_1(TreeNode root)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            IList<TreeNode> result = new List<TreeNode>();
            NodeToString(root, dic, result);
            return result;
        }

        private string NodeToString(TreeNode node, Dictionary<string, int> dic, IList<TreeNode> list)
        {
            if (node == null)
                return "#";
            string str = node.val.ToString() + NodeToString(node.left, dic, list) + NodeToString(node.right, dic, list);
            if (dic.ContainsKey(str))
            {
                if (dic[str] == 1)
                    list.Add(node);
                ++dic[str];
            }
            else
            {
                dic[str] = 1;
            }
            return str;
        }
    }
}
