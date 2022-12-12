namespace _70._Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().ClimbStairs(5));
        }
    }

    //Same simple algorithm written in every offered language.
    //Variable a tells you the number of ways to reach the current step, and b tells you the number of ways to reach the next step.
    //So for the situation one step further up, the old b becomes the new a, and the new b is the old a+b,
    //since that new step can be reached by climbing 1 step from what b represented or 2 steps from what a represented.
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            while (n-- > 0) a = (b += a) - a;
            return a;
        }
    }
}