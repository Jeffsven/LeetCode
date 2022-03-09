using System;
using System.Linq;
using System.Collections.Generic;

namespace _15._3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 34, 55, 79, 28, 46, 33, 2, 48, 31, -3, 84, 71, 52, -3, 93, 15, 21, -43, 57, -6, 86, 56, 94, 74, 83, -14, 28, -66, 46, -49, 62, -11, 43, 65, 77, 12, 47, 61, 26, 1, 13, 29, 55, -82, 76, 26, 15, -29, 36, -29, 10, -70, 69, 17, 49 };
            var res = new Solution().ThreeSum(input);
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            nums = nums.OrderBy(x => x).ToArray();

            //Arrays.sort(nums);

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {              // skip same result
                    continue;
                }
                int j = i + 1, k = nums.Length - 1;
                int target = -nums[i];
                while (j < k)
                {
                    if (nums[j] + nums[k] == target)
                    {
                        //res.add(Arrays.asList(nums[i], nums[j], nums[k]));
                        res.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1]) j++;  // skip same result
                        while (j < k && nums[k] == nums[k + 1]) k--;  // skip same result
                    }
                    else if (nums[j] + nums[k] > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return res;
        }

        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    var result = Combination(nums)
        //        .Where(x => x.Length is 3)
        //        .Where(x => x.Sum() is 0)
        //        .Select(x => (IList<int>)x.OrderBy(y => y))
        //        .Select(x => string.Join(',', x))
        //        .Distinct()
        //        .Select(x => x.Split(',').Select(y => int.Parse(y)).ToList())
        //        .Select(x => (IList<int>)x)
        //        .ToList();

        //    return (IList<IList<int>>)result;
        //}

        //public IEnumerable<T[]> Combination<T>(IEnumerable<T> source)
        //{
        //    T[] data = source.ToArray();

        //    return Enumerable.Range(0, 1 << (data.Length))
        //        .Select(index => data
        //        .Where((v, i) => (index & (1 << i)) != 0)
        //        .ToArray());
        //}
    }
}
