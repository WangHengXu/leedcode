using System;
using System.Collections.Generic;
using System.Linq;
using TreeNodeNamespaces;

namespace MostFrequentSubtreeSum
{
    /*
     * 给出二叉树的根，找出出现次数最多的子树元素和。一个结点的子树元素和定义为以该结点为根的二叉树上所有结点的元素之和（包括结点本身）。然后求出出现次数最多的子树元素和。如果有多个元素出现的次数相同，返回所有出现次数最多的元素（不限顺序）。

 

示例 1
输入:

  5
 /  \
2   -3
返回 [2, -3, 4]，所有的值均只出现一次，以任意顺序返回所有值。

示例 2
输入:

  5
 /  \
2   -5
返回 [2]，只有 2 出现两次，-5 只出现 1 次。

 

提示： 假设任意子树元素和均可以用 32 位有符号整数表示。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/most-frequent-subtree-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int[] FindFrequentTreeSum(TreeNode root)
        {
            if (root == null) return new int[0];
            Helper(root);
            int[] res = dic.Where(x => x.Value == maxcount).Select(x => x.Key).ToArray();
            return res;
        }
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int maxcount = 0;
        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            int L = Helper(root.left);
            int R = Helper(root.right);
            int sum = L + R + root.val;
            if (dic.ContainsKey(sum))
            {
                dic[sum]++;
            }
            else
            {
                dic.Add(sum, 1);
            }
            maxcount = Math.Max(dic[sum], maxcount);
            return sum;
        }

    }
}
