using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.String_LC
{
    public class Basic_Calculator_II
    {
        /*
        Implement a basic calculator to evaluate a simple expression string.
        The expression string contains only non-negative integers, +, -, *, / operators and empty spaces . The integer division should truncate toward zero.
        */

        public int Calculate(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            char[] arr = s.ToCharArray();
            Stack<int> stack = new Stack<int>();
            char sign = '+';
            int num = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (Char.IsDigit(arr[i]))
                    num = num * 10 + (int)(arr[i] - '0');
                if (!Char.IsDigit(arr[i]) && arr[i] != ' ' || i == arr.Length - 1)
                {
                    switch (sign)
                    {
                        case '+':
                            stack.Push(num);
                            break;
                        case '-':
                            stack.Push(-num);
                            break;
                        case '*':
                            stack.Push(stack.Pop() * num);
                            break;
                        case '/':
                            stack.Push(stack.Pop() / num);
                            break;
                    }
                    sign = arr[i];
                    num = 0;
                }
            }
            return stack.Sum();
        }

        private static HashSet<char> signSet = new HashSet<char>("+-*/");

        public int Calculate_WithoutStack(string s)
        {
            int res = 0;
            if (string.IsNullOrWhiteSpace(s))
                return res;
            char sign = '+';
            char[] arr = s.ToCharArray();
            for (int i = 0, curr = 0, prev = 0; i < arr.Length; ++i)
            {
                if (Char.IsDigit(arr[i]))
                    curr = curr * 10 + (arr[i] - '0');
                if (signSet.Contains(arr[i]) || i == arr.Length - 1)
                {
                    if (sign == '+')
                        prev = curr;
                    else if (sign == '-')
                        prev = -curr;
                    else if (sign == '*')
                    {
                        res -= prev;
                        prev *= curr;
                    }
                    else
                    {
                        res -= prev;
                        prev /= curr;
                    }
                    sign = arr[i];
                    curr = 0;
                    res += prev;
                }
            }
            return res;
        }
    }
}
