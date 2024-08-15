namespace _540._Single_Element_in_a_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var res = new Solution().SingleNonDuplicate(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 });
        }
    }

    public class Solution
    {
        public int SingleNonDuplicate(int[] nums)
        {
            var groupSorted = nums.GroupBy(x => x);
            return groupSorted.First(x => x.Count() is 1).Key;
        }
    }
}