using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace BinaryTreeRightSideView
{
    /*
     * 给定一棵二叉树，想象自己站在它的右侧，按照从顶部到底部的顺序，返回从右侧所能看到的节点值。

示例:

输入: [1,2,3,null,5,null,4]
输出: [1, 3, 4]
解释:

   1            <---
 /   \
2     3         <---
 \     \
  5     4       <---

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-right-side-view
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TreeNode treeNode1 = new TreeNode(1);
            TreeNode treeNode2 = new TreeNode(2);
            TreeNode treeNode3 = new TreeNode(3);
            TreeNode treeNode4 = new TreeNode(4);
            TreeNode treeNode5 = new TreeNode(5);

            treeNode1.left = treeNode2;
            treeNode1.right = treeNode3;
            treeNode2.right = treeNode5;
            treeNode3.right = treeNode4;
            var t= RightSideView(treeNode1);
            Console.ReadLine();
        }
        public static IList<int> RightSideView(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            while (treeNodes.Count>0)
            {
                var temp = treeNodes.Dequeue();
            
                int length = treeNodes.Count;
                if (temp.left != null) treeNodes.Enqueue(temp.left);
                if (temp.right != null) treeNodes.Enqueue(temp.right);

                if (length == 0) list.Add(temp.val);
                else
                {
                    for (int i = 0; i < length - 1; i++)
                    {
                        var t = treeNodes.Dequeue();
                        if (t.left != null) treeNodes.Enqueue(t.left);
                        if (t.right != null) treeNodes.Enqueue(t.right);
                    }
                    var t2 = treeNodes.Dequeue();
                     list.Add(t2.val);
                    if (t2.left != null) treeNodes.Enqueue(t2.left);
                    if (t2.right != null) treeNodes.Enqueue(t2.right);
                }

               
            }
            return list;
        }
    }
}
