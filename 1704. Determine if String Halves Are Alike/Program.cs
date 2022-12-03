namespace _1704._Determine_if_String_Halves_Are_Alike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "book";
            var res = new Solution().HalvesAreAlike(s);
        }
    }


    public class Solution
    {
        public bool HalvesAreAlike(string s)
        {
            s = s.ToLower();
            var a = s.Substring(0, s.Length / 2);
            var b = s.Substring(s.Length / 2, s.Length / 2);

            var vowel = new char[] { 'a', 'e', 'i', 'o', 'u' };

            var avowel = a.Where(x => vowel.Contains(x)).Count();
            var bvowel = b.Where(x => vowel.Contains(x)).Count();


            return avowel == bvowel;
        }
    }
}