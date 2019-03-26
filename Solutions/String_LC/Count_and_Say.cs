using System.Text;

namespace Solutions.String_LC
{
    public class Count_and_Say
    {
        public string CountAndSay(int n)
        {
            StringBuilder sb = new StringBuilder("1");
            int len = 1, count = 0;
            while (n-- > 1)
            {
                len = sb.Length;
                char curr = sb[0];
                //Read sb
                for (int i = 0; i < len; ++i)
                {
                    if (sb[i] != curr)
                    {
                        sb.Append(count.ToString());
                        sb.Append(curr);
                        count = 1;
                        curr = sb[i];
                    }
                    else
                    {
                        ++count;
                    }
                }
                if (count > 0)
                {
                    sb.Append(count.ToString());
                    sb.Append(curr);
                    count = 0;
                }
                sb.Remove(0, len);
                len = sb.Length;
            }
            return sb.ToString();
        }
    }
}
