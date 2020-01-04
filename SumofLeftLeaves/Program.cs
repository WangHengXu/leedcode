using System;
using TreeNodeNamespaces;

namespace SumofLeftLeaves
{
    /*
     * 计算给定二叉树的所有左叶子之和。

示例：

    3
   / \
  9  20
    /  \
   15   7

在这个二叉树中，有两个左叶子，分别是 9 和 15，所以返回 24

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/sum-of-left-leaves
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        int sum = 0;
        public int SumOfLeftLeaves(TreeNode root)
        {
            SumOfLeftLeaves2(root,false);
            return sum;
        }
     
        public void SumOfLeftLeaves2(TreeNode root,bool isleft)
        {
            if (root == null) return;
            if (isleft && root.left == null && root.right == null) sum += root.val;
        
            SumOfLeftLeaves2(root.left,true);
            SumOfLeftLeaves2(root.right,false);
        }
    }
}
