using System;
using System.Collections.Generic;

namespace Solutions.Array_LC
{
    public class Sort_an_Array
    {
        /*
        Given an array of integers nums, sort the array in ascending order.
        */

        //Using system library
        public int[] SortArray_SystemLibrary(int[] nums)
        {
            Array.Sort(nums);
            return nums;
        }

        //Devide and conquer, top down
        public int[] SortArray_TopDown(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums;
            }
            else if (nums.Length == 2)
            {
                if (nums[0] > nums[1])
                {
                    Swap(nums, 0, 1);
                }

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

        //Devide and conquer, bottom up
        public int[] SortArray_BottomUp(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums;
            }

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
            {
                result[k++] = arr1[i++];
            }

            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }

        //Quick sort, using extra space
        public int[] SortArray_QuickSort(int[] nums)
        {
            if (nums == null || nums.Length < 2)
            {
                return nums;
            }

            int pivot = nums[0];
            List<int> leftList = new List<int>(), rightList = new List<int>();
            for (int i = 1; i < nums.Length; ++i)
            {
                int val = nums[i];
                if (val <= pivot)
                {
                    leftList.Add(val);
                }
                else
                {
                    rightList.Add(val);
                }
            }

            int[] leftArr = SortArray_QuickSort(leftList.ToArray());
            int[] rightArr = SortArray_QuickSort(rightList.ToArray());
            return Merge(leftArr, pivot, rightArr);
        }

        private int[] Merge(int[] arr1, int pivot, int[] arr2)
        {
            int[] result = new int[arr1.Length + 1 + arr2.Length];
            int i = 0, j = 0, k = 0;
            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            result[k++] = pivot;
            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }

        //Quick sort, modify original array
        public int[] SortArray_QuickSort_Swap(int[] nums)
        {
            if (nums == null)
            {
                return nums;
            }

            Partition(nums, 0, nums.Length - 1);
            return nums;
        }

        private void Partition(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pivot = QuickSort(nums, low, high);
                Partition(nums, low, pivot - 1);
                Partition(nums, pivot + 1, high);
            }
        }

        private int QuickSort(int[] nums, int low, int high)
        {
            int pivot = nums[high];
            int i = low;
            for (int j = low; j < high; ++j)
            {
                if (nums[j] < pivot)
                {
                    Swap(nums, i++, j);
                }
            }
            Swap(nums, i, high);
            return i;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

    }
}
