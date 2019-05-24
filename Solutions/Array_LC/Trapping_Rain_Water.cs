using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Trapping_Rain_Water
    {
        /*
        Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        */

        public int Trap_BF(int[] height)
        {
            if (height == null || height.Length < 3)
            {
                return 0;
            }

            int water = 0, len = height.Length;
            for (int i = 1; i < len - 1; ++i)
            {
                int maxL = 0, maxR = 0;
                for (int j = i; j >= 0; --j)
                {
                    maxL = Math.Max(maxL, height[j]);
                }

                for (int j = i; j < len; ++j)
                {
                    maxR = Math.Max(maxR, height[j]);
                }

                water += Math.Min(maxL, maxR) - height[i];
            }
            return water;
        }

        public int Trap_DP(int[] height)
        {
            if (height == null || height.Length < 3)
            {
                return 0;
            }

            int water = 0, len = height.Length;
            int[] leftArr = new int[len], rightArr = new int[len];
            leftArr[0] = height[0];
            rightArr[len - 1] = height[len - 1];
            for (int i = 1; i < len; ++i)
            {
                leftArr[i] = Math.Max(height[i], leftArr[i - 1]);
            }

            for (int i = len - 2; i >= 0; --i)
            {
                rightArr[i] = Math.Max(height[i], rightArr[i + 1]);
            }

            for (int i = 0; i < len; ++i)
            {
                water += Math.Min(leftArr[i], rightArr[i]) - height[i];
            }

            return water;
        }

        public int Trap_Stack(int[] height)
        {
            if (height == null || height.Length < 3)
            {
                return 0;
            }

            int water = 0, len = height.Length, i = 0;
            Stack<int> stack = new Stack<int>();
            while (i < len)
            {
                while (stack.Count != 0 && height[i] > height[stack.Peek()])
                {
                    int p = stack.Pop();
                    if (stack.Count == 0)
                    {
                        break;
                    }

                    int dis = i - stack.Peek() - 1;
                    int temp = Math.Min(height[i], height[stack.Peek()]) - height[p];
                    water += dis * temp;
                }
                stack.Push(i++);
            }
            return water;
        }

        public int Trap_TwoPoints(int[] height)
        {
            if (height == null || height.Length < 3)
            {
                return 0;
            }

            int water = 0, low = 0, high = height.Length - 1;
            int maxL = 0, maxR = 0;
            while (low < high)
            {
                if (height[low] < height[high])
                {
                    if (height[low] >= maxL)
                    {
                        maxL = height[low++];
                    }
                    else
                    {
                        water += maxL - height[low++];
                    }
                }
                else
                {
                    if (height[high] >= maxR)
                    {
                        maxR = height[high--];
                    }
                    else
                    {
                        water += maxR - height[high--];
                    }
                }
            }
            return water;
        }
    }
}
