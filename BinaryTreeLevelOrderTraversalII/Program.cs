using System;
using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversalII
{
    class Program
    {
        /*
         * 给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）

例如：
给定二叉树 [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
返回其自底向上的层次遍历为：

[
  [15,7],
  [9,20],
  [3]
]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null) return list;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                IList<int> templist = new List<int>();
                int length = queue.Count;
                for (int i = 0; i < length; i++)
                {
                    TreeNode treeNode= queue.Dequeue();
                    templist.Add(treeNode.val);
                    if (treeNode.left != null)
                    {
                        queue.Enqueue(treeNode.left);
                    }
                    if (treeNode.right != null)
                    {
                        queue.Enqueue(treeNode.right);
                    }
                }
                if (list.Count > 0)
                {
                    list.Insert(0, templist);
                }
                else
                {
                    list.Add(templist);
                }
            }

            return list;
        }
    }
}
