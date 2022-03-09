using System;

namespace _1413._Minimum_Value_to_Get_Positive_Step_by_Step_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var input = new int[] { -3, 2, -3, 4, 2 };

            var res = new Solution().MinStartValue(input);
        }
    }

    public class Solution
    {
        public int MinStartValue(int[] nums)
        {
            int startvalue = 0;

            while (true)
            {
                int step = ++startvalue;

                bool check = true;
                for (int i = 0; i < nums.Length; i++)
                {
                    step += nums[i];
                    if (step < 1)
                    {
                        check = false;
                        break;
                    }
                }
                if (check) break;
            }

            return startvalue;
        }
    }
}
