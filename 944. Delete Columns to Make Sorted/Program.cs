namespace _944._Delete_Columns_to_Make_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sArr = { "", "", "" };
            Console.WriteLine(new Solution().MinDeletionSize(sArr));
        }
    }

    public class Solution
    {
        public int MinDeletionSize(string[] strs)
        {
            int resCount = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                string s = "";
                for (int j = 0; j < strs.Length; j++)
                {
                    s += $"{strs[j][i]}";
                }
                var sorteds = string.Join("", s.OrderBy(x => x));
                if (s != sorteds) resCount++;
            }
            return resCount;
        }
    }
}