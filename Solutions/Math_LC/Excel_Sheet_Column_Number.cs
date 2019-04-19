using System;

namespace Solutions.Math_LC
{
    public class Excel_Sheet_Column_Number
    {
        public int TitleToNumber(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            char[] arr = s.ToCharArray();
            int result = 0, len = arr.Length;
            for (int i = 0; i < len; ++i)
            {
                int factor = (int)Math.Pow(26, len - i - 1);
                result += (arr[i] - 'A' + 1) * factor;
            }
            return result;
        }
    }
}
