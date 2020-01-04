using System;
using TreeNodeNamespaces;

namespace PathSumIII
{
    /*
     * 给定一个二叉树，它的每个结点都存放着一个整数值。

找出路径和等于给定数值的路径总数。

路径不需要从根节点开始，也不需要在叶子节点结束，但是路径方向必须是向下的（只能从父节点到子节点）。

二叉树不超过1000个节点，且节点数值范围是 [-1000000,1000000] 的整数。

示例：

root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

      10
     /  \
    5   -3
   / \    \
  3   2   11
 / \   \
3  -2   1

返回 3。和等于 8 的路径有:

1.  5 -> 3
2.  5 -> 2 -> 1
3.  -3 -> 11

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/path-sum-iii
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int PathSum(TreeNode root, int sum)
        {
            return Helper(root, sum, new int[1000], 0);
        }
        public int Helper(TreeNode treeNode, int sum, int[] ary,int p)
        {
            if (treeNode == null) return 0;
            int temp = treeNode.val;
            int n = temp == sum ? 1 : 0;
            for (int i = p-1; i >=0; i--)
            {
                temp += ary[i];
                if (temp == sum)
                {
                    n++;
                }
            }
            ary[p] = treeNode.val;
            int L = Helper(treeNode.left, sum, ary, p + 1);
            int R = Helper(treeNode.right, sum, ary, p + 1);
            return n + L + R;
        }
    }
}
