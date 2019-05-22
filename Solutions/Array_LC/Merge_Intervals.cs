using System;
using System.Collections.Generic;
using System.Linq;

namespace Solutions.Array_LC
{
    public class Merge_Intervals
    {
        /*
        Given a collection of intervals, merge all overlapping intervals.
        */

        public IList<Interval> Merge(IList<Interval> intervals)
        {
            IList<Interval> result = new List<Interval>();
            if (intervals == null || intervals.Count == 0)
                return result;
            intervals = intervals.OrderBy(i => i.start).ToList();
            int start = intervals[0].start, end = intervals[0].end;
            for (int i = 1; i < intervals.Count; ++i)
            {
                if (intervals[i].start <= end)
                {
                    end = Math.Max(end, intervals[i].end);
                }
                else
                {
                    result.Add(new Interval(start, end));
                    start = intervals[i].start;
                    end = intervals[i].end;
                }
            }
            result.Add(new Interval(start, end));
            return result;
        }

        public int[][] Merge(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            int len = 0;
            if (intervals == null || (len = intervals.Length) == 0)
                return result.ToArray();

            Array.Sort(intervals, (x, y) => x[0] - y[0]);
            int start = intervals[0][0], end = intervals[0][1];
            for (int i = 1; i < len; ++i)
            {
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
                }
                else
                {
                    result.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }
            result.Add(new int[] { start, end });
            return result.ToArray();
        }
    }

    public class Interval
    {
        public int start;
        public int end;

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
    }
}
