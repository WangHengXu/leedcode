using System;
using System.Collections.Generic;

namespace ImplementStackusingQueues
{
    /*
     * 使用队列实现栈的下列操作：


	push(x) -- 元素 x 入栈
	pop() -- 移除栈顶元素
	top() -- 获取栈顶元素
	empty() -- 返回栈是否为空


注意:


	你只能使用队列的基本操作-- 也就是 push to back, peek/pop from front, size, 和 is empty 这些操作是合法的。
	你所使用的语言也许不支持队列。 你可以使用 list 或者 deque（双端队列）来模拟一个队列 , 只要是标准的队列操作即可。
	你可以假设所有操作都是有效的（例如, 对一个空的栈不会调用 pop 或者 top 操作）。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/implement-stack-using-queues
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    public class MyStack
    {
        Queue<int> queuepush;
        Queue<int> queuepop;
        public MyStack()
        {
            queuepush = new Queue<int>();
            queuepop = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
           // if (x == null) return;
            if (queuepop.Count > 0)
            {
                queuepush.Enqueue(queuepop.Dequeue());
            }
            queuepop.Enqueue(x);
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            if (Empty())
            {
                return -1;
            }
            int res = (int)queuepop.Dequeue();
            while (queuepush.Count>1)
            {
                queuepop.Enqueue(queuepush.Dequeue());
            }
            if(queuepush.Count>0)
            {
                int temp = queuepush.Dequeue();

                while (queuepop.Count > 0)
                {
                    queuepush.Enqueue(queuepop.Dequeue());
                }
                queuepop.Enqueue(temp);
            }
         
            return res;
        }

        /** Get the top element. */
        public int Top()
        {
            if (Empty())
            {
                return -1;
            }
            return (int)queuepop.Peek();
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return queuepop.Count == 0&& queuepush.Count==0;
        }
    }
}
