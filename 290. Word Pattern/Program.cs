namespace _290._Word_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().WordPattern("acc", "dog cat cat fish"));
        }
    }

    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var hash = new Dictionary<char, string>();

            var patternArr = pattern.ToCharArray();
            var sArr = s.Split(" ").ToArray();

            if(patternArr.Length != sArr.Length) return false;

            foreach ((char c, string svalue) in patternArr.Zip(sArr, Tuple.Create))
            {
                if (hash.ContainsValue(svalue))
                {
                    if (!hash.TryGetValue(c, out string value)) return false;
                    if (value != svalue) return false;
                }
                else
                {
                    if (hash.ContainsKey(c)) return false;
                    hash.Add(c, svalue);
                }
            }
            return true;
        }
    }
}