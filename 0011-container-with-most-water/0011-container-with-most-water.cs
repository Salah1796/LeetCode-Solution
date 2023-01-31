public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int right = height.Length - 1;
        int left = 0;
        while (left < right)
        {
            var area = Math.Min(height[left], height[right]) * (right - left);
            if (area > maxArea) maxArea = area;
            if (height[left] < height[right]) left++;
            else right--;
        }
        return maxArea;
    }
}