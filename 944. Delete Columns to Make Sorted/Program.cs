namespace _944._Delete_Columns_to_Make_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sArr = { "cba", "daf", "ghi" };
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
                char c = 'a';
                for (int j = 0; j < strs.Length; j++)
                {
                    var cc = strs[j][i];
                    if (cc < c)
                    {
                        resCount++;
                        break;
                    }
                    c = cc;
            }
            }
            return resCount;
        }
    }
}