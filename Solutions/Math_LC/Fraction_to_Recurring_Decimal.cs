using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Math_LC
{
    public class Fraction_to_Recurring_Decimal
    {
        public string FractionToDecimal(int numerator, int denominator)
        {
            if (numerator == 0)
                return "0";
            StringBuilder sb = new StringBuilder();
            if ((numerator < 0) ^ (denominator < 0))
                sb.Append("-");
            long num = Math.Abs((long)numerator), den = Math.Abs((long)denominator);
            sb.Append(num / den);
            num %= den;
            if (num == 0)
                return sb.ToString();

            sb.Append(".");
            Dictionary<long, int> dic = new Dictionary<long, int>();
            dic[num] = sb.Length;
            while (num != 0)
            {
                num *= 10;
                sb.Append(num / den);
                num %= den;
                if (dic.ContainsKey(num))
                {
                    sb.Insert(dic[num], "(");
                    sb.Append(")");
                    break;
                }
                else {
                    dic[num] = sb.Length;
                }
            }
            return sb.ToString();
        }
    }
}
