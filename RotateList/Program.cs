using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateList
{
    /*
     * 给定一个链表，旋转链表，将链表每个节点向右移动 k 个位置，其中 k 是非负数。

示例 1:

输入: 1->2->3->4->5->NULL, k = 2
输出: 4->5->1->2->3->NULL
解释:
向右旋转 1 步: 5->1->2->3->4->NULL
向右旋转 2 步: 4->5->1->2->3->NULL
示例 2:

输入: 0->1->2->NULL, k = 4
输出: 2->0->1->NULL
解释:
向右旋转 1 步: 2->0->1->NULL
向右旋转 2 步: 1->2->0->NULL
向右旋转 3 步: 0->1->2->NULL
向右旋转 4 步: 2->0->1->NULL
     * */
    public class ListNode
    {
        public int val;
        public ListNode next;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode a = new ListNode() { val = 1 };
            ListNode b = new ListNode() { val = 2 };
            ListNode c = new ListNode() { val = 3 };
            ListNode d = new ListNode() { val = 4 };
            ListNode e = new ListNode() { val = 5 };
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            ListNode t = rotateRight(a, 6);
            while(t!=null)
            {
                Console.Write($"{t.val},");
                t = t.next;
            }
            Console.Read();

        }
        public static ListNode rotateRight(ListNode head, int k)
        {
            if (head == null)
                return head;
            ListNode reHead = head;
        c: ListNode node = reHead;
            head = reHead;
            int count = 0;

         while (head != null)
            {
                if(k==0)
                {
                    return head;
                }
                if (head.next == null &&count==k)
                {
                    ListNode temp = node.next;
                    head.next = reHead;
                    node.next = null;
                    return temp;
                }
                if (count == k)
                {
                    node = node.next;
                }
                if (count < k)
                    count++;
                head = head.next;
            }
            k = k % count;
            goto c;
      
            return reHead;
        }
    }
}
