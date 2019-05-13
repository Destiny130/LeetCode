namespace Solutions.Array_LC
{
    public class Find_the_Duplicate_Number
    {
        /*
        Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
        */

        public int FindDuplicate(int[] nums)
        {
            int slow = nums[0], fast = nums[nums[0]];
            while (fast != slow)
            {
                fast = nums[nums[fast]];
                slow = nums[slow];
            }
            fast = 0;
            while (fast != slow)
            {
                fast = nums[fast];
                slow = nums[slow];
            }
            return fast;
        }
    }
}
