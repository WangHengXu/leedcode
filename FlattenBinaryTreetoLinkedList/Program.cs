using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace FlattenBinaryTreetoLinkedList
{
    class Program
    {
        /*
         * 给定一个二叉树，原地将它展开为链表。

例如，给定二叉树

    1
   / \
  2   5
 / \   \
3   4   6
将其展开为：

1
 \
  2
   \
    3
     \
      4
       \
        5
         \
          6

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/flatten-binary-tree-to-linked-list
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        List<int> treeNodes = new List<int>();
        public TreeNode Flatten()
        {
            TreeNode treeNode = new TreeNode(treeNodes[0]);
            TreeNode temp = treeNode;
            for (int i = 1; i < treeNodes.Count; i++)
            {
                treeNode.right = new TreeNode(treeNodes[i]);
                treeNode = treeNode.right;
            }
            return temp;
        }
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            Flatten2(root);
            root = Flatten();
        }
        public void Flatten2(TreeNode root)
        {
            if (root == null) return;
            treeNodes.Add(root.val);
            Flatten(root.left);
            Flatten(root.right);
        }
    }
}
