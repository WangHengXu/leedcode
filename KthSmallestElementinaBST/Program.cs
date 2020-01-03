using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace KthSmallestElementinaBST
{
    /*
     * 给定一个二叉搜索树，编写一个函数 kthSmallest 来查找其中第 k 个最小的元素。

说明：
你可以假设 k 总是有效的，1 ≤ k ≤ 二叉搜索树元素个数。

示例 1:

输入: root = [3,1,4,null,2], k = 1
   3
  / \
 1   4
  \
   2
输出: 1
示例 2:

输入: root = [5,3,6,2,4,null,null,1], k = 3
       5
      / \
     3   6
    / \
   2   4
  /
 1
输出: 3
进阶：
如果二叉搜索树经常被修改（插入/删除操作）并且你需要频繁地查找第 k 小的值，你将如何优化 kthSmallest 函数？

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/kth-smallest-element-in-a-bst
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
            TreeNode treeNode6 = new TreeNode(6);


            //treeNode3.left = treeNode1;
            //treeNode3.right = treeNode4;

            //treeNode1.right = treeNode2;

            treeNode5.left = treeNode3;
            treeNode5.right = treeNode6;
            treeNode3.left = treeNode2;
            treeNode3.right = treeNode4;
            treeNode2.left = treeNode1;
            KthSmallest2(treeNode5, 3);
        }
        private int res, count;
        public int KthSmallest(TreeNode root, int k)
        {
            count = k;
            Inorder(root);
            return res;
        }
        private void Inorder(TreeNode root)
        {
            if (root == null || count == 0) return;
            Inorder(root.left);
            if (--count == 0) res = root.val;
            Inorder(root.right);
        }


        public static int KthSmallest2(TreeNode root, int k)
        {
            if (root == null) return -1;
            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            TreeNode cur = root;
            int i = 0;

            
            while ((treeNodes.Count > 0 || cur != null))
            {
                while (cur != null)
                {
                    treeNodes.Push(cur);
                    cur = cur.left;
                }
                cur = treeNodes.Pop();

                i++;
                if (i == k)
                {
                    return cur.val;
                }
                cur = cur.right;
            }
            return -1;
        }
    }
}
