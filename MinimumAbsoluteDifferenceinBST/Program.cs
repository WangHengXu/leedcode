using System;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace MinimumAbsoluteDifferenceinBST
{
    /*
     * 给定一个所有节点为非负值的二叉搜索树，求树中任意两节点的差的绝对值的最小值。

示例 :

输入:

   1
    \
     3
    /
   2

输出:
1

解释:
最小绝对差为1，其中 2 和 1 的差的绝对值为 1（或者 2 和 3）。
注意: 树中至少有2个节点。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/minimum-absolute-difference-in-bst
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TreeNode treeNode0 = new TreeNode(0);
            TreeNode treeNode2236 = new TreeNode(2236);
            TreeNode treeNode1277 = new TreeNode(1277);
            TreeNode treeNode2776 = new TreeNode(2776);
            TreeNode treeNode519 = new TreeNode(519);

            treeNode0.right = treeNode2236;
            treeNode2236.left = treeNode1277;
            treeNode2236.right = treeNode2776; ;
            treeNode1277.left = treeNode519;
            GetMinimumDifference(treeNode0);

        }
        public static int GetMinimumDifference(TreeNode root)
        {

            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            TreeNode cur = root;
            int min = int.MaxValue;
            int preVal = -1;
            while (cur!=null||treeNodes.Count>0)
            {
                while (cur!=null)
                {
                    treeNodes.Push(cur);
                    cur = cur.left;
                }
                cur = treeNodes.Pop();
                if (preVal >= 0)
                {
                    min = Math.Min(min, cur.val - preVal);
                }
                preVal = cur.val;
                cur = cur.right;
            }
            return min;
        }
    }
}
