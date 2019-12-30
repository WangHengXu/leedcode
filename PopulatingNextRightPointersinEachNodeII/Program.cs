using System;
using System.Collections.Generic;

namespace PopulatingNextRightPointersinEachNodeII
{
    class Program
    {
        /*
       给定一个二叉树

struct Node {
  int val;
  Node *left;
  Node *right;
  Node *next;
}
填充它的每个 next 指针，让这个指针指向其下一个右侧节点。如果找不到下一个右侧节点，则将 next 指针设置为 NULL。

初始状态下，所有 next 指针都被设置为 NULL。

 

进阶：

你只能使用常量级额外空间。
使用递归解题也符合要求，本题中递归程序占用的栈空间不算做额外的空间复杂度。
 

示例：



输入：root = [1,2,3,4,5,null,7]
输出：[1,#,2,3,#,4,5,7,#]
解释：给定二叉树如图 A 所示，你的函数应该填充它的每个 next 指针，以指向其下一个右侧节点，如图 B 所示。
 

提示：

树中的节点数小于 6000
-100 <= node.val <= 100

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/populating-next-right-pointers-in-each-node-ii
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        */

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Node Connect(Node root)
        {
            if (root == null) return root;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int count = queue.Count;
                var first = queue.Dequeue();
                if (first.left != null) queue.Enqueue(first.left);
                if (first.right != null) queue.Enqueue(first.right);
                for (int i = 0; i < count - 1; i++)
                {
                    var temp = queue.Dequeue();
                    first.next = temp;
                    first = temp;
                    if (temp.left != null) queue.Enqueue(temp.left);
                    if (temp.right != null) queue.Enqueue(temp.right);

                }
            }
            return root;
        }
        public Node Connect2(Node root)
        {
            helper(root);
            return root;
        }
        public void helper(Node cur)
        {
            if (cur == null || cur.left == null) return;
            Node tmp = cur.left;
            while (cur != null)
            {
                cur.left.next = cur.right;
                if (cur.next != null)
                {
                    cur.right.next = cur.next.left;
                }
                cur = cur.next;
            }
            helper(tmp);
        }
    }
}
