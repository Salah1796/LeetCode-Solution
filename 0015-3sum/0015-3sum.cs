public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var reult = new List<IList<int>>();
        int left, right;
        int sum = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            left = i + 1;
            right = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1]) continue; //skip dublicat triple
            while (left < right)
            {
                sum = nums[i] + nums[left] + nums[right];
                if (sum > 0) right--;
                else if (sum < 0) left++;
                else
                {
                    reult.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    left++;
                    right--;
                    //skip dublicat left &  right pointer values
                    while (nums[left] == nums[left - 1] & left < right) left++;
                    while (nums[right] == nums[right + 1] & left < right) right--;
                }
            }
        }
        return reult;
    }
}
/*
  Time Complexity = O(N^2)
  Space Complexity = O(N)
*/