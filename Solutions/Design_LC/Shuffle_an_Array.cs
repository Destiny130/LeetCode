using System;

namespace Solutions.Design_LC
{
    /*
    Shuffle a set of numbers without duplicates.
    */

    public class Shuffle_an_Array
    {
        private int[] nums;
        private Random random;

        public Shuffle_an_Array(int[] nums)
        {
            this.nums = nums;
            this.random = new Random();
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return nums;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            if (nums == null)
                return null;
            int[] a = nums.Clone() as int[];  //new int[nums.Length];
                                              // for(int i = 0; i < a.Length; ++i)
                                              //     a[i] = nums[i];
            for (int i = 1; i < a.Length; ++i)
            {
                int r = random.Next(i + 1);
                int temp = a[i];
                a[i] = a[r];
                a[r] = temp;
            }
            return a;
        }
    }
}
