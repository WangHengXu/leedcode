using System;
using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversal
{
    /*
     * 给定一个二叉树，返回其按层次遍历的节点值。 （即逐层地，从左到右访问所有节点）。

例如:
给定二叉树: [3,9,20,null,null,15,7],

    3
   / \
  9  20
    /  \
   15   7
返回其层次遍历结果：

[
  [3],
  [9,20],
  [15,7]
]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-level-order-traversal
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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
      
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null) return list;
          Queue <TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int length = queue.Count;
                List<int> templist = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    TreeNode treeNode = queue.Dequeue();
                    templist.Add(treeNode.val);
                    if (treeNode.left != null)
                        queue.Enqueue(treeNode.left);
                    if (treeNode.right != null)
                        queue.Enqueue(treeNode.right);
                }
                list.Add(templist);
            }

            return list;
        }

        public IList<IList<int>> LevelOrder2(TreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (root == null) return list;
            helper(root, 0, list);
            return list;
        }
        public void helper(TreeNode root,int levels, IList<IList<int>> list)
        {
            if (list.Count == levels)
            {
                list.Add(new List<int>());
            }
            list[levels].Add(root.val);

            if (root.left != null)
            {
                helper(root.left, levels+1, list);
            }
            if (root.right != null)
            {
                helper(root.right, levels + 1, list);
            }
        }
    }
}
