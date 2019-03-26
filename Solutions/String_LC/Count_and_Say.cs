using System.Text;

namespace Solutions.String_LC
{
    public class Count_and_Say
    {
        public string CountAndSay(int n)
        {
            StringBuilder sb = new StringBuilder("1");
            int len = 1;
            while (n-- > 1)
            {
                len = sb.Length;
                int count = 1;
                char curr = sb[0];
                for (int i = 1; i < len; ++i)
                {
                    if (sb[i] != curr)
                    {
                        sb.Append(count.ToString() + curr);
                        count = 1;
                        curr = sb[i];
                    }
                    else
                    {
                        ++count;
                    }
                }
                sb.Append(count.ToString() + curr);
                sb.Remove(0, len);
                len = sb.Length;
            }
            return sb.ToString();
        }
    }
}
