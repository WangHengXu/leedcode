using System;
using TreeNodeNamespaces;

namespace MinimumDepthofBinaryTree
{
    /*
     * 给定一个二叉树，找出其最小深度。

最小深度是从根节点到最近叶子节点的最短路径上的节点数量。

说明: 叶子节点是指没有子节点的节点。

示例:

给定二叉树 [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
返回它的最小深度  2.

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/minimum-depth-of-binary-tree
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int Left = MinDepth(root.left);
            int Right = MinDepth(root.right);
            if (Right == 0)
                return Left + 1;
            if (Left == 0)
                return Right + 1;
            return Math.Min(Left, Right) + 1;
        }
    }
}
