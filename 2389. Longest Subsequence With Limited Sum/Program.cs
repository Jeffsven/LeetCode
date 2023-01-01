namespace _2389._Longest_Subsequence_With_Limited_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 5, 2, 1 };
            int[] queries = { 3, 10, 21 };
            Console.WriteLine(new Solution().AnswerQueries(nums, queries));
        }
    }

    public class Solution
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            int[] answer = new int[queries.Length];

            for (int q = 0; q < queries.Length; q++)
            {
                int max = 0;
                int sum = 0;

                for (int n = 0; n < nums.Length; n++)
                {
                    if (nums[n] <= queries[q])
                    {
                        max++;
                        answer[q] = Math.Max(answer[q], max);
                        continue;
                    }
                    max = 0;
                }

            }
            return answer;
        }
    }
}