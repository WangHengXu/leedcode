using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectList
{
    /*
    反转一个单链表。

示例:

输入: 1->2->3->4->5->NULL
输出: 5->4->3->2->1->NULL

进阶:
你可以迭代或递归地反转链表。你能否用两种方法解决这道题？

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/reverse-linked-list
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */

    public class ListNode
    {
        public ListNode next;
        public int val;
        public ListNode(int x) { val = x; }
  }
    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null, t = null;

            while (head != null)
            {
                t = head.next;
                head.next = pre;
                pre = head;
                head = t;
            }
            return pre;

        }
    }
}
