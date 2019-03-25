using System;

namespace Solutions.String_LC
{
    public class String_to_Integer_atoi
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            char[] arr = str.Trim().ToCharArray();
            if (arr.Length == 0 || (!Char.IsNumber(arr[0]) && arr[0] != '+' && arr[0] != '-'))
                return 0;
            int result = 0;
            int factor = 1;
            bool first = arr[0] == '-' || arr[0] == '+';
            try
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (first && (arr[i] == '-' || arr[i] == '+'))
                    {
                        factor = arr[i] == '-' ? -1 : 1;
                        first = false;
                    }
                    else if (Char.IsNumber(arr[i]))
                    {
                        result = checked(result * 10 + ((int)arr[i] - 48));
                    }
                    else
                    {
                        break;
                    }
                    Console.WriteLine(result);
                }
            }
            catch
            {
                result = arr[0] == '-' ? Int32.MinValue : Int32.MaxValue;
            }
            return result * factor;
        }
    }
}
