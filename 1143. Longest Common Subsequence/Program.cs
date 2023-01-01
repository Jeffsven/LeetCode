namespace _1143._Longest_Common_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = "hofmr";
            Console.WriteLine(new Solution().LongestCommonSubsequence("hofubmnylkra", "pqhgxgdofcvmr"));
        }
    }

    public class Solution
    {
        public int LongestCommonSubsequence(string a, string b)
        {
            int[,] m = new int[a.Length, b.Length];


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    m[i + 1, j + 1] = a[i] == b[j] ? m[i, j] + 1 : Math.Max(m[i + 1, j], m[i, j + 1]);

                }
            }
            return m[a.Length, b.Length];
        }
    }
}