namespace _2958._Length_of_Longest_Subarray_With_at_Most_K_Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 1, 2, 3, 1, 2 };
            new Solution().MaxSubarrayLength(nums, 2);
        }
    }


    public class Solution
    {
        public int MaxSubarrayLength(int[] nums, int k)
        {
            var a = nums.GroupBy(x => nums[x]).ToList();
            return 0;
        }
    }
}