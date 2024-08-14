public class Solution{
    public int[] TwoSum(int[] nums, int target){
        Dictionary<int, int> dict - new();
        for (int- 0; i < nums.Length; i++)
        {
            int complement - target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { direct[complement], i };
            }
            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }
        throw new ArgumentException("No solution");
    }

}