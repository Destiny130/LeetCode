namespace Solutions.Array_LC
{
    public class Flipping_an_Image
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            int[][] result = new int[A.Length][];
            for (int i = 0; i < A.Length; ++i)
            {
                int[] arr = new int[A[i].Length];
                for (int j = arr.Length - 1; j != -1; --j)
                    arr[arr.Length - 1 - j] = A[i][j] ^ 1;
                result[i] = arr;
            }
            return result;
        }

        private void Reverse(int[] arr)
        {
            int low = 0, high = arr.Length - 1;
            while (low < high)
            {
                arr[low] ^= arr[high];
                arr[high] ^= arr[low];  //low;
                arr[low] ^= arr[high];  //high
            }
        }
    }
}
