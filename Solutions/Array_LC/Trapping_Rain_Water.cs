using System;

namespace Solutions.Array_LC
{
    public class Trapping_Rain_Water
    {
        /*
        Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
        */

        public int Trap(int[] height)
        {
            if (height == null || height.Length < 3)
                return 0;
            int len = height.Length, water = 0;
            for (int i = 0; i < len;)
            {
                while (i < len - 1 && height[i] <= height[i + 1])
                    ++i;
                if (i == len - 1)
                    break;
                int j = i + 2;
                while (j < len - 1 && height[j] <= height[j + 1])
                    ++j;
                if (j == len - 1 && height[j] <= height[i + 1])
                {
                    if (height[j + 1] <= height[i + 1])
                        break;
                    else
                        ++j;
                }
                water += Water(height, i, j);
            }
            return water;
        }

        public int Trap_DP (int[] height)
        {
            return Trap_DP(height, 0, height.Length - 1);
        }

        private int Trap_DP(int[] height, int low, int high)
        {
            Console.WriteLine($"low: {low}, high: {high}");
            if (low < 0 || high >= height.Length || high - low < 2)
                return 0;
            int i = low, j = high, water = 0;
            int start = low, end = high;
            while (start + 1 < end)
            {
                if (height[start] == 0 || height[start] == height[start + 1])
                    ++start;
                else if (height[end] == 0 || height[end] == height[end - 1])
                    --end;
                else {
                    int temp = Water(height, start, end);
                    if (temp > water)
                    {
                        i = start;
                        j = end;
                        water = temp;
                    }
                    if (height[start] > height[end])
                        --end;
                    else
                        ++start;
                }
            }
            Console.WriteLine($"water: {water}");
            return Trap_DP(height, low, i) + water + Trap_DP(height, j, high);
        }

        private int Water(int[] height, int low, int high)
        {
            int min = Math.Min(height[low], height[high]);
            int water = 0;
            for (int i = low + 1; i < high; ++i)
            {
                water += Math.Max(0, min - height[i]);
            }
            return water;
        }
    }
}
