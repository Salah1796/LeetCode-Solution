public class Solution
{
    //O(N)
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        int sum = 0;
        int[] result = new int[2];
        while (left != right)
        {
            sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                result = new int[] { left + 1, right + 1 };
                break;
            }
            else if (sum > target) right--;
            else left++;
        }
        return result;
    }
}