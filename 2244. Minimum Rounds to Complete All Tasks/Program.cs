namespace _2244._Minimum_Rounds_to_Complete_All_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MinimumRounds(new int[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 }));
        }
    }


    public class Solution
    {
        public int MinimumRounds(int[] tasks)
        {
            int rounds = 0;
            var groupTask = tasks.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var task in groupTask)
            {
                int count = task.Value;

                if (task.Value % 3 is 0) rounds += (task.Value / 3);
                else if (task.Value % 3 is 1)
                {

                }

            }
            return -1;
        }
    }
}