using System.Collections.Generic;

namespace Solutions.Stack_LC
{
    public class Valid_Parentheses
    {
        /*
        Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
        Open brackets must be closed by the same type of brackets.
        Open brackets must be closed in the correct order.
        Note that an empty string is also considered valid.
        */

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    else if (!Com(c, stack.Pop()))
                        return false;
                }
                else
                    stack.Push(c);
            }
            return stack.Count == 0;
        }

        private bool Com(char a, char b)
        {
            if (a == ')')
                return b == '(';
            else if (a == ']')
                return b == '[';
            else
                return b == '{';
        }

        public bool IsValid_1(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '[')
                    stack.Push(']');
                else if (c == '{')
                    stack.Push('}');
                else if (stack.Count == 0 || c != stack.Pop())
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
