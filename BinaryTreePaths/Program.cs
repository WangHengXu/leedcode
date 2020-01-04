using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace BinaryTreePaths
{
    class Program
    {
        /*
         * 给定一个二叉树，返回所有从根节点到叶子节点的路径。

说明: 叶子节点是指没有子节点的节点。

示例:

输入:

   1
 /   \
2     3
 \
  5

输出: ["1->2->5", "1->3"]

解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-paths
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> list = new List<string>();
       
            Helper(root, "",list);
            return list;
        }
        public void Helper(TreeNode root,string str,IList<string> list)
        {
            if (root == null) return;
            if (string.IsNullOrEmpty(str))
            {
                str = $"{root.val}";
            }
            else
                str = $"{str}->{root.val}";
            if (root.left == null && root.right == null)
            {
                list.Add(str);
            }
            Helper(root.left, str, list);
            Helper(root.right, str, list);
        }
    }
}
