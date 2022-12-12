namespace _6261._Maximum_Value_of_a_String_in_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().MaximumValue(new string[] { "1", "01", "001", "0001" }));
        }
    }

    public class Solution
    {
        public int MaximumValue(string[] strs)
        {
            int max = 0;

            foreach(var s in strs)
            {
                if (int.TryParse(s, out int no)) max = Math.Max(max, no);
                else max = Math.Max(max, s.Length);
            }

            return max;
        }
    }
}