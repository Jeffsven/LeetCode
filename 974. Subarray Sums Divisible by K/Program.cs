using System.Collections;

namespace _974._Subarray_Sums_Divisible_by_K
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int subarraysDivByK(int[] nums, int k)
        {

            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            int prefixSum = 0;
            int ans = 0;
            hashMap.Add(0, 1);
            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum = (prefixSum + nums[i]) % k;
                if (prefixSum < 0) prefixSum += k;
                if (hashMap.ContainsKey(prefixSum))
                {
                    ans = ans + hashMap.GetValueOrDefault(prefixSum);
                    hashMap.Add(prefixSum, hashMap.GetValueOrDefault(prefixSum) + 1);
                }
                else
                {
                    hashMap.Add(prefixSum, 1);
                }

            }
            return ans;
        }
    }
}