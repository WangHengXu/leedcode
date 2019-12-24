﻿using System;
using System.Collections.Generic;

namespace ConstructBinaryTreefromPreorderandInorderTraversal
{
    /*
     * 根据一棵树的前序遍历与中序遍历构造二叉树。

注意:
你可以假设树中没有重复的元素。

例如，给出

前序遍历 preorder = [3,9,20,15,7]
中序遍历 inorder = [9,3,15,20,7]
返回如下的二叉树：

    3
   / \
  9  20
    /  \
   15   7

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal
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
        int pre_idx = 0;
        int[] preorder;
        int[] inorder;
        Dictionary<int, int> dicinorder = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            this.preorder = preorder;
            this.inorder = inorder;

            for (int i = 0; i < inorder.Length; i++)
            {
                dicinorder.Add(inorder[i], i);
            }
            return Helper(0, inorder.Length);
        }

        private TreeNode Helper(int in_left, int in_right)
        {
            if (in_left == in_right) return null;
            int root_val = preorder[pre_idx];
            TreeNode root = new TreeNode(root_val);
            int index = dicinorder[root_val];
            pre_idx++;
            root.left = Helper(in_left, index);
            root.right = Helper(index + 1, in_right);
            return root;
        }
    }
}
