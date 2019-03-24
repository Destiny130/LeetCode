using System.Linq;

namespace Solutions.Array_LC
{
    class Partition_Array_Into_Three_Parts_With_Equal_Sum
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            int sum = A.Sum();
            if (sum % 3 != 0)
                return false;
            sum /= 3;
            bool f = false, s = false;
            int temp = 0;
            foreach (int i in A)
            {
                temp += i;
                if (temp == sum)
                    f = true;
                if (f && temp == sum * 2)
                    s = true;
            }
            return f && s;
        }
    }
}
