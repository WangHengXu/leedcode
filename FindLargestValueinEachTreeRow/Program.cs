using System;
using System.Collections.Generic;
using System.Linq;
using TreeNodeNamespaces;

namespace FindLargestValueinEachTreeRow
{
    /*
     * 您需要在二叉树的每一行中找到最大的值。

示例：

输入: 

          1
         / \
        3   2
       / \   \  
      5   3   9 

输出: [1, 3, 9]

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/find-largest-value-in-each-tree-row
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public IList<int> LargestValues(TreeNode root)
        {
            if (root == null) return new List<int>();
            List<int> resList = new List<int>();
            Queue<TreeNode> treeNodes = new Queue<TreeNode>();
            treeNodes.Enqueue(root);
            while (treeNodes.Count>0)
            {
                int length = treeNodes.Count;
                List<int> tempList = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    var tem = treeNodes.Dequeue();
                    if (tem.left != null) treeNodes.Enqueue(tem.left);
                    if (tem.right != null) treeNodes.Enqueue(tem.right);
                    tempList.Add(tem.val);
                }
                resList.Add(tempList.Max());
            }
            return resList;
        }
    }
}
