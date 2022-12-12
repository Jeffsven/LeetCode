namespace _6263._Frog_Jump_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MaxJump(new int[] { 0, 2, 5, 6, 7 }));
        }
    }

    public class Solution
    {
        public int MaxJump(int[] stones)
        {
            return ReturnSteps(stones.ToList());

        }

        private int ReturnSteps(List<int> stones)
        {
            var tempS = new List<int>(stones);
            int min = 0;
            for (int i = 0; i < tempS.Count; i++)
            {
                tempS.RemoveAt(i);
                min = Math.Min(min, ReturnSteps(tempS));
            }
            return min;
        }
    }
}