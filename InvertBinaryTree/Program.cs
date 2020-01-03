using System;
using TreeNodeNamespaces;

namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            Helper(root);
            return root;

        }
        public void Helper(TreeNode root)
        {
            if (root == null) return;
            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            Helper(root.left);
            Helper(root.right);
        }
    }
}
