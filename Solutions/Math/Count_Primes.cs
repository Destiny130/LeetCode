namespace Solutions.Math
{
    public class Count_Primes
    {
        public int CountPrimes(int n)
        {
            int count = 0;
            for (int i = 2; i < n; ++i)
                if (IsPrime(i))
                    count++;
            return count;
        }

        private bool IsPrime(int x)
        {
            for (int i = 2; i <= x / i; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }

        //Using array 1
        public int CountPrimes_1(int n)
        {
            bool[] arr = new bool[n];
            int count = 0;
            for (int i = 2; i < n; ++i)
            {
                if (!arr[i])
                {
                    count++;
                    for (int j = i; j <= (n - 1) / i; ++j)
                        arr[i * j] = true;
                }
            }
            return count;
        }

        //Using array 2
        public int CountPrimes_2(int n)
        {
            bool[] arr = new bool[n];
            int count = 0;
            for (int i = 2; i < n; ++i)
            {
                if (!arr[i])
                {
                    ++count;
                    for (int j = i; j < n; j += i)
                        arr[j] = true;
                }
            }
            return count;
        }
    }
}
