namespace _6257._Delete_Greatest_Value_in_Each_Row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().DeleteGreatestValue(new int[][]
            {
                new int[]{10},
                //new int[]{3,3,1},
            }));
        }
    }

    public class Solution
    {
        public int DeleteGreatestValue(int[][] grid)
        {
            List<List<int>> g = grid.Select(x => x.OrderByDescending(y => y).ToList()).ToList();

            int sum = 0;
            for (int i = 0; i < grid[0].Length; i++)
            {
                int max = 0;
                g.ForEach(x => max = Math.Max(max, x[i]));
                sum += max;
            }


            return sum;
        }
    }
}