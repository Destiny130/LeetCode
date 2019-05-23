using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Sort_an_Array
    {
        /*
        Given an array of integers nums, sort the array in ascending order.
        */

        public int[] SortArray_SystemLibrary(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }

        public int[] SortArray_TopDown(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return nums;
            else if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                    Swap(nums, 0, 1);
                return nums;
            }

            int len = nums.Length, pivot = len >> 1;
            int[] leftArr = new int[pivot];
            int[] rightArr = (len & 1) == 1 ? new int[pivot + 1] : new int[pivot];
            Array.Copy(nums, leftArr, pivot);
            Array.Copy(nums, pivot, rightArr, 0, rightArr.Length);

            leftArr = SortArray_TopDown(leftArr);
            rightArr = SortArray_TopDown(rightArr);

            return Merge(leftArr, rightArr);
        }

        public int[] SortArray_BottomUp(int[] nums)
        {
            if (nums == null || nums.Length < 2)
                return nums;
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < nums.Length; ++i)
            {
                int[] arr = new int[1];
                Array.Copy(nums, i, arr, 0, 1);
                queue.Enqueue(arr);
            }
            while (queue.Count > 1)
            {
                int count = queue.Count;
                for (int i = 0; i < count; ++i)
                {
                    if (i != count - 1)
                    {
                        int[] firstArr = queue.Dequeue();
                        int[] secondArr = queue.Dequeue();
                        int[] mergeArr = Merge(firstArr, secondArr);
                        queue.Enqueue(mergeArr);
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                    }
                }
            }
            return queue.Dequeue();
        }

        private int[] Merge(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                result[k++] = arr1[i] <= arr2[j] ? arr1[i++] : arr2[j++];
            }
            while (i < arr1.Length)
                result[k++] = arr1[i++];
            while (j < arr2.Length)
                result[k++] = arr2[j++];
            return result;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
