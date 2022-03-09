using System;
using System.Linq;

namespace _1009._Complement_of_Base_10_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().BitwiseComplement(999999999);
        }
    }

    public class Solution
    {
        public int BitwiseComplement(int n)
        {
            var binary = Convert.ToString(n, 2);
            var flipbinary = string.Join("", binary.Select(x => x is '0' ? '1' : '0'));
            var integer = Convert.ToInt32(flipbinary, 2);

            return integer;
        }
    }
}
