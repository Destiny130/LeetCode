using System.Collections.Generic;

namespace Solutions.Math_LC
{
    public class Clumsy_Factorial
    {
        public int Clumsy(int N)
        {
            if (N < 3)
                return N;
            char[] arr = { '*', '/', '+', '-' };
            Queue<char> queue = new Queue<char>(arr);
            int result = N--;
            
            return result;
        }
    }
}
