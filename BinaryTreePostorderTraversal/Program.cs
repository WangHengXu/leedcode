using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace BinaryTreePostorderTraversal
{
    class Program
    {
        /*
         * 给定一个二叉树，返回它的 后序 遍历。

示例:

输入: [1,null,2,3]  
   1
    \
     2
    /
   3 

输出: [3,2,1]
进阶: 递归算法很简单，你可以通过迭代算法完成吗？

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-tree-postorder-traversal
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            Helper(root, list);
            return list;

        }
        public void Helper(TreeNode root, IList<int> list)
        {
            if (root == null) return;
            Helper(root.left, list);
            Helper(root.right, list);
            list.Add(root.val);

        }

        public IList<int> PostorderTraversal2(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count>0)
            {
                var temp = stack.Pop();
                if (temp.left != null) stack.Push(temp.left);
                if (temp.right != null) stack.Push(temp.right);
                if (list.Count == 0) list.Add(temp.val);
                else list.Insert(0, temp.val);

            }

            return list;

        }
    }
}
