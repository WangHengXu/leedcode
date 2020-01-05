using System;
using System.Collections;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace FindBottomLeftTreeValue
{
    /*
     * 给定一个二叉树，在树的最后一行找到最左边的值。

示例 1:

输入:

    2
   / \
  1   3

输出:
1
 

示例 2:

输入:

        1
       / \
      2   3
     /   / \
    4   5   6
       /
      7

输出:
7
 

注意: 您可以假设树（即给定的根节点）不为 NULL。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/find-bottom-left-tree-value
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int FindBottomLeftValue(TreeNode root)
        {
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            int res = 0;
            while (treeNodes.Count>0)
            {
                var temp = treeNodes.Dequeue();
                res = temp.val;
                int lenth = treeNodes.Count;
                if (temp.left != null) treeNodes.Enqueue(temp.left);
                if (temp.right != null) treeNodes.Enqueue(temp.right);
                for (int i = 0; i < lenth; i++)
                {
                    var temp2 = treeNodes.Dequeue();
                    if (temp2.left != null) treeNodes.Enqueue(temp2.left);
                    if (temp2.right != null) treeNodes.Enqueue(temp2.right);
                }
            }
            return res;
        }
    }
}
