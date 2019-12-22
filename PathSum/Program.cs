using System;

namespace PathSum
{
    /*
     * 给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。

说明: 叶子节点是指没有子节点的节点。

示例: 
给定如下二叉树，以及目标和 sum = 22，

              5
             / \
            4   8
           /   / \
          11  13  4
         /  \      \
        7    2      1
返回 true, 因为存在目标和为 22 的根节点到叶子节点的路径 5->4->11->2

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/path-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
   
        public bool HasPathSum(TreeNode root, int sum)
        {
          return  HasPathSumcheck(root, 0, sum);
        }
        public bool HasPathSumcheck(TreeNode root, int cursum, int sum)
        {
            if (root == null) return false;
            cursum += root.val;
            if (root.left == null && root.right == null && cursum == sum)
            {
                return true;
            }
            if (HasPathSumcheck(root.left, cursum, sum))
            {
                return true;
            }
            if (HasPathSumcheck(root.right, cursum, sum))
            {
                return true;
            }
            return false;

        }

        public bool HasPathSum2(TreeNode root, int sum)
        {
            if (root == null)
                return false;

            sum -= root.val;
            if ((root.left == null) && (root.right == null))
                return (sum == 0);
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);

     
        }
    }
}
