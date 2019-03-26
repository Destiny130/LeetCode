using System;
using System.Collections.Generic;

namespace Solutions.Design_LC
{
    /*
    Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
    push(x) -- Push element x onto stack.
    pop() -- Removes the element on top of the stack.
    top() -- Get the top element.
    getMin() -- Retrieve the minimum element in the stack.
    */

    public class Min_Stack
    {
        Stack<int> stack;
        int min;

        /** initialize your data structure here. */
        public Min_Stack()
        {
            this.stack = new Stack<int>();
            min = Int32.MaxValue;
        }

        public void Push(int x)
        {
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void Pop()
        {
            int curr = stack.Pop();
            if (curr == min)
            {
                min = stack.Pop();
            }
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return min;
        }
    }
}
