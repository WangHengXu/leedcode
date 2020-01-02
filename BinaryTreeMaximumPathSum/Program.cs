using System;
using TreeNodeNamespaces;

namespace BinaryTreeMaximumPathSum
{
    /*
     * 给定一个非空二叉树，返回其最大路径和。

本题中，路径被定义为一条从树中任意节点出发，达到任意节点的序列。该路径至少包含一个节点，且不一定经过根节点。

示例 1:

输入: [1,2,3]

       1
      / \
     2   3

输出: 6
示例 2:

输入: [-10,9,20,null,null,15,7]

   -10
   / \
  9  20
    /  \
   15   7

输出: 42

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-maximum-path-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int MaxPathSum(TreeNode root)
        {
            Helper(root);
            return max;
        }
        int max = int.MinValue;
        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            int left = Math.Max(Helper(root.left), 0);
            int right = Math.Max(Helper(root.right), 0);
            int temp = root.val + left + right;
            max = Math.Max(max, temp);
            return root.val + Math.Max(left, right);
        }
    }
}
