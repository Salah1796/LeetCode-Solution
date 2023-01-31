public class Solution
{
    //O(N)
    public int RemoveDuplicates(int[] nums)
    {
        int left = 0;
        for (int right = 1; right < nums.Length; right++)
        {
            if (nums[right] != nums[left]) nums[++left] = nums[right];
        }
        return left + 1;
    }
}