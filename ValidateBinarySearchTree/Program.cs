﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateBinarySearchTree
{
    /* 给定一个二叉树，判断其是否是一个有效的二叉搜索树。

 假设一个二叉搜索树具有如下特征：

 节点的左子树只包含小于当前节点的数。
 节点的右子树只包含大于当前节点的数。
 所有左子树和右子树自身必须也是二叉搜索树。
 示例 1:

 输入:
     2
    / \
   1   3
 输出: true
 示例 2:

 输入:
     5
    / \
   1   4
      / \
     3   6
 输出: false
 解释: 输入为: [5,1,4,null,null,3,6]。
      根节点的值为 5 ，但是其右子节点值为 4 。*/
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static  bool IsValidBST(TreeNode root)
        {

            return Update(root);
        }
        public static bool Update(TreeNode root,int? lower=null,int? upper=null)
        {
            if (root == null) return true;
            int val = root.val;
            if (lower != null && val<=lower)
            {
                return false;
            }
            if (upper != null && val >=upper)
            {
                return false;
            }
            if (!(Update(root.right, val, upper))) return false;

            if (!(Update(root.left, lower, val))) return false;

            return true;
        }
    }
}
