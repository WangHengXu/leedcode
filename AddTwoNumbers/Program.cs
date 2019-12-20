using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    /*
     给定两个非空链表来表示两个非负整数。位数按照逆序方式存储，它们的每个节点只存储单个数字。将两数相加返回一个新的链表。

你可以假设除了数字 0 之外，这两个数字都不会以零开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807
         
         */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            ListNode a1 = new ListNode(4);
            ListNode b1 = new ListNode(3);
            l1.next = a1;
            a1.next = b1;

            ListNode l2 = new ListNode(5);
            ListNode a2 = new ListNode(6);
            ListNode b2 = new ListNode(4);
            l2.next = a2;
            a2.next = b2;
           ListNode result=  AddTwoNumbers(l1, l2);
            while(result.next!=null)
            {
                Console.Write($"{result.next.val},");
                result = result.next;
            }
            Console.Read();
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode p = l1, q = l2, result = new ListNode(0);
            int carry = 0;
            ListNode current = result;
            while (p != null || q != null)      
            {
                int x = p == null ? 0 : p.val;
                int y = q == null ? 0 : q.val;
                int sum = x + y + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;

            }
            if (carry >0)
            {
                current.next = new ListNode(carry);
            }
            return result.next;
        }
    }
}
