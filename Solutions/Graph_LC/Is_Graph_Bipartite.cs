using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Graph_LC
{
    public class Is_Graph_Bipartite
    {
        public bool IsBipartite(int[][] graph)
        {
            int len = graph.Length;
            int[] colors = new int[len];

            for (int i = 0; i < len; ++i)
            {
                if (colors[i] != 0)
                {
                    continue;
                }
                colors[i] = 1;
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(i);
                while (queue.Count != 0)
                {
                    int curr = queue.Dequeue();
                    int val = colors[curr];
                    int[] arr = graph[curr];
                    foreach (int j in arr)
                    {
                        if (colors[j] == 0)
                        {
                            colors[j] = -val;
                            queue.Enqueue(j);
                        }
                        else if (colors[j] != -val)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
