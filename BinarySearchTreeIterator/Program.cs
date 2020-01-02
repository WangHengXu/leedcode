using System;
using System.Collections;
using System.Collections.Generic;
using TreeNodeNamespaces;

namespace BinarySearchTreeIterator
{
    /*
     * 实现一个二叉搜索树迭代器。你将使用二叉搜索树的根节点初始化迭代器。

调用 next() 将返回二叉搜索树中的下一个最小的数。

 

示例：



BSTIterator iterator = new BSTIterator(root);
iterator.next();    // 返回 3
iterator.next();    // 返回 7
iterator.hasNext(); // 返回 true
iterator.next();    // 返回 9
iterator.hasNext(); // 返回 true
iterator.next();    // 返回 15
iterator.hasNext(); // 返回 true
iterator.next();    // 返回 20
iterator.hasNext(); // 返回 false
 

提示：

next() 和 hasNext() 操作的时间复杂度是 O(1)，并使用 O(h) 内存，其中 h 是树的高度。
你可以假设 next() 调用总是有效的，也就是说，当调用 next() 时，BST 中至少存在一个下一个最小的数。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/binary-search-tree-iterator
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class BSTIterator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        Queue<int> queue = new Queue<int>();
        public BSTIterator(TreeNode root)
        {
            InorderTraversal(root);
        }
        private void InorderTraversal(TreeNode root)
        {
            if (root == null) return;
            InorderTraversal(root.left);
            queue.Enqueue(root.val);
            InorderTraversal(root.right);
        }
        Stack<TreeNode> treeNodes = new Stack<TreeNode>();
        TreeNode cur = null;
        public int Next()
        {
            return queue.Dequeue();
        }
        public int Next2()
        {
            int res = -1;
            while (cur != null || treeNodes.Count > 0)
            {
                while (cur!=null)
                {
                    treeNodes.Push(cur);
                    cur = cur.left;
                }
                cur = treeNodes.Pop();
                res = cur.val;
                cur = cur.right;
                break;
            }
            return res;
        }


        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return queue.Count > 0;
        }
    }
}
