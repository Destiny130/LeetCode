using System;

namespace Solutions.Array_LC
{
    public class Container_With_Most_Water
    {

        /*
        Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
        Note: You may not slant the container and n is at least 2.
        */

        public int MaxArea(int[] height)
        {
            int water = 0;
            int i = 0, j = height.Length - 1;
            while (i < j)
            {
                water = Math.Max(water, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] < height[j])
                {
                    ++i;
                }
                else
                {
                    --j;
                }
            }
            return water;
        }
    }
}
