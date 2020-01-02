using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace BinaryTreePreorderTraversal
{
    /*
     * 给定一个二叉树，返回它的 前序 遍历。

 示例:

输入: [1,null,2,3]  
   1
    \
     2
    /
   3 

输出: [1,2,3]
进阶: 递归算法很简单，你可以通过迭代算法完成吗？

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-preorder-traversal
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            Helper(root, list);
            return list;
        }
        public void Helper(TreeNode treeNode, IList<int> list)
        {
            if (treeNode == null) return;
            list.Add(treeNode.val);
            Helper(treeNode.left, list);
            Helper(treeNode.right, list);
        }
        /// <summary>
        /// 迭代
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PreorderTraversal2(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode CurNode = root;
  
            stack.Push(root);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                if (temp.right != null) stack.Push(temp.right);
                if (temp.left != null) stack.Push(temp.left);
                list.Add(temp.val);

            }
            return list;
        }
    }
}
