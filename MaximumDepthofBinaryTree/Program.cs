using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace MaximumDepthofBinaryTree
{
  
    class Program
    {
        /*
         * 给定一个二叉树，找出其最大深度。

二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

说明: 叶子节点是指没有子节点的节点。

示例：
给定二叉树 [3,9,20,null,null,15,7]，

    3
   / \
  9  20
    /  \
   15   7
返回它的最大深度 3 。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/maximum-depth-of-binary-tree
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            else
            {
                int L = MaxDepth(root.left);
                int R = MaxDepth(root.right);
                return Math.Max(L, R) + 1;
            }
        }
        public int MaxDepth2(TreeNode root)
        {
            if (root == null) return 0;
            Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
            stack.Push(new Tuple<TreeNode, int>(root, 1));
            int depth = 0;
            while (stack.Count>0)
            {
                var temp = stack.Pop();
                depth = Math.Max(depth, temp.Item2);
                if (temp.Item1.right != null)
                {
                    stack.Push(new Tuple<TreeNode, int>(temp.Item1.right, temp.Item2 + 1));
                }
                 if (temp.Item1.left != null)
                {
                    stack.Push(new Tuple<TreeNode, int>(temp.Item1.left, temp.Item2 + 1));
                }
            }
            return depth;
        }
    }
}
