namespace Solutions.Array_LC
{
    public class Merge_Sorted_Array
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0)
                return;
            for (int i = 0; i < m; ++i)
            {
                if (nums1[i] > nums2[0])
                {
                    int temp = nums1[i];
                    nums1[i] = nums2[0];
                    nums2[0] = temp;
                    for (int j = 0; j < nums2.Length - 1; ++j)
                    {
                        if (nums2[j] > nums2[j + 1])
                        {
                            int temp2 = nums2[j];
                            nums2[j] = nums2[j + 1];
                            nums2[j + 1] = temp2;
                        }
                        else {
                            break;
                        }
                    }
                }
            }
            for (int i = m, j = 0; j < n; ++i, ++j)
            {
                nums1[i] = nums2[j];
            }
        }

        //Compare from the end
        public void Merge_1(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1, k = m + n - 1;
            while (i != -1 && j != -1)
            {
                if (nums1[i] >= nums2[j])
                    nums1[k--] = nums1[i--];
                else
                    nums1[k--] = nums2[j--];
            }
            while (j != -1)
                nums1[k--] = nums2[j--];
        }
    }
}
