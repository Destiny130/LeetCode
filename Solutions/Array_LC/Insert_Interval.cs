using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Insert_Interval
    {
        /*
        Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
        You may assume that the intervals were initially sorted according to their start times.
        */

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int len = 0;
            List<int[]> list = new List<int[]>();
            if (intervals == null || (len = intervals.Length) == 0)
            {
                list.Add(newInterval);
                return list.ToArray();
            }
            list.AddRange(intervals);
            int low = 0, high = len;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (mid == -1 || mid == len)
                {
                    break;
                }

                if (list[mid][0] > newInterval[0])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            list.Insert(low, newInterval);
            List<int[]> result = new List<int[]>();
            int start = list[0][0], end = list[0][1];
            for (int i = 1; i < list.Count; ++i)
            {
                if (list[i][0] <= end)
                {
                    end = Math.Max(end, list[i][1]);
                }
                else
                {
                    result.Add(new int[] { start, end });
                    start = list[i][0];
                    end = list[i][1];
                }
            }
            result.Add(new int[] { start, end });
            return result.ToArray();
        }

        public int[][] Insert_OneLoop(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new List<int[]>();
            if (intervals == null || intervals.Length == 0)
            {
                result.Add(newInterval);
                return result.ToArray();
            }
            int i = 0, len = intervals.Length;
            while (i < len && intervals[i][1] < newInterval[0])
            {
                result.Add(intervals[i++]);
            }

            while (i < len && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i++][1]);
            }
            result.Add(newInterval);

            while (i < len)
            {
                result.Add(intervals[i++]);
            }

            return result.ToArray();
        }
    }
}
